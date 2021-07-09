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
            Cb4Diet.DataSource = Data.Breeds.Select(x => x.DietId).Distinct();
            Cb4Worker.DataSource = Data.Workers.Select(x => x.FullName);


        }

        private void BtnFirstReq_Click(object sender, EventArgs e)
        {
            //grid
        }

        private void BtnSecondReq_Click(object sender, EventArgs e)
        {
            //цех, с наибольшим количеством кур определенной породы;
            MessageBox.Show(Data.Chickens.Where(x=> x.BreedId == Cb2Breed.SelectedIndex).GroupBy(x => Data.Cells.Where(c => c.Id == x.CellId)).Max().ToString());
            MessageBox.Show(Data.Cells.Join(Data.Chickens.Where(x => x.BreedId == Cb2Breed.SelectedIndex) , x => x.Id, x => x.CellId, (x, y) => x)
                                              .GroupBy(x => x.DepartmentNum)
                                              .Max()
                                              .FirstOrDefault().DepartmentNum.ToString()) ;

        }
        private void BtnThirdReq_Click(object sender, EventArgs e)
        {

        }
        private void BtnForthReq_Click(object sender, EventArgs e)
        {

        }

        private void BtnFifthReq_Click(object sender, EventArgs e)
        {

        }
    }
}
