using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KateFirebird
{
    public partial class AdminPanel : Form
    {
        IDataProvider Data = Program.Data;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Btn1AddNewChicken_Click(object sender, EventArgs e)
        {
            var cellId = Data.Cells.FirstOrDefault(x => x.DepartmentNum == (int)Nud1Dep.Value &&
                                                  x.RowNum == (int)Nud1Row.Value &&
                                                  x.CellNum == (int)Nud1CellRow.Value)?.Id;

            if (cellId is null )
            {
                var msg = Cbox1IsAddCell.Checked ? "создаём новую" : String.Empty;
                MessageBox.Show($"Клетка не найдена {msg}");
                if (!Cbox1IsAddCell.Checked)
                    return;

                cellId = Data.Cells.Count;
                Data.Cells.Add(new Cell()
                {
                    Id = Data.Cells.Count,
                    DepartmentNum = (int)Nud1Dep.Value,
                    RowNum = (int)Nud1Row.Value,
                    CellNum = (int)Nud1CellRow.Value
                });
            }

            Data.AddChicken(new Chicken() {Id = Data.Chickens.Count, 
                                           Age = (int) Nud1Age.Value, 
                                           Weight = (int) Nud1Weight.Value, 
                                           BreedId = Cb1Breed.SelectedIndex, 
                                           CellId = cellId });
        }

        private void Btn2RemoveWorker_Click(object sender, EventArgs e)
        {
            Data.DeleteWorker(Cb2FullName.SelectedIndex);
        }

        private void Btn3ChangeChickenWeight_Click(object sender, EventArgs e)
        {
            Data.UpdateChickenWeight(Cb3Id.SelectedIndex, (float) Nud3NewWeight.Value);
        }

        private void Btn4ChangeWeight_Click(object sender, EventArgs e)
        {
            var cellId = Data.Cells.FirstOrDefault(x => x.DepartmentNum == Cb4Dep.SelectedIndex &&
                                                        x.RowNum == Cb4Row.SelectedIndex &&
                                                        x.CellNum == Cb4CellNum.SelectedIndex)?.Id;

            var chickenId = Data.Chickens.FirstOrDefault(x => x.CellId == cellId)?.Id;
            if (!chickenId.HasValue)
            {
                MessageBox.Show($"Кура не найдена");
                return;
            }

            Data.UpdateChickenWeight(chickenId.Value, (float)Nud3NewWeight.Value);
        }


        private void Cb4Dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cb4Row.DataSource = Data.Cells.Where(x => x.DepartmentNum == Cb4Dep.SelectedIndex).Select(x => x.RowNum).Distinct().ToList();

        }

        private void Cb4Row_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cb4CellNum.DataSource = Data.Cells.Where(x => x.DepartmentNum == Cb4Dep.SelectedIndex && x.RowNum == Cb4Row.SelectedIndex).Select(x => x.CellNum).Distinct().ToList();
        }

        private void AdminPanel_Shown(object sender, EventArgs e)
        {
            Cb1Breed.DataSource = Data.Breeds.Select(x => x.Name).ToList();
            Cb2FullName.DataSource = Data.Workers.Select(x => x.FullName).ToList();
            Cb3Id.DataSource = Data.Chickens.Select(x => x.Id).ToList();
            Cb4Dep.DataSource = Data.Cells.Select(x => x.DepartmentNum).Distinct().ToList();
        }
    }
}
