namespace LoginPage
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            AddBbtn = new Button();
            Addcbtn = new Button();
            SearchBbtn = new Button();
            SearchCbtn = new Button();
            pictureBox2 = new PictureBox();
            Exit = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            plotView = new OxyPlot.WindowsForms.PlotView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // AddBbtn
            // 
            AddBbtn.BackColor = Color.Transparent;
            AddBbtn.Cursor = Cursors.Hand;
            AddBbtn.FlatAppearance.BorderSize = 0;
            AddBbtn.FlatStyle = FlatStyle.Flat;
            AddBbtn.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBbtn.ForeColor = Color.Black;
            AddBbtn.Location = new Point(58, 255);
            AddBbtn.Margin = new Padding(2);
            AddBbtn.Name = "AddBbtn";
            AddBbtn.Size = new Size(95, 41);
            AddBbtn.TabIndex = 1;
            AddBbtn.Text = "Add Bird";
            AddBbtn.TextAlign = ContentAlignment.MiddleLeft;
            AddBbtn.UseVisualStyleBackColor = false;
            AddBbtn.Click += AddBbtn_Click;
            // 
            // Addcbtn
            // 
            Addcbtn.BackColor = Color.Transparent;
            Addcbtn.Cursor = Cursors.Hand;
            Addcbtn.FlatAppearance.BorderSize = 0;
            Addcbtn.FlatStyle = FlatStyle.Flat;
            Addcbtn.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Addcbtn.ForeColor = Color.Black;
            Addcbtn.Location = new Point(58, 208);
            Addcbtn.Margin = new Padding(2);
            Addcbtn.Name = "Addcbtn";
            Addcbtn.Size = new Size(95, 39);
            Addcbtn.TabIndex = 2;
            Addcbtn.Text = "Add Cage";
            Addcbtn.TextAlign = ContentAlignment.MiddleLeft;
            Addcbtn.UseVisualStyleBackColor = false;
            Addcbtn.Click += Addcbtn_Click;
            // 
            // SearchBbtn
            // 
            SearchBbtn.BackColor = Color.Transparent;
            SearchBbtn.Cursor = Cursors.Hand;
            SearchBbtn.FlatAppearance.BorderSize = 0;
            SearchBbtn.FlatStyle = FlatStyle.Flat;
            SearchBbtn.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBbtn.ForeColor = Color.Black;
            SearchBbtn.Location = new Point(57, 299);
            SearchBbtn.Margin = new Padding(2);
            SearchBbtn.Name = "SearchBbtn";
            SearchBbtn.Size = new Size(107, 39);
            SearchBbtn.TabIndex = 3;
            SearchBbtn.Text = "Search Bird";
            SearchBbtn.TextAlign = ContentAlignment.MiddleLeft;
            SearchBbtn.UseVisualStyleBackColor = false;
            SearchBbtn.Click += SearchBbtn_Click;
            // 
            // SearchCbtn
            // 
            SearchCbtn.BackColor = Color.Transparent;
            SearchCbtn.Cursor = Cursors.Hand;
            SearchCbtn.FlatAppearance.BorderSize = 0;
            SearchCbtn.FlatStyle = FlatStyle.Flat;
            SearchCbtn.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SearchCbtn.ForeColor = Color.Black;
            SearchCbtn.Location = new Point(59, 342);
            SearchCbtn.Margin = new Padding(2);
            SearchCbtn.Name = "SearchCbtn";
            SearchCbtn.Size = new Size(107, 39);
            SearchCbtn.TabIndex = 4;
            SearchCbtn.Text = "Search Cage";
            SearchCbtn.TextAlign = ContentAlignment.MiddleLeft;
            SearchCbtn.UseVisualStyleBackColor = false;
            SearchCbtn.Click += SearchCbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(169, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(445, 453);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Exit
            // 
            Exit.Cursor = Cursors.Hand;
            Exit.Image = Properties.Resources.standby;
            Exit.Location = new Point(574, 1);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 36);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 8;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Home;
            pictureBox3.InitialImage = Properties.Resources.Home;
            pictureBox3.Location = new Point(-1, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(167, 197);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(172, 53);
            label1.Name = "label1";
            label1.Size = new Size(431, 36);
            label1.TabIndex = 10;
            label1.Text = "Welcome to the Bird Home Program ! ";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe Print", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(172, 89);
            label2.Name = "label2";
            label2.Size = new Size(442, 128);
            label2.TabIndex = 11;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.search;
            pictureBox4.Location = new Point(8, 344);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.search;
            pictureBox5.Location = new Point(8, 299);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.add3;
            pictureBox6.Location = new Point(8, 255);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(42, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.add3;
            pictureBox7.Location = new Point(8, 208);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(42, 39);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // plotView
            // 
            plotView.BackColor = Color.White;
            plotView.Location = new Point(249, 208);
            plotView.Name = "plotView";
            plotView.PanCursor = Cursors.Hand;
            plotView.Size = new Size(287, 276);
            plotView.TabIndex = 16;
            plotView.Text = "plotView";
            plotView.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView.ZoomVerticalCursor = Cursors.SizeNS;
            plotView.Click += plotView1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 397);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 17;
            label3.Text = "Number of birds:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 436);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 18;
            label4.Text = "Number of cages:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(124, 397);
            label5.Name = "label5";
            label5.Size = new Size(42, 23);
            label5.TabIndex = 19;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(124, 436);
            label6.Name = "label6";
            label6.Size = new Size(42, 23);
            label6.TabIndex = 20;
            label6.Text = "label6";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(614, 496);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(plotView);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(Exit);
            Controls.Add(pictureBox2);
            Controls.Add(Addcbtn);
            Controls.Add(SearchCbtn);
            Controls.Add(AddBbtn);
            Controls.Add(SearchBbtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            Text = "Main Page";
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddBbtn;
        private Button Addcbtn;
        private Button SearchBbtn;
        private Button SearchCbtn;
        private PictureBox pictureBox2;
        private PictureBox Exit;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private OxyPlot.WindowsForms.PlotView plotView;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}