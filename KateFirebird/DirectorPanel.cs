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

        IDataProvider Data = new RandomRata();

        public DirectorPanel()
        {
            InitializeComponent();
            Cb1Breed.DataSource = Data.Breeds.Select(x => x.Name);
            Cb2Breed.DataSource = Data.Breeds.Select(x => x.Name);
            Cb2Department.DataSource = Data.Cells.Select(x => x.DepartmentNum).Distinct(); 
            Cb3Diet.DataSource = Data.Breeds.Select(x => x.DietId).Distinct();
            Cb4Worker.DataSource = Data.Workers.Select(x => x.FullName);


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

            var chickens = RequestLogic.GetEggsCountByParams(Data, weigthFrom, weigthTo, Cb1Breed.SelectedIndex, (int)Nud1Age.Value);
            MessageBox.Show(String.Concat(Environment.NewLine, chickens.Select(x => $"кура {x.Id} (вес {x.Weight}, возраст {x.Age}) несёт{x.EddCount}" ))); ;
        }

        private void BtnSecondReq_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RequestLogic.GetDepartmentWithBreed(Data, Cb2Breed.SelectedIndex)?.ToString() ?? "NoData");
        }



        private void BtnThirdReq_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Concat(Environment.NewLine, RequestLogic.GetCellByAgeAndDiet(Data, (int) Nud3Age.Value, Cb3Diet.SelectedIndex)));
        }


        private void BtnForthReq_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RequestLogic.GetEggsCountByWorker(Data, Cb4Worker.SelectedIndex)?.ToString() ?? "NoData");
        }

        private void BtnFifthReq_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RequestLogic.GetDepartmentWithMaxEggs(Data)?.ToString() ?? "NoData");

        }
    }
}
