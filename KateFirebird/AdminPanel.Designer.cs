
namespace KateFirebird
{
    partial class AdminPanel
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
            this.Btn1AddNewChicken = new System.Windows.Forms.Button();
            this.Btn2RemoveWorker = new System.Windows.Forms.Button();
            this.Btn3ChangeChickenWeight = new System.Windows.Forms.Button();
            this.Btn4ChangeWeight = new System.Windows.Forms.Button();
            this.Cb3Id = new System.Windows.Forms.ComboBox();
            this.Cb4Dep = new System.Windows.Forms.ComboBox();
            this.Cb4Row = new System.Windows.Forms.ComboBox();
            this.Cb4CellNum = new System.Windows.Forms.ComboBox();
            this.Cb2FullName = new System.Windows.Forms.ComboBox();
            this.Nud1Weight = new System.Windows.Forms.NumericUpDown();
            this.Nud1Age = new System.Windows.Forms.NumericUpDown();
            this.Cb1Breed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Cbox1IsAddCell = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Nud3NewWeight = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Nud4NewWeight = new System.Windows.Forms.NumericUpDown();
            this.Nud1Dep = new System.Windows.Forms.NumericUpDown();
            this.Nud1Row = new System.Windows.Forms.NumericUpDown();
            this.Nud1CellRow = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud3NewWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud4NewWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1Dep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1Row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1CellRow)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn1AddNewChicken
            // 
            this.Btn1AddNewChicken.Location = new System.Drawing.Point(540, 44);
            this.Btn1AddNewChicken.Name = "Btn1AddNewChicken";
            this.Btn1AddNewChicken.Size = new System.Drawing.Size(248, 23);
            this.Btn1AddNewChicken.TabIndex = 0;
            this.Btn1AddNewChicken.Text = "Добавить информацию о новой курице";
            this.Btn1AddNewChicken.UseVisualStyleBackColor = true;
            this.Btn1AddNewChicken.Click += new System.EventHandler(this.Btn1AddNewChicken_Click);
            // 
            // Btn2RemoveWorker
            // 
            this.Btn2RemoveWorker.Location = new System.Drawing.Point(540, 180);
            this.Btn2RemoveWorker.Name = "Btn2RemoveWorker";
            this.Btn2RemoveWorker.Size = new System.Drawing.Size(248, 23);
            this.Btn2RemoveWorker.TabIndex = 2;
            this.Btn2RemoveWorker.Text = "Уволить работника по ФИО";
            this.Btn2RemoveWorker.UseVisualStyleBackColor = true;
            this.Btn2RemoveWorker.Click += new System.EventHandler(this.Btn2RemoveWorker_Click);
            // 
            // Btn3ChangeChickenWeight
            // 
            this.Btn3ChangeChickenWeight.Location = new System.Drawing.Point(540, 261);
            this.Btn3ChangeChickenWeight.Name = "Btn3ChangeChickenWeight";
            this.Btn3ChangeChickenWeight.Size = new System.Drawing.Size(248, 23);
            this.Btn3ChangeChickenWeight.TabIndex = 1;
            this.Btn3ChangeChickenWeight.Text = "Изменить вес курицы по id";
            this.Btn3ChangeChickenWeight.UseVisualStyleBackColor = true;
            this.Btn3ChangeChickenWeight.Click += new System.EventHandler(this.Btn3ChangeChickenWeight_Click);
            // 
            // Btn4ChangeWeight
            // 
            this.Btn4ChangeWeight.Location = new System.Drawing.Point(540, 347);
            this.Btn4ChangeWeight.Name = "Btn4ChangeWeight";
            this.Btn4ChangeWeight.Size = new System.Drawing.Size(248, 23);
            this.Btn4ChangeWeight.TabIndex = 2;
            this.Btn4ChangeWeight.Text = "Изменить вес курицы по клетке";
            this.Btn4ChangeWeight.UseVisualStyleBackColor = true;
            this.Btn4ChangeWeight.Click += new System.EventHandler(this.Btn4ChangeWeight_Click);
            // 
            // Cb3Id
            // 
            this.Cb3Id.FormattingEnabled = true;
            this.Cb3Id.DisplayMember = "Id";
            this.Cb3Id.Location = new System.Drawing.Point(23, 262);
            this.Cb3Id.Name = "Cb3Id";
            this.Cb3Id.Size = new System.Drawing.Size(121, 23);
            this.Cb3Id.Sorted = true;
            this.Cb3Id.TabIndex = 5;
            // 
            // Cb4Dep
            // 
            this.Cb4Dep.FormattingEnabled = true;
            this.Cb4Dep.Location = new System.Drawing.Point(23, 347);
            this.Cb4Dep.Name = "Cb4Dep";
            this.Cb4Dep.Size = new System.Drawing.Size(90, 23);
            this.Cb4Dep.Sorted = true;
            this.Cb4Dep.TabIndex = 6;
            this.Cb4Dep.SelectedIndexChanged += new System.EventHandler(this.Cb4Dep_SelectedIndexChanged);
            // 
            // Cb4Row
            // 
            this.Cb4Row.FormattingEnabled = true;
            this.Cb4Row.Location = new System.Drawing.Point(130, 348);
            this.Cb4Row.Name = "Cb4Row";
            this.Cb4Row.Size = new System.Drawing.Size(101, 23);
            this.Cb4Row.Sorted = true;
            this.Cb4Row.TabIndex = 7;
            this.Cb4Row.SelectedIndexChanged += new System.EventHandler(this.Cb4Row_SelectedIndexChanged);
            // 
            // Cb4CellNum
            // 
            this.Cb4CellNum.FormattingEnabled = true;
            this.Cb4CellNum.Location = new System.Drawing.Point(248, 348);
            this.Cb4CellNum.Name = "Cb4CellNum";
            this.Cb4CellNum.Size = new System.Drawing.Size(94, 23);
            this.Cb4CellNum.Sorted = true;
            this.Cb4CellNum.TabIndex = 8;
            // 
            // Cb2FullName
            // 
            this.Cb2FullName.FormattingEnabled = true;
            this.Cb2FullName.DisplayMember = "FullName";
            this.Cb2FullName.Location = new System.Drawing.Point(23, 180);
            this.Cb2FullName.Name = "Cb2FullName";
            this.Cb2FullName.Size = new System.Drawing.Size(121, 23);
            this.Cb2FullName.Sorted = true;
            this.Cb2FullName.TabIndex = 9;
            // 
            // Nud1Weight
            // 
            this.Nud1Weight.Location = new System.Drawing.Point(23, 44);
            this.Nud1Weight.Name = "Nud1Weight";
            this.Nud1Weight.Size = new System.Drawing.Size(79, 23);
            this.Nud1Weight.TabIndex = 10;
            this.Nud1Weight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Nud1Age
            // 
            this.Nud1Age.Location = new System.Drawing.Point(130, 44);
            this.Nud1Age.Name = "Nud1Age";
            this.Nud1Age.Size = new System.Drawing.Size(78, 23);
            this.Nud1Age.TabIndex = 11;
            this.Nud1Age.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cb1Breed
            // 
            this.Cb1Breed.DisplayMember = "Name";
            this.Cb1Breed.FormattingEnabled = true;
            this.Cb1Breed.Location = new System.Drawing.Point(238, 44);
            this.Cb1Breed.Name = "Cb1Breed";
            this.Cb1Breed.Size = new System.Drawing.Size(121, 23);
            this.Cb1Breed.Sorted = true;
            this.Cb1Breed.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Вес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Порода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Номер курицы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Номер цеха";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Номер ряда";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Номер в ряду";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Номер в ряду";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Номер ряда";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Номер цеха";
            // 
            // Cbox1IsAddCell
            // 
            this.Cbox1IsAddCell.AutoSize = true;
            this.Cbox1IsAddCell.Location = new System.Drawing.Point(540, 97);
            this.Cbox1IsAddCell.Name = "Cbox1IsAddCell";
            this.Cbox1IsAddCell.Size = new System.Drawing.Size(237, 19);
            this.Cbox1IsAddCell.TabIndex = 29;
            this.Cbox1IsAddCell.Text = "Создать клетку, если не будет найдена";
            this.Cbox1IsAddCell.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 10);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 10);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.pictureBox3.Location = new System.Drawing.Point(0, 304);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(800, 10);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // Nud3NewWeight
            // 
            this.Nud3NewWeight.Location = new System.Drawing.Point(359, 263);
            this.Nud3NewWeight.Name = "Nud3NewWeight";
            this.Nud3NewWeight.Size = new System.Drawing.Size(79, 23);
            this.Nud3NewWeight.TabIndex = 33;
            this.Nud3NewWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Новый вес";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(401, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 36;
            this.label13.Text = "Новый вес";
            // 
            // Nud4NewWeight
            // 
            this.Nud4NewWeight.Location = new System.Drawing.Point(401, 347);
            this.Nud4NewWeight.Name = "Nud4NewWeight";
            this.Nud4NewWeight.Size = new System.Drawing.Size(79, 23);
            this.Nud4NewWeight.TabIndex = 35;
            this.Nud4NewWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Nud1Dep
            // 
            this.Nud1Dep.Location = new System.Drawing.Point(23, 97);
            this.Nud1Dep.Name = "Nud1Dep";
            this.Nud1Dep.Size = new System.Drawing.Size(79, 23);
            this.Nud1Dep.TabIndex = 37;
            this.Nud1Dep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Nud1Row
            // 
            this.Nud1Row.Location = new System.Drawing.Point(190, 97);
            this.Nud1Row.Name = "Nud1Row";
            this.Nud1Row.Size = new System.Drawing.Size(79, 23);
            this.Nud1Row.TabIndex = 38;
            this.Nud1Row.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Nud1CellRow
            // 
            this.Nud1CellRow.Location = new System.Drawing.Point(359, 97);
            this.Nud1CellRow.Name = "Nud1CellRow";
            this.Nud1CellRow.Size = new System.Drawing.Size(79, 23);
            this.Nud1CellRow.TabIndex = 39;
            this.Nud1CellRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.Nud1CellRow);
            this.Controls.Add(this.Nud1Row);
            this.Controls.Add(this.Nud1Dep);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Nud4NewWeight);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Nud3NewWeight);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cbox1IsAddCell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb1Breed);
            this.Controls.Add(this.Nud1Age);
            this.Controls.Add(this.Nud1Weight);
            this.Controls.Add(this.Cb2FullName);
            this.Controls.Add(this.Cb4CellNum);
            this.Controls.Add(this.Cb4Row);
            this.Controls.Add(this.Cb4Dep);
            this.Controls.Add(this.Cb3Id);
            this.Controls.Add(this.Btn4ChangeWeight);
            this.Controls.Add(this.Btn3ChangeChickenWeight);
            this.Controls.Add(this.Btn2RemoveWorker);
            this.Controls.Add(this.Btn1AddNewChicken);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Shown += new System.EventHandler(this.AdminPanel_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Nud1Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud3NewWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud4NewWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1Dep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1Row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1CellRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1AddNewChicken;
        private System.Windows.Forms.Button Btn2RemoveWorker;
        private System.Windows.Forms.Button Btn3ChangeChickenWeight;
        private System.Windows.Forms.Button Btn4ChangeWeight;
        private System.Windows.Forms.ComboBox Cb3Id;
        private System.Windows.Forms.ComboBox Cb4Dep;
        private System.Windows.Forms.ComboBox Cb4Row;
        private System.Windows.Forms.ComboBox Cb4CellNum;
        private System.Windows.Forms.ComboBox Cb2FullName;
        private System.Windows.Forms.NumericUpDown Nud1Weight;
        private System.Windows.Forms.NumericUpDown Nud1Age;
        private System.Windows.Forms.ComboBox Cb1Breed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox Cbox1IsAddCell;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown Nud3NewWeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown Nud4NewWeight;
        private System.Windows.Forms.NumericUpDown Nud1Dep;
        private System.Windows.Forms.NumericUpDown Nud1Row;
        private System.Windows.Forms.NumericUpDown Nud1CellRow;
    }
}