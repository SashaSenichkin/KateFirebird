namespace KateFirebird
{
    partial class StartWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDirPanelOpen = new System.Windows.Forms.Button();
            this.BtnAdminPanelOpen = new System.Windows.Forms.Button();
            this.BtnGetDietHelp = new System.Windows.Forms.Button();
            this.BtnGetReport = new System.Windows.Forms.Button();
            this.CbBreedChoose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDirPanelOpen
            // 
            this.BtnDirPanelOpen.Location = new System.Drawing.Point(12, 12);
            this.BtnDirPanelOpen.Name = "BtnDirPanelOpen";
            this.BtnDirPanelOpen.Size = new System.Drawing.Size(196, 23);
            this.BtnDirPanelOpen.TabIndex = 4;
            this.BtnDirPanelOpen.Text = "директор птицефермы";
            this.BtnDirPanelOpen.UseVisualStyleBackColor = true;
            this.BtnDirPanelOpen.Click += new System.EventHandler(this.BtnDirPanelOpen_Click);
            // 
            // BtnAdminPanelOpen
            // 
            this.BtnAdminPanelOpen.Location = new System.Drawing.Point(12, 55);
            this.BtnAdminPanelOpen.Name = "BtnAdminPanelOpen";
            this.BtnAdminPanelOpen.Size = new System.Drawing.Size(196, 23);
            this.BtnAdminPanelOpen.TabIndex = 5;
            this.BtnAdminPanelOpen.Text = "Администратор БД";
            this.BtnAdminPanelOpen.UseVisualStyleBackColor = true;
            this.BtnAdminPanelOpen.Click += new System.EventHandler(this.BtnAdminPanelOpen_Click);
            // 
            // BtnGetDietHelp
            // 
            this.BtnGetDietHelp.Location = new System.Drawing.Point(12, 102);
            this.BtnGetDietHelp.Name = "BtnGetDietHelp";
            this.BtnGetDietHelp.Size = new System.Drawing.Size(196, 23);
            this.BtnGetDietHelp.TabIndex = 6;
            this.BtnGetDietHelp.Text = "справка о номере диеты";
            this.BtnGetDietHelp.UseVisualStyleBackColor = true;
            this.BtnGetDietHelp.Click += new System.EventHandler(this.BtnGetDietHelp_Click);
            // 
            // BtnGetReport
            // 
            this.BtnGetReport.Location = new System.Drawing.Point(12, 148);
            this.BtnGetReport.Name = "BtnGetReport";
            this.BtnGetReport.Size = new System.Drawing.Size(196, 23);
            this.BtnGetReport.TabIndex = 7;
            this.BtnGetReport.Text = "отчет о работе птицефабрики";
            this.BtnGetReport.UseVisualStyleBackColor = true;
            this.BtnGetReport.Click += new System.EventHandler(this.BtnGetReport_Click);
            // 
            // CbBreedChoose
            // 
            this.CbBreedChoose.FormattingEnabled = true;
            this.CbBreedChoose.Location = new System.Drawing.Point(242, 103);
            this.CbBreedChoose.Name = "CbBreedChoose";
            this.CbBreedChoose.Size = new System.Drawing.Size(121, 23);
            this.CbBreedChoose.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "выбрать породу";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbBreedChoose);
            this.Controls.Add(this.BtnGetReport);
            this.Controls.Add(this.BtnGetDietHelp);
            this.Controls.Add(this.BtnAdminPanelOpen);
            this.Controls.Add(this.BtnDirPanelOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button BtnDirPanelOpen;
        private System.Windows.Forms.Button BtnAdminPanelOpen;
        private System.Windows.Forms.Button BtnGetDietHelp;
        private System.Windows.Forms.Button BtnGetReport;
        private System.Windows.Forms.ComboBox CbBreedChoose;
        private System.Windows.Forms.Label label1;
    }
}