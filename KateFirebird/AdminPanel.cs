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
                                           BreedId = ((Breed)Cb1Breed.SelectedItem).Id, 
                                           CellId = cellId });
        }

        private void Btn2RemoveWorker_Click(object sender, EventArgs e)
        {
            Data.DeleteWorker(((Worker)Cb2FullName.SelectedItem).Id);
        }

        private void Btn3ChangeChickenWeight_Click(object sender, EventArgs e)
        {
            Data.UpdateChickenWeight(((Chicken)Cb3Id.SelectedItem).Id, (float) Nud3NewWeight.Value);
        }

        private void Btn4ChangeWeight_Click(object sender, EventArgs e)
        {
            var cellId = Data.Cells.FirstOrDefault(x => x.DepartmentNum == (int) Cb4Dep.SelectedItem &&
                                                        x.RowNum == (int) Cb4Row.SelectedItem &&
                                                        x.CellNum == (int) Cb4CellNum.SelectedItem)?.Id;

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
            Cb4Row.DataSource = Data.Cells.Where(x => x.DepartmentNum == (int) Cb4Dep.SelectedItem).Select(x => x.RowNum).Distinct().ToList();

        }

        private void Cb4Row_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cb4CellNum.DataSource = Data.Cells.Where(x => x.DepartmentNum == (int) Cb4Dep.SelectedItem && x.RowNum == (int)Cb4Row.SelectedItem).Select(x => x.CellNum).Distinct().ToList();
        }

        private void AdminPanel_Shown(object sender, EventArgs e)
        {
            Cb1Breed.DataSource = Data.Breeds;
            Cb1Breed.DisplayMember = "Name";

            Cb2FullName.DataSource = Data.Workers;
            Cb2FullName.DisplayMember = "FullName";

            Cb3Id.DataSource = Data.Chickens;
            Cb3Id.DisplayMember = "Id";

            Cb4Dep.DataSource = Data.Cells.Select(x => x.DepartmentNum).Distinct().ToList();
        }
    }
}
