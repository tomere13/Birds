namespace LoginPage
{
    partial class Addbird
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
            groupBox1 = new GroupBox();
            BodyColorcmb = new ComboBox();
            ChestColorcmb = new ComboBox();
            HeadColorcmb = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            BackBtn = new Button();
            FinalAddbtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            cagenumber = new TextBox();
            fatherserialnumber = new TextBox();
            motherserialnumber = new TextBox();
            GendercomboBox = new ComboBox();
            SubspeciescomboBox = new ComboBox();
            SpeciescomboBox = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Exit = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(BodyColorcmb);
            groupBox1.Controls.Add(ChestColorcmb);
            groupBox1.Controls.Add(HeadColorcmb);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(BackBtn);
            groupBox1.Controls.Add(FinalAddbtn);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(cagenumber);
            groupBox1.Controls.Add(fatherserialnumber);
            groupBox1.Controls.Add(motherserialnumber);
            groupBox1.Controls.Add(GendercomboBox);
            groupBox1.Controls.Add(SubspeciescomboBox);
            groupBox1.Controls.Add(SpeciescomboBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(8, 7);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(512, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Bird";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BodyColorcmb
            // 
            BodyColorcmb.FormattingEnabled = true;
            BodyColorcmb.Location = new Point(390, 139);
            BodyColorcmb.Margin = new Padding(2);
            BodyColorcmb.Name = "BodyColorcmb";
            BodyColorcmb.Size = new Size(91, 31);
            BodyColorcmb.TabIndex = 22;
            BodyColorcmb.SelectedIndexChanged += BodyColorcmb_SelectedIndexChanged;
            // 
            // ChestColorcmb
            // 
            ChestColorcmb.FormattingEnabled = true;
            ChestColorcmb.Items.AddRange(new object[] { "Purple", "Lilac", "White" });
            ChestColorcmb.Location = new Point(390, 102);
            ChestColorcmb.Margin = new Padding(2);
            ChestColorcmb.Name = "ChestColorcmb";
            ChestColorcmb.Size = new Size(91, 31);
            ChestColorcmb.TabIndex = 21;
            ChestColorcmb.SelectedIndexChanged += ChestColorcmb_SelectedIndexChanged;
            // 
            // HeadColorcmb
            // 
            HeadColorcmb.BackColor = Color.White;
            HeadColorcmb.FlatStyle = FlatStyle.System;
            HeadColorcmb.FormattingEnabled = true;
            HeadColorcmb.Items.AddRange(new object[] { "Red", "Black", "Yellow" });
            HeadColorcmb.Location = new Point(390, 63);
            HeadColorcmb.Margin = new Padding(2);
            HeadColorcmb.Name = "HeadColorcmb";
            HeadColorcmb.Size = new Size(91, 31);
            HeadColorcmb.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(280, 139);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(92, 23);
            label10.TabIndex = 19;
            label10.Text = "Body Color :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(279, 102);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(93, 23);
            label9.TabIndex = 18;
            label9.Text = "Chest Color :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(279, 63);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 23);
            label8.TabIndex = 17;
            label8.Text = "Head Color :";
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.LightBlue;
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatStyle = FlatStyle.Popup;
            BackBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.Black;
            BackBtn.Location = new Point(371, 242);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(128, 29);
            BackBtn.TabIndex = 15;
            BackBtn.Text = "Main menu";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // FinalAddbtn
            // 
            FinalAddbtn.BackColor = Color.LightBlue;
            FinalAddbtn.Cursor = Cursors.Hand;
            FinalAddbtn.FlatAppearance.BorderSize = 0;
            FinalAddbtn.FlatStyle = FlatStyle.Popup;
            FinalAddbtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FinalAddbtn.ForeColor = Color.Black;
            FinalAddbtn.Location = new Point(371, 206);
            FinalAddbtn.Margin = new Padding(2);
            FinalAddbtn.Name = "FinalAddbtn";
            FinalAddbtn.Size = new Size(128, 29);
            FinalAddbtn.TabIndex = 14;
            FinalAddbtn.Text = "Add";
            FinalAddbtn.UseVisualStyleBackColor = false;
            FinalAddbtn.Click += FinalAddbtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.LightBlue;
            dateTimePicker1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(100, 242);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 22);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cagenumber
            // 
            cagenumber.BackColor = Color.White;
            cagenumber.BorderStyle = BorderStyle.FixedSingle;
            cagenumber.Location = new Point(390, 23);
            cagenumber.Margin = new Padding(2);
            cagenumber.Name = "cagenumber";
            cagenumber.Size = new Size(91, 30);
            cagenumber.TabIndex = 12;
            cagenumber.TextChanged += cagenumber_TextChanged;
            // 
            // fatherserialnumber
            // 
            fatherserialnumber.BackColor = Color.White;
            fatherserialnumber.BorderStyle = BorderStyle.FixedSingle;
            fatherserialnumber.Location = new Point(172, 196);
            fatherserialnumber.Margin = new Padding(2);
            fatherserialnumber.Name = "fatherserialnumber";
            fatherserialnumber.Size = new Size(88, 30);
            fatherserialnumber.TabIndex = 11;
            // 
            // motherserialnumber
            // 
            motherserialnumber.BackColor = Color.White;
            motherserialnumber.BorderStyle = BorderStyle.FixedSingle;
            motherserialnumber.Location = new Point(172, 153);
            motherserialnumber.Margin = new Padding(2);
            motherserialnumber.Name = "motherserialnumber";
            motherserialnumber.Size = new Size(88, 30);
            motherserialnumber.TabIndex = 10;
            // 
            // GendercomboBox
            // 
            GendercomboBox.FormattingEnabled = true;
            GendercomboBox.Items.AddRange(new object[] { "Male", "Female" });
            GendercomboBox.Location = new Point(100, 105);
            GendercomboBox.Margin = new Padding(2);
            GendercomboBox.Name = "GendercomboBox";
            GendercomboBox.Size = new Size(129, 31);
            GendercomboBox.TabIndex = 9;
            GendercomboBox.SelectedIndexChanged += GendercomboBox_SelectedIndexChanged;
            // 
            // SubspeciescomboBox
            // 
            SubspeciescomboBox.FormattingEnabled = true;
            SubspeciescomboBox.Location = new Point(100, 66);
            SubspeciescomboBox.Margin = new Padding(2);
            SubspeciescomboBox.Name = "SubspeciescomboBox";
            SubspeciescomboBox.Size = new Size(129, 31);
            SubspeciescomboBox.TabIndex = 8;
            SubspeciescomboBox.SelectedIndexChanged += SubspeciescomboBox_SelectedIndexChanged;
            // 
            // SpeciescomboBox
            // 
            SpeciescomboBox.FormattingEnabled = true;
            SpeciescomboBox.Items.AddRange(new object[] { "American Gouldian", "European Gouldian", "Australian Gouldian" });
            SpeciescomboBox.Location = new Point(100, 23);
            SpeciescomboBox.Margin = new Padding(2);
            SpeciescomboBox.Name = "SpeciescomboBox";
            SpeciescomboBox.Size = new Size(129, 31);
            SpeciescomboBox.TabIndex = 7;
            SpeciescomboBox.SelectedIndexChanged += SpeciescomboBox_SelectedIndex;
            // 
            // label7
            // 
            label7.Location = new Point(7, 240);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 29);
            label7.TabIndex = 6;
            label7.Text = "Hatch date:";
            // 
            // label6
            // 
            label6.Location = new Point(280, 23);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 5;
            label6.Text = "Cage number :";
            // 
            // label5
            // 
            label5.Location = new Point(7, 198);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(164, 37);
            label5.TabIndex = 4;
            label5.Text = "Father serial number :";
            // 
            // label4
            // 
            label4.Location = new Point(7, 155);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 29);
            label4.TabIndex = 3;
            label4.Text = "Mother serial number :";
            // 
            // label3
            // 
            label3.Location = new Point(7, 105);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 2;
            label3.Text = "Gender:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Location = new Point(7, 66);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 1;
            label2.Text = "Subspecies:";
            // 
            // label1
            // 
            label1.Location = new Point(7, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 0;
            label1.Text = "Species:";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.chick;
            pictureBox1.Image = Properties.Resources.chick;
            pictureBox1.Location = new Point(525, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            Exit.Cursor = Cursors.Hand;
            Exit.Image = Properties.Resources.standby;
            Exit.Location = new Point(786, -2);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 36);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 9;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // Addbird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(826, 307);
            Controls.Add(Exit);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Addbird";
            Text = "Addbird";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox cagenumber;
        private TextBox fatherserialnumber;
        private TextBox motherserialnumber;
        private ComboBox GendercomboBox;
        private ComboBox SubspeciescomboBox;
        private ComboBox SpeciescomboBox;
        private Button FinalAddbtn;
        private Button BackBtn;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox BodyColorcmb;
        private ComboBox ChestColorcmb;
        private ComboBox HeadColorcmb;
        private PictureBox pictureBox1;
        private PictureBox Exit;
    }
}