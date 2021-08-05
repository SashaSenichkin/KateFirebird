using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KateFirebird
{
    public partial class DirectorPanel : Form
    {

        IDataProvider Data = Program.Data;

        public DirectorPanel()
        {
            InitializeComponent();
        }

        private void BtnFirstReq_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Tb1WeightFrom.Text, out int weigthFrom))
            {
                MessageBox.Show($"incorrect number in {Tb1WeightFrom.Name} ");
                return;
            }

            if (!int.TryParse(Tb1WeightTo.Text, out int weigthTo))
            {
                MessageBox.Show($"incorrect number in {Tb1WeightTo.Name} ");
                return;
            }

            if (weigthFrom > weigthTo)
            {
                MessageBox.Show("from bigger then to. swapped");
                weigthFrom += weigthTo;
                weigthTo = weigthFrom - weigthTo;
                weigthFrom = weigthFrom - weigthTo;
            }

            var chickens = RequestLogic.GetEggsCountByParams(Data, weigthFrom, weigthTo, ((Breed)Cb1Breed.SelectedItem).Id, (int)Nud1Age.Value);
            if (chickens.Any())
                MessageBox.Show(String.Join(Environment.NewLine, chickens.Select(x => $"кура {x.Id} (вес {x.Weight}, возраст {x.Age}) несёт {x.EggCount} яиц").ToArray()));
            else
                MessageBox.Show("не найдено ни одной куры, удолетворяющей запросу");

        }

        private void BtnSecondReq_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RequestLogic.GetDepartmentWithBreed(Data, ((Breed)Cb2Breed.SelectedItem).Id)?.ToString() ?? "NoData");

        }



        private void BtnThirdReq_Click(object sender, EventArgs e)
        {
            if (Cb3Diet.SelectedItem == null)
            {
                MessageBox.Show("выберите диету");
                return;
            }

            var result = RequestLogic.GetCellByAgeAndDiet(Data,
                                                         (int)Nud3Age.Value,
                                                         int.Parse((string)Cb3Diet.SelectedItem));

            if (result.Any())
                MessageBox.Show(String.Join(Environment.NewLine, result.Select(x => x.Id)));
            else
                MessageBox.Show("не найдено ни одной клетки, удолетворяющей запросу");

        }


        private void BtnForthReq_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RequestLogic.GetEggsCountByWorker(Data, ((Worker)Cb4Worker.SelectedItem).Id)?.ToString() ?? "NoData");
        }

        private void BtnFifthReq_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RequestLogic.GetDepartmentWithMaxEggs(Data)?.ToString() ?? "NoData");
        }

        private void DirectorPanel_Shown(object sender, EventArgs e)
        {
            Cb1Breed.DataSource = Data.Breeds;

            Cb2Breed.DataSource = Data.Breeds;

            Cb3Diet.Items.Clear();
            Cb3Diet.Items.AddRange(Data.Breeds.Select(x => x.DietId.ToString()).Distinct().ToArray());

            Cb4Worker.DataSource = Data.Workers;

        }
    }
}
