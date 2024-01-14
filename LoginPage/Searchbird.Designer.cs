namespace LoginPage
{
    partial class Searchbird
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            searchGroup = new GroupBox();
            Exit = new PictureBox();
            pictureBox1 = new PictureBox();
            searchLabel = new Label();
            addChickLabels = new Label();
            birdMainMenuBtn = new Button();
            idTextBox = new TextBox();
            datePicker = new DateTimePicker();
            SpecieBox = new ComboBox();
            searchBtn = new Button();
            birdSearchBox = new ComboBox();
            dataGridBirds = new DataGridView();
            birdIDColumn = new DataGridViewTextBoxColumn();
            birdSpeciceColumn = new DataGridViewTextBoxColumn();
            subSpecieColumn = new DataGridViewTextBoxColumn();
            genderColumn = new DataGridViewTextBoxColumn();
            motherColumn = new DataGridViewTextBoxColumn();
            fatherColumn = new DataGridViewTextBoxColumn();
            dateColumn = new DataGridViewTextBoxColumn();
            cageColumn = new DataGridViewTextBoxColumn();
            userColumn = new DataGridViewTextBoxColumn();
            HeadColor = new DataGridViewTextBoxColumn();
            ChestColor = new DataGridViewTextBoxColumn();
            BodyColor = new DataGridViewTextBoxColumn();
            searchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBirds).BeginInit();
            SuspendLayout();
            // 
            // searchGroup
            // 
            searchGroup.BackColor = Color.LightBlue;
            searchGroup.Controls.Add(Exit);
            searchGroup.Controls.Add(pictureBox1);
            searchGroup.Controls.Add(searchLabel);
            searchGroup.Controls.Add(addChickLabels);
            searchGroup.Controls.Add(birdMainMenuBtn);
            searchGroup.Controls.Add(idTextBox);
            searchGroup.Controls.Add(datePicker);
            searchGroup.Controls.Add(SpecieBox);
            searchGroup.Controls.Add(searchBtn);
            searchGroup.Controls.Add(birdSearchBox);
            searchGroup.Controls.Add(dataGridBirds);
            searchGroup.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            searchGroup.ForeColor = Color.Black;
            searchGroup.Location = new Point(12, -1);
            searchGroup.Name = "searchGroup";
            searchGroup.Size = new Size(1258, 449);
            searchGroup.TabIndex = 1;
            searchGroup.TabStop = false;
            searchGroup.Text = "Search bird";
            searchGroup.Enter += searchGroup_Enter;
            // 
            // Exit
            // 
            Exit.Cursor = Cursors.Hand;
            Exit.Image = Properties.Resources.standby;
            Exit.Location = new Point(1217, 2);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 36);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 33;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(32, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchLabel.ForeColor = Color.Black;
            searchLabel.Location = new Point(51, 181);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(113, 23);
            searchLabel.TabIndex = 9;
            searchLabel.Text = "Choose to filter:";
            // 
            // addChickLabels
            // 
            addChickLabels.AutoSize = true;
            addChickLabels.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addChickLabels.ForeColor = Color.Black;
            addChickLabels.Location = new Point(523, 17);
            addChickLabels.Name = "addChickLabels";
            addChickLabels.Size = new Size(390, 26);
            addChickLabels.TabIndex = 8;
            addChickLabels.Text = "Double click to add chick to the bird or edit cage.";
            addChickLabels.Click += addChickLabels_Click;
            // 
            // birdMainMenuBtn
            // 
            birdMainMenuBtn.BackColor = Color.LightBlue;
            birdMainMenuBtn.Cursor = Cursors.Hand;
            birdMainMenuBtn.FlatAppearance.BorderSize = 0;
            birdMainMenuBtn.FlatStyle = FlatStyle.Popup;
            birdMainMenuBtn.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            birdMainMenuBtn.ForeColor = Color.Black;
            birdMainMenuBtn.Location = new Point(54, 308);
            birdMainMenuBtn.Name = "birdMainMenuBtn";
            birdMainMenuBtn.Size = new Size(111, 27);
            birdMainMenuBtn.TabIndex = 2;
            birdMainMenuBtn.Text = "Main menu";
            birdMainMenuBtn.UseVisualStyleBackColor = false;
            birdMainMenuBtn.Click += birdMainMenuBtn_Click;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(45, 240);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(126, 29);
            idTextBox.TabIndex = 4;
            idTextBox.Visible = false;
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(5, 243);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 22);
            datePicker.TabIndex = 3;
            datePicker.Visible = false;
            datePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // SpecieBox
            // 
            SpecieBox.FormattingEnabled = true;
            SpecieBox.Location = new Point(45, 240);
            SpecieBox.Name = "SpecieBox";
            SpecieBox.Size = new Size(126, 29);
            SpecieBox.TabIndex = 2;
            SpecieBox.Visible = false;
            SpecieBox.SelectedIndexChanged += SpecieBox_SelectedIndexChanged;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.LightBlue;
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Popup;
            searchBtn.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchBtn.ForeColor = Color.Black;
            searchBtn.Location = new Point(53, 275);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(111, 27);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // birdSearchBox
            // 
            birdSearchBox.FormattingEnabled = true;
            birdSearchBox.Items.AddRange(new object[] { "Bird ID", "Species", "Hatch date", "Gender" });
            birdSearchBox.Location = new Point(45, 207);
            birdSearchBox.Name = "birdSearchBox";
            birdSearchBox.Size = new Size(126, 29);
            birdSearchBox.TabIndex = 0;
            birdSearchBox.SelectedIndexChanged += searchBox_SelectedIndexChanged;
            // 
            // dataGridBirds
            // 
            dataGridBirds.AllowUserToAddRows = false;
            dataGridBirds.AllowUserToDeleteRows = false;
            dataGridBirds.AllowUserToResizeRows = false;
            dataGridBirds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBirds.BackgroundColor = Color.LightBlue;
            dataGridBirds.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridBirds.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridBirds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridBirds.ColumnHeadersHeight = 42;
            dataGridBirds.Columns.AddRange(new DataGridViewColumn[] { birdIDColumn, birdSpeciceColumn, subSpecieColumn, genderColumn, motherColumn, fatherColumn, dateColumn, cageColumn, userColumn, HeadColor, ChestColor, BodyColor });
            dataGridBirds.EnableHeadersVisualStyles = false;
            dataGridBirds.GridColor = Color.Black;
            dataGridBirds.Location = new Point(211, 46);
            dataGridBirds.MultiSelect = false;
            dataGridBirds.Name = "dataGridBirds";
            dataGridBirds.ReadOnly = true;
            dataGridBirds.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridBirds.RowHeadersVisible = false;
            dataGridBirds.RowHeadersWidth = 62;
            dataGridBirds.RowTemplate.Height = 25;
            dataGridBirds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridBirds.Size = new Size(1040, 384);
            dataGridBirds.TabIndex = 5;
            dataGridBirds.TabStop = false;
            dataGridBirds.CellContentClick += dataGridBirds_CellContentClick;
            dataGridBirds.CellDoubleClick += dataGridBirds_CellDoubleClick;
            // 
            // birdIDColumn
            // 
            birdIDColumn.FillWeight = 80F;
            birdIDColumn.HeaderText = "Bird ID";
            birdIDColumn.MinimumWidth = 8;
            birdIDColumn.Name = "birdIDColumn";
            birdIDColumn.ReadOnly = true;
            // 
            // birdSpeciceColumn
            // 
            birdSpeciceColumn.HeaderText = "Species";
            birdSpeciceColumn.MinimumWidth = 8;
            birdSpeciceColumn.Name = "birdSpeciceColumn";
            birdSpeciceColumn.ReadOnly = true;
            // 
            // subSpecieColumn
            // 
            subSpecieColumn.HeaderText = "Sub Species";
            subSpecieColumn.MinimumWidth = 8;
            subSpecieColumn.Name = "subSpecieColumn";
            subSpecieColumn.ReadOnly = true;
            // 
            // genderColumn
            // 
            genderColumn.HeaderText = "Gender";
            genderColumn.MinimumWidth = 8;
            genderColumn.Name = "genderColumn";
            genderColumn.ReadOnly = true;
            // 
            // motherColumn
            // 
            motherColumn.HeaderText = "Mother";
            motherColumn.MinimumWidth = 8;
            motherColumn.Name = "motherColumn";
            motherColumn.ReadOnly = true;
            // 
            // fatherColumn
            // 
            fatherColumn.HeaderText = "Father";
            fatherColumn.MinimumWidth = 8;
            fatherColumn.Name = "fatherColumn";
            fatherColumn.ReadOnly = true;
            // 
            // dateColumn
            // 
            dateColumn.HeaderText = "Date";
            dateColumn.MinimumWidth = 8;
            dateColumn.Name = "dateColumn";
            dateColumn.ReadOnly = true;
            // 
            // cageColumn
            // 
            cageColumn.HeaderText = "Cage ID";
            cageColumn.MinimumWidth = 8;
            cageColumn.Name = "cageColumn";
            cageColumn.ReadOnly = true;
            // 
            // userColumn
            // 
            userColumn.HeaderText = "User ID";
            userColumn.MinimumWidth = 8;
            userColumn.Name = "userColumn";
            userColumn.ReadOnly = true;
            // 
            // HeadColor
            // 
            HeadColor.HeaderText = "Head Color";
            HeadColor.MinimumWidth = 8;
            HeadColor.Name = "HeadColor";
            HeadColor.ReadOnly = true;
            // 
            // ChestColor
            // 
            ChestColor.HeaderText = "Chest Color";
            ChestColor.MinimumWidth = 8;
            ChestColor.Name = "ChestColor";
            ChestColor.ReadOnly = true;
            // 
            // BodyColor
            // 
            BodyColor.HeaderText = "Body Color";
            BodyColor.MinimumWidth = 8;
            BodyColor.Name = "BodyColor";
            BodyColor.ReadOnly = true;
            // 
            // Searchbird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1269, 450);
            Controls.Add(searchGroup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Searchbird";
            Text = "Searchbird";
            Load += Searchbird_Load;
            searchGroup.ResumeLayout(false);
            searchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBirds).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox searchGroup;
        private ComboBox birdSearchBox;
        private Button searchBtn;
        private ComboBox SpecieBox;
        private DateTimePicker datePicker;
        private TextBox idTextBox;
        private DataGridView dataGridBirds;
        private Button birdMainMenuBtn;
        private Label addChickLabels;
        private Label searchLabel;
        private DataGridViewTextBoxColumn birdIDColumn;
        private DataGridViewTextBoxColumn birdSpeciceColumn;
        private DataGridViewTextBoxColumn subSpecieColumn;
        private DataGridViewTextBoxColumn genderColumn;
        private DataGridViewTextBoxColumn motherColumn;
        private DataGridViewTextBoxColumn fatherColumn;
        private DataGridViewTextBoxColumn dateColumn;
        private DataGridViewTextBoxColumn cageColumn;
        private DataGridViewTextBoxColumn userColumn;
        private DataGridViewTextBoxColumn HeadColor;
        private DataGridViewTextBoxColumn ChestColor;
        private DataGridViewTextBoxColumn BodyColor;
        private PictureBox pictureBox1;
        private PictureBox Exit;
    }
}