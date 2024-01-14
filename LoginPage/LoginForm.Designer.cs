namespace WinFormsApp1
{
    partial class LoginForm
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
            usernameBox = new TextBox();
            userNameLable = new Label();
            passwordLable = new Label();
            passwordBox = new TextBox();
            loginBtn = new Button();
            invalidAuth = new Label();
            regBtn = new Button();
            pictureBox1 = new PictureBox();
            Exit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.LightBlue;
            usernameBox.BorderStyle = BorderStyle.FixedSingle;
            usernameBox.Location = new Point(245, 186);
            usernameBox.Margin = new Padding(2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(159, 25);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += usernameBox_TextChanged_1;
            // 
            // userNameLable
            // 
            userNameLable.AutoSize = true;
            userNameLable.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLable.Location = new Point(144, 186);
            userNameLable.Margin = new Padding(2, 0, 2, 0);
            userNameLable.Name = "userNameLable";
            userNameLable.Size = new Size(97, 28);
            userNameLable.TabIndex = 1;
            userNameLable.Text = "User name";
            // 
            // passwordLable
            // 
            passwordLable.AutoSize = true;
            passwordLable.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLable.Location = new Point(144, 219);
            passwordLable.Margin = new Padding(2, 0, 2, 0);
            passwordLable.Name = "passwordLable";
            passwordLable.Size = new Size(88, 28);
            passwordLable.TabIndex = 2;
            passwordLable.Text = "Password";
            passwordLable.Click += Password_Click;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.LightBlue;
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Location = new Point(245, 219);
            passwordBox.Margin = new Padding(2);
            passwordBox.MaxLength = 14;
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(159, 25);
            passwordBox.TabIndex = 3;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.LightBlue;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.Black;
            loginBtn.Location = new Point(214, 285);
            loginBtn.Margin = new Padding(2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(103, 41);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // invalidAuth
            // 
            invalidAuth.AutoSize = true;
            invalidAuth.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            invalidAuth.ForeColor = Color.Red;
            invalidAuth.Location = new Point(77, 255);
            invalidAuth.Margin = new Padding(2, 0, 2, 0);
            invalidAuth.Name = "invalidAuth";
            invalidAuth.Size = new Size(401, 28);
            invalidAuth.TabIndex = 5;
            invalidAuth.Text = "Invalid user name or password. Please try again.";
            invalidAuth.Visible = false;
            invalidAuth.Click += label1_Click;
            // 
            // regBtn
            // 
            regBtn.BackColor = Color.LightBlue;
            regBtn.FlatStyle = FlatStyle.Flat;
            regBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            regBtn.ForeColor = Color.Black;
            regBtn.Location = new Point(214, 340);
            regBtn.Margin = new Padding(2);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(103, 41);
            regBtn.TabIndex = 7;
            regBtn.Text = "Register";
            regBtn.UseVisualStyleBackColor = false;
            regBtn.Click += regPage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LoginPage.Properties.Resources.newLogin;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(-23, -116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(578, 408);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Exit
            // 
            Exit.Cursor = Cursors.Hand;
            Exit.Image = LoginPage.Properties.Resources.standby;
            Exit.Location = new Point(500, 1);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 36);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 9;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(542, 414);
            Controls.Add(Exit);
            Controls.Add(regBtn);
            Controls.Add(invalidAuth);
            Controls.Add(loginBtn);
            Controls.Add(passwordBox);
            Controls.Add(passwordLable);
            Controls.Add(userNameLable);
            Controls.Add(usernameBox);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameBox;
        private Label userNameLable;
        private Label passwordLable;
        private TextBox passwordBox;
        private Button loginBtn;
        private Label invalidAuth;
        private Button regBtn;
        private PictureBox pictureBox1;
        private PictureBox Exit;
    }
}