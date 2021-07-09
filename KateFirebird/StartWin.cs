using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KateFirebird
{
    public partial class StartWin : Form
    {
        public StartWin()
        {
            InitializeComponent();
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
            RequestLogic.GetDietByBreedId(Program.Data, CbBreedChoose.SelectedIndex);
        }

        private void BtnGetReport_Click(object sender, EventArgs e)
        {

        }
    }
}
