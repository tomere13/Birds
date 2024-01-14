namespace LoginPage
{
    partial class RegForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegNameVal = new TextBox();
            RegPassVal = new TextBox();
            regNameLabel = new Label();
            regPassLabel = new Label();
            alert1 = new Label();
            alert2 = new Label();
            pictureBox2 = new PictureBox();
            BackBtn = new Button();
            pictureBox1 = new PictureBox();
            Exit = new PictureBox();
            idNumberBox = new TextBox();
            idNumberLabel = new Label();
            alert3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            SuspendLayout();
            // 
            // RegNameVal
            // 
            RegNameVal.BackColor = Color.LightBlue;
            RegNameVal.BorderStyle = BorderStyle.FixedSingle;
            RegNameVal.Location = new Point(293, 163);
            RegNameVal.Name = "RegNameVal";
            RegNameVal.Size = new Size(114, 25);
            RegNameVal.TabIndex = 1;
            RegNameVal.TextChanged += RegNameVal_TextChanged;
            // 
            // RegPassVal
            // 
            RegPassVal.BackColor = Color.LightBlue;
            RegPassVal.BorderStyle = BorderStyle.FixedSingle;
            RegPassVal.Location = new Point(293, 194);
            RegPassVal.Name = "RegPassVal";
            RegPassVal.Size = new Size(114, 25);
            RegPassVal.TabIndex = 2;
            RegPassVal.TextChanged += RegPassVal_TextChanged;
            // 
            // regNameLabel
            // 
            regNameLabel.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            regNameLabel.Location = new Point(157, 162);
            regNameLabel.Name = "regNameLabel";
            regNameLabel.Size = new Size(114, 26);
            regNameLabel.TabIndex = 4;
            regNameLabel.Text = "Username:";
            regNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // regPassLabel
            // 
            regPassLabel.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            regPassLabel.Location = new Point(157, 194);
            regPassLabel.Name = "regPassLabel";
            regPassLabel.Size = new Size(114, 26);
            regPassLabel.TabIndex = 4;
            regPassLabel.Text = "Password:";
            regPassLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // alert1
            // 
            alert1.AutoSize = true;
            alert1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            alert1.ForeColor = Color.Red;
            alert1.Location = new Point(33, 258);
            alert1.Name = "alert1";
            alert1.Size = new Size(521, 28);
            alert1.TabIndex = 6;
            alert1.Text = "User name need to be between 6-8 chars and at most 2 digits.\r\n";
            alert1.Visible = false;
            alert1.Click += alert1_Click;
            // 
            // alert2
            // 
            alert2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            alert2.ForeColor = Color.Red;
            alert2.Location = new Point(70, 259);
            alert2.Name = "alert2";
            alert2.Size = new Size(433, 67);
            alert2.TabIndex = 7;
            alert2.Text = "The password should contain 8-10 characters and at least one number, letter and special character.\r\n";
            alert2.Visible = false;
            alert2.Click += alert2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.signup;
            pictureBox2.Location = new Point(167, 310);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 114);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.LightBlue;
            BackBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.Black;
            BackBtn.Location = new Point(440, 366);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(131, 35);
            BackBtn.TabIndex = 10;
            BackBtn.Text = "Back to Login";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.register;
            pictureBox1.Location = new Point(10, -126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 413);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Exit
            // 
            Exit.Cursor = Cursors.Hand;
            Exit.Image = Properties.Resources.standby;
            Exit.Location = new Point(535, 5);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 36);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 12;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // idNumberBox
            // 
            idNumberBox.BackColor = Color.LightBlue;
            idNumberBox.BorderStyle = BorderStyle.FixedSingle;
            idNumberBox.Location = new Point(293, 225);
            idNumberBox.Name = "idNumberBox";
            idNumberBox.Size = new Size(114, 25);
            idNumberBox.TabIndex = 13;
            // 
            // idNumberLabel
            // 
            idNumberLabel.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            idNumberLabel.Location = new Point(157, 225);
            idNumberLabel.Name = "idNumberLabel";
            idNumberLabel.Size = new Size(114, 26);
            idNumberLabel.TabIndex = 14;
            idNumberLabel.Text = "Id number:";
            idNumberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // alert3
            // 
            alert3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            alert3.ForeColor = Color.Red;
            alert3.Location = new Point(94, 260);
            alert3.Name = "alert3";
            alert3.Size = new Size(433, 67);
            alert3.TabIndex = 15;
            alert3.Text = "Id Numer is invalid, enter 8 to 9 digits (only numbers and positive)";
            alert3.Visible = false;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(578, 408);
            Controls.Add(alert3);
            Controls.Add(idNumberLabel);
            Controls.Add(idNumberBox);
            Controls.Add(Exit);
            Controls.Add(BackBtn);
            Controls.Add(pictureBox2);
            Controls.Add(alert2);
            Controls.Add(alert1);
            Controls.Add(regPassLabel);
            Controls.Add(regNameLabel);
            Controls.Add(RegPassVal);
            Controls.Add(RegNameVal);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox RegNameVal;
        private TextBox RegPassVal;
        internal Label regNameLabel;
        internal Label regPassLabel;
        private Label alert1;
        private Label alert2;
        private PictureBox pictureBox2;
        private Button BackBtn;
        private PictureBox pictureBox1;
        private PictureBox Exit;
        private TextBox idNumberBox;
        internal Label idNumberLabel;
        private Label alert3;
    }
}