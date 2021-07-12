using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KateFirebird
{
    public partial class StartWin : Form
    {
        IDataProvider Data = Program.Data;
        public StartWin()
        {
            InitializeComponent();
            CbBreedChoose.DataSource = Data.Breeds.Select(x => x.Name).ToList();
        }

        private void BtnDirPanelOpen_Click(object sender, EventArgs e)
        {
            Program.DirPanel.ShowDialog();
        }

        private void BtnAdminPanelOpen_Click(object sender, EventArgs e)
        {
            Program.AdminPanel.ShowDialog();
        }

        private void BtnGetDietHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RequestLogic.GetDietByBreedId(Data, ((Breed)CbBreedChoose.SelectedItem).Id).ToString());
        }

        private void BtnGetReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetFullReport());
        }

        /// <summary>
        /// общее количество кур и их средняя производительность для каждой породы, общее количество яиц, получаемое птицефабрикой, число работниц(сексизм?) на фабрике и распределение их по цехам
        /// </summary>
        /// <returns></returns>
        private string GetFullReport()
        {
            var result = new StringBuilder();
            result.Append("Ковальски, отчёт! ");
            result.Append(Environment.NewLine);
            result.Append($"общее количество кур {Data.Chickens.Count}");
            result.Append(Environment.NewLine);
            result.Append($"средняя производительность для каждой породы");
            result.Append(Environment.NewLine);
            result.Append(String.Join(Environment.NewLine, Data.Chickens.GroupBy(x => x.BreedId).Select(x => $"породa {x.Key} в среднем {x.Average(y => y.EddCount)} яиц")));
            result.Append(Environment.NewLine);
            result.Append($"общее количество яиц, получаемое птицефабрикой {Data.Chickens.Sum(x => x.EddCount)}");
            result.Append(Environment.NewLine);
            result.Append($"число работниц на фабрике {Data.Workers.Count}");
            result.Append(Environment.NewLine);
            result.Append($"распределение работниц по цехам:");
            result.Append(Environment.NewLine);

            var depGroups = Data.Cells.GroupBy(x => x.DepartmentNum).Select(x => String.Join(Environment.NewLine, 
                                                                            $" в цеху {x.Key + Environment.NewLine} {String.Join(Environment.NewLine, x.Select( y => GetFullNameById(y.WorkerId)))}"));
            result.Append(String.Join(Environment.NewLine, depGroups));
            return result.ToString();

        }

        private string GetFullNameById(int? id)
        {
            return Data.Workers.FirstOrDefault(x => x.Id == id)?.FullName;
        }
    }
}
