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

            MessageBox.Show($"кура добавлена");
        }

        private void Btn2RemoveWorker_Click(object sender, EventArgs e)
        {
            Data.DeleteWorker(((Worker)Cb2FullName.SelectedItem).Id);
            MessageBox.Show($"рабочий удалён");

        }

        private void Btn3ChangeChickenWeight_Click(object sender, EventArgs e)
        {
            Data.UpdateChickenWeight(((Chicken)Cb3Id.SelectedItem).Id, (float) Nud3NewWeight.Value);
            MessageBox.Show($"вес изменен");

        }

        private void Btn4ChangeWeight_Click(object sender, EventArgs e)
        {
            if (Cb4Dep.SelectedItem == null || Cb4Row.SelectedItem == null || Cb4CellNum.SelectedItem == null)
            {
                MessageBox.Show($"Не выбрано положение клетки");
                return;
            }

            var cellId = Data.Cells.FirstOrDefault(x => x.DepartmentNum == int.Parse((string)Cb4Dep.SelectedItem) &&
                                                        x.RowNum == int.Parse((string)Cb4Row.SelectedItem) &&
                                                        x.CellNum == int.Parse((string)Cb4CellNum.SelectedItem))?.Id;

            var chickenId = Data.Chickens.FirstOrDefault(x => x.CellId == cellId)?.Id;
            if (!chickenId.HasValue)
            {
                MessageBox.Show($"Кура не найдена");
                return;
            }

            MessageBox.Show($"вес изменен");
            Data.UpdateChickenWeight(chickenId.Value, (float)Nud3NewWeight.Value);
        }


        private void Cb4Dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cb4Row.Items.Clear();

            Cb4Row.Items.AddRange(Data.Cells.Where(x => x.DepartmentNum == int.Parse((string) Cb4Dep.SelectedItem)).Select(x => x.RowNum.ToString()).Distinct().ToArray());

        }

        private void Cb4Row_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cb4CellNum.Items.Clear();
            Cb4CellNum.Items.AddRange(Data.Cells.Where(x => x.DepartmentNum == int.Parse((string)Cb4Dep.SelectedItem) 
                                                       && x.RowNum == int.Parse((string)Cb4Dep.SelectedItem)).Select(x => x.CellNum.ToString()).Distinct().ToArray());
        }

        private void AdminPanel_Shown(object sender, EventArgs e)
        {
            Cb1Breed.DataSource = Data.Breeds;

            Cb2FullName.DataSource = Data.Workers;

            Cb3Id.DataSource = Data.Chickens;

            Cb4Dep.Items.Clear();
            Cb4Dep.Items.AddRange(Data.Cells.Select(x => x.DepartmentNum.ToString()).Distinct().ToArray());
        }
    }
}
