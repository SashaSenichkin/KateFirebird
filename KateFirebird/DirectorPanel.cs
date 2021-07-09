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
        Repository<Breed> Breeds = new Repository<Breed>();
        Repository<Cell> Cells = new Repository<Cell>();
        Repository<Chicken> Chickens = new Repository<Chicken>();
        Repository<Worker> Workers = new Repository<Worker>();



        public DirectorPanel()
        {
            InitializeComponent();
            Cb1Breed.DataSource = Breeds.GetAllData().Select(x => x.Name);
            Cb2Breed.DataSource = Breeds.GetAllData().Select(x => x.Name);
            Cb2Department.DataSource = Cells.GetAllData().Select(x => x.DepartmentNum).Distinct(); 
            Cb4Diet.DataSource = Breeds.GetAllData().Select(x => x.DietId).Distinct();
            Cb4Worker.DataSource = Workers.GetAllData().Select(x => x.FullName);


        }

        private void BtnFirstReq_Click(object sender, EventArgs e)
        {
            //grid
        }

        private void BtnSecondReq_Click(object sender, EventArgs e)
        {
            //цех, с наибольшим количеством кур определенной породы;
            MessageBox.Show(Chickens.GetAllData().Where(x=> x.BreedId == Cb2Breed.SelectedIndex).GroupBy(x => Cells.GetAllData().Where(c => c.Id == x.CellId)).Max().ToString());
            MessageBox.Show(Cells.GetAllData().Join(Chickens.GetAllData().Where(x => x.BreedId == Cb2Breed.SelectedIndex) , x => x.Id, x => x.CellId, (x, y) => x)
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
