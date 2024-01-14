namespace LoginPage
{
    partial class Addchick
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
            chickGroup = new GroupBox();
            ChangeCage = new Button();
            cageTxt = new TextBox();
            bodyCLabel = new Label();
            ChestCLabel = new Label();
            HeadCLabel = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            genderLabel = new Label();
            subLabel = new Label();
            SpacieLabel = new Label();
            IdLabel = new Label();
            chickGenderCombo = new ComboBox();
            dateChickBox = new DateTimePicker();
            addChickBtn = new Button();
            motherChickBox = new TextBox();
            fatherChickBox = new TextBox();
            FatherIdLabel = new Label();
            motherIdLabel = new Label();
            chickGenderLabel = new Label();
            dateChickLabel = new Label();
            pictureBox1 = new PictureBox();
            Exit = new PictureBox();
            chickGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            SuspendLayout();
            // 
            // chickGroup
            // 
            chickGroup.BackColor = Color.LightBlue;
            chickGroup.Controls.Add(ChangeCage);
            chickGroup.Controls.Add(cageTxt);
            chickGroup.Controls.Add(bodyCLabel);
            chickGroup.Controls.Add(ChestCLabel);
            chickGroup.Controls.Add(HeadCLabel);
            chickGroup.Controls.Add(label8);
            chickGroup.Controls.Add(label7);
            chickGroup.Controls.Add(label6);
            chickGroup.Controls.Add(label5);
            chickGroup.Controls.Add(label4);
            chickGroup.Controls.Add(label3);
            chickGroup.Controls.Add(label2);
            chickGroup.Controls.Add(label1);
            chickGroup.Controls.Add(genderLabel);
            chickGroup.Controls.Add(subLabel);
            chickGroup.Controls.Add(SpacieLabel);
            chickGroup.Controls.Add(IdLabel);
            chickGroup.Controls.Add(chickGenderCombo);
            chickGroup.Controls.Add(dateChickBox);
            chickGroup.Controls.Add(addChickBtn);
            chickGroup.Controls.Add(motherChickBox);
            chickGroup.Controls.Add(fatherChickBox);
            chickGroup.Controls.Add(FatherIdLabel);
            chickGroup.Controls.Add(motherIdLabel);
            chickGroup.Controls.Add(chickGenderLabel);
            chickGroup.Controls.Add(dateChickLabel);
            chickGroup.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chickGroup.ForeColor = Color.Black;
            chickGroup.Location = new Point(12, 12);
            chickGroup.Name = "chickGroup";
            chickGroup.Padding = new Padding(10);
            chickGroup.Size = new Size(624, 336);
            chickGroup.TabIndex = 0;
            chickGroup.TabStop = false;
            // 
            // ChangeCage
            // 
            ChangeCage.BackColor = Color.LightBlue;
            ChangeCage.FlatAppearance.BorderColor = Color.White;
            ChangeCage.FlatStyle = FlatStyle.Popup;
            ChangeCage.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeCage.ForeColor = Color.Black;
            ChangeCage.Location = new Point(193, 216);
            ChangeCage.Name = "ChangeCage";
            ChangeCage.Size = new Size(141, 31);
            ChangeCage.TabIndex = 30;
            ChangeCage.Text = "Change Cage";
            ChangeCage.UseVisualStyleBackColor = false;
            ChangeCage.Click += ChangeCage_Click;
            // 
            // cageTxt
            // 
            cageTxt.Location = new Point(125, 218);
            cageTxt.Name = "cageTxt";
            cageTxt.Size = new Size(56, 30);
            cageTxt.TabIndex = 29;
            cageTxt.TextChanged += cageTxt_TextChanged;
            // 
            // bodyCLabel
            // 
            bodyCLabel.Location = new Point(125, 189);
            bodyCLabel.Name = "bodyCLabel";
            bodyCLabel.Size = new Size(157, 26);
            bodyCLabel.TabIndex = 27;
            bodyCLabel.Text = "label8";
            // 
            // ChestCLabel
            // 
            ChestCLabel.Location = new Point(125, 163);
            ChestCLabel.Name = "ChestCLabel";
            ChestCLabel.Size = new Size(157, 26);
            ChestCLabel.TabIndex = 26;
            ChestCLabel.Text = "label7";
            // 
            // HeadCLabel
            // 
            HeadCLabel.Location = new Point(125, 136);
            HeadCLabel.Name = "HeadCLabel";
            HeadCLabel.Size = new Size(157, 26);
            HeadCLabel.TabIndex = 25;
            HeadCLabel.Text = "label6";
            // 
            // label8
            // 
            label8.Location = new Point(13, 189);
            label8.Name = "label8";
            label8.Size = new Size(106, 26);
            label8.TabIndex = 24;
            label8.Text = "Body Color:";
            // 
            // label7
            // 
            label7.Location = new Point(13, 162);
            label7.Name = "label7";
            label7.Size = new Size(106, 26);
            label7.TabIndex = 23;
            label7.Text = "Chest Color:";
            // 
            // label6
            // 
            label6.Location = new Point(13, 136);
            label6.Name = "label6";
            label6.Size = new Size(106, 26);
            label6.TabIndex = 22;
            label6.Text = "Head Color:";
            // 
            // label5
            // 
            label5.Location = new Point(13, 221);
            label5.Name = "label5";
            label5.Size = new Size(106, 26);
            label5.TabIndex = 21;
            label5.Text = "Cage ID:";
            // 
            // label4
            // 
            label4.Location = new Point(13, 110);
            label4.Name = "label4";
            label4.Size = new Size(106, 26);
            label4.TabIndex = 20;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.Location = new Point(13, 84);
            label3.Name = "label3";
            label3.Size = new Size(106, 26);
            label3.TabIndex = 19;
            label3.Text = "Subspacie:";
            // 
            // label2
            // 
            label2.Location = new Point(13, 58);
            label2.Name = "label2";
            label2.Size = new Size(106, 26);
            label2.TabIndex = 18;
            label2.Text = "Spacie:";
            // 
            // label1
            // 
            label1.Location = new Point(13, 29);
            label1.Name = "label1";
            label1.Size = new Size(106, 26);
            label1.TabIndex = 17;
            label1.Text = "Bird ID:";
            // 
            // genderLabel
            // 
            genderLabel.Location = new Point(125, 110);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(157, 26);
            genderLabel.TabIndex = 15;
            genderLabel.Text = "label4";
            // 
            // subLabel
            // 
            subLabel.Location = new Point(125, 84);
            subLabel.Name = "subLabel";
            subLabel.Size = new Size(157, 26);
            subLabel.TabIndex = 14;
            subLabel.Text = "label3";
            subLabel.Click += subLabel_Click;
            // 
            // SpacieLabel
            // 
            SpacieLabel.Location = new Point(125, 58);
            SpacieLabel.Name = "SpacieLabel";
            SpacieLabel.Size = new Size(157, 26);
            SpacieLabel.TabIndex = 13;
            SpacieLabel.Text = "label2";
            SpacieLabel.Click += SpacieLabel_Click;
            // 
            // IdLabel
            // 
            IdLabel.Location = new Point(125, 32);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(157, 26);
            IdLabel.TabIndex = 12;
            IdLabel.Text = "label1";
            IdLabel.Click += IdLabel_Click;
            // 
            // chickGenderCombo
            // 
            chickGenderCombo.FormattingEnabled = true;
            chickGenderCombo.Items.AddRange(new object[] { "Male", "Female" });
            chickGenderCombo.Location = new Point(411, 73);
            chickGenderCombo.Name = "chickGenderCombo";
            chickGenderCombo.Size = new Size(200, 31);
            chickGenderCombo.TabIndex = 11;
            // 
            // dateChickBox
            // 
            dateChickBox.Format = DateTimePickerFormat.Short;
            dateChickBox.Location = new Point(411, 26);
            dateChickBox.Name = "dateChickBox";
            dateChickBox.Size = new Size(200, 30);
            dateChickBox.TabIndex = 10;
            // 
            // addChickBtn
            // 
            addChickBtn.BackColor = Color.LightBlue;
            addChickBtn.Cursor = Cursors.Hand;
            addChickBtn.FlatAppearance.BorderSize = 0;
            addChickBtn.FlatStyle = FlatStyle.Popup;
            addChickBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addChickBtn.ForeColor = Color.Black;
            addChickBtn.Location = new Point(471, 162);
            addChickBtn.Name = "addChickBtn";
            addChickBtn.Size = new Size(140, 33);
            addChickBtn.TabIndex = 1;
            addChickBtn.Text = "Add Chick";
            addChickBtn.UseVisualStyleBackColor = false;
            addChickBtn.Click += addChickBtn_Click;
            // 
            // motherChickBox
            // 
            motherChickBox.Location = new Point(411, 118);
            motherChickBox.Name = "motherChickBox";
            motherChickBox.Size = new Size(200, 30);
            motherChickBox.TabIndex = 7;
            motherChickBox.Visible = false;
            motherChickBox.TextChanged += textBox1_TextChanged;
            // 
            // fatherChickBox
            // 
            fatherChickBox.Location = new Point(411, 118);
            fatherChickBox.Name = "fatherChickBox";
            fatherChickBox.Size = new Size(200, 30);
            fatherChickBox.TabIndex = 6;
            fatherChickBox.Visible = false;
            // 
            // FatherIdLabel
            // 
            FatherIdLabel.AutoSize = true;
            FatherIdLabel.Location = new Point(288, 121);
            FatherIdLabel.Name = "FatherIdLabel";
            FatherIdLabel.Size = new Size(77, 23);
            FatherIdLabel.TabIndex = 3;
            FatherIdLabel.Text = "Father ID:";
            FatherIdLabel.Visible = false;
            // 
            // motherIdLabel
            // 
            motherIdLabel.AutoSize = true;
            motherIdLabel.Location = new Point(288, 121);
            motherIdLabel.Name = "motherIdLabel";
            motherIdLabel.Size = new Size(80, 23);
            motherIdLabel.TabIndex = 2;
            motherIdLabel.Text = "Mother ID:";
            motherIdLabel.Visible = false;
            // 
            // chickGenderLabel
            // 
            chickGenderLabel.AutoSize = true;
            chickGenderLabel.Location = new Point(288, 76);
            chickGenderLabel.Name = "chickGenderLabel";
            chickGenderLabel.Size = new Size(63, 23);
            chickGenderLabel.TabIndex = 1;
            chickGenderLabel.Text = "Gender:";
            // 
            // dateChickLabel
            // 
            dateChickLabel.AutoSize = true;
            dateChickLabel.Location = new Point(288, 32);
            dateChickLabel.Name = "dateChickLabel";
            dateChickLabel.Size = new Size(104, 23);
            dateChickLabel.TabIndex = 0;
            dateChickLabel.Text = "Date of hatch:";
            dateChickLabel.Click += dateChickLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.eggs;
            pictureBox1.InitialImage = Properties.Resources.eggs;
            pictureBox1.Location = new Point(629, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 303);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Exit
            // 
            Exit.Cursor = Cursors.Hand;
            Exit.Image = Properties.Resources.standby;
            Exit.Location = new Point(900, 1);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 36);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 31;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // Addchick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(939, 360);
            Controls.Add(Exit);
            Controls.Add(pictureBox1);
            Controls.Add(chickGroup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Addchick";
            Text = "Edit";
            Load += Addchick_Load;
            chickGroup.ResumeLayout(false);
            chickGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox chickGroup;
        private Label chickGenderLabel;
        private Label dateChickLabel;
        private Button addChickBtn;
        private DateTimePicker dateChickBox;
        public TextBox motherChickBox;
        public TextBox fatherChickBox;
        private ComboBox chickGenderCombo;
        public Label FatherIdLabel;
        public Label motherIdLabel;
        private Label IdLabel;
        private Label genderLabel;
        private Label subLabel;
        private Label SpacieLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label bodyCLabel;
        private Label ChestCLabel;
        private Label HeadCLabel;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox1;
        private Button ChangeCage;
        private TextBox cageTxt;
        private PictureBox Exit;
    }
}