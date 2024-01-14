namespace LoginPage
{
    partial class BirdsCage
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
            chosenCageLable = new Label();
            label1 = new Label();
            materialCage1Label = new Label();
            widthCage1Label = new Label();
            heightCage1Label = new Label();
            CageEditBtn = new Button();
            heightEditBox = new TextBox();
            lengthEditBox = new TextBox();
            widthEditBox = new TextBox();
            editCageLabel = new Label();
            materialEditBox = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Exit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridBirds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            SuspendLayout();
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
            dataGridViewCellStyle1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridBirds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridBirds.ColumnHeadersHeight = 42;
            dataGridBirds.Columns.AddRange(new DataGridViewColumn[] { birdIDColumn, birdSpeciceColumn, subSpecieColumn, genderColumn, motherColumn, fatherColumn, dateColumn, cageColumn, userColumn, HeadColor, ChestColor, BodyColor });
            dataGridBirds.EnableHeadersVisualStyles = false;
            dataGridBirds.GridColor = Color.Black;
            dataGridBirds.Location = new Point(253, 54);
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
            birdSpeciceColumn.HeaderText = "Specie";
            birdSpeciceColumn.MinimumWidth = 8;
            birdSpeciceColumn.Name = "birdSpeciceColumn";
            birdSpeciceColumn.ReadOnly = true;
            // 
            // subSpecieColumn
            // 
            subSpecieColumn.HeaderText = "Sub Specie";
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
            // chosenCageLable
            // 
            chosenCageLable.AutoSize = true;
            chosenCageLable.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chosenCageLable.Location = new Point(527, 9);
            chosenCageLable.Name = "chosenCageLable";
            chosenCageLable.Size = new Size(176, 28);
            chosenCageLable.TabIndex = 7;
            chosenCageLable.Text = "Birds in chosen cage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 163);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 24;
            label1.Text = "Length cage:";
            // 
            // materialCage1Label
            // 
            materialCage1Label.AutoSize = true;
            materialCage1Label.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            materialCage1Label.Location = new Point(9, 269);
            materialCage1Label.Name = "materialCage1Label";
            materialCage1Label.Size = new Size(104, 23);
            materialCage1Label.TabIndex = 23;
            materialCage1Label.Text = "Material cage:";
            // 
            // widthCage1Label
            // 
            widthCage1Label.AutoSize = true;
            widthCage1Label.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            widthCage1Label.Location = new Point(9, 217);
            widthCage1Label.Name = "widthCage1Label";
            widthCage1Label.Size = new Size(88, 23);
            widthCage1Label.TabIndex = 22;
            widthCage1Label.Text = "Width cage:";
            // 
            // heightCage1Label
            // 
            heightCage1Label.AutoSize = true;
            heightCage1Label.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            heightCage1Label.Location = new Point(9, 111);
            heightCage1Label.Name = "heightCage1Label";
            heightCage1Label.Size = new Size(90, 23);
            heightCage1Label.TabIndex = 21;
            heightCage1Label.Text = "Height cage:";
            // 
            // CageEditBtn
            // 
            CageEditBtn.BackColor = Color.LightBlue;
            CageEditBtn.Cursor = Cursors.Hand;
            CageEditBtn.FlatAppearance.BorderSize = 0;
            CageEditBtn.FlatStyle = FlatStyle.Popup;
            CageEditBtn.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CageEditBtn.ForeColor = Color.Black;
            CageEditBtn.Location = new Point(57, 340);
            CageEditBtn.Margin = new Padding(2);
            CageEditBtn.Name = "CageEditBtn";
            CageEditBtn.Size = new Size(121, 39);
            CageEditBtn.TabIndex = 25;
            CageEditBtn.Text = "Submit";
            CageEditBtn.UseVisualStyleBackColor = false;
            CageEditBtn.Click += CageEditBtn_Click;
            // 
            // heightEditBox
            // 
            heightEditBox.Location = new Point(124, 109);
            heightEditBox.Name = "heightEditBox";
            heightEditBox.Size = new Size(100, 23);
            heightEditBox.TabIndex = 26;
            // 
            // lengthEditBox
            // 
            lengthEditBox.Location = new Point(124, 165);
            lengthEditBox.Name = "lengthEditBox";
            lengthEditBox.Size = new Size(100, 23);
            lengthEditBox.TabIndex = 27;
            // 
            // widthEditBox
            // 
            widthEditBox.Location = new Point(124, 219);
            widthEditBox.Name = "widthEditBox";
            widthEditBox.Size = new Size(100, 23);
            widthEditBox.TabIndex = 28;
            // 
            // editCageLabel
            // 
            editCageLabel.AutoSize = true;
            editCageLabel.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            editCageLabel.Location = new Point(73, 54);
            editCageLabel.Name = "editCageLabel";
            editCageLabel.Size = new Size(105, 33);
            editCageLabel.TabIndex = 30;
            editCageLabel.Text = "Edit cage";
            // 
            // materialEditBox
            // 
            materialEditBox.FormattingEnabled = true;
            materialEditBox.Items.AddRange(new object[] { "wood", "plastic", "iron" });
            materialEditBox.Location = new Point(124, 271);
            materialEditBox.Margin = new Padding(2);
            materialEditBox.Name = "materialEditBox";
            materialEditBox.Size = new Size(100, 23);
            materialEditBox.TabIndex = 31;
            // 
            // Exit
            // 
            Exit.Cursor = Cursors.Hand;
            Exit.Image = Properties.Resources.standby;
            Exit.Location = new Point(1265, 1);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 36);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 32;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // BirdsCage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1305, 462);
            Controls.Add(Exit);
            Controls.Add(materialEditBox);
            Controls.Add(editCageLabel);
            Controls.Add(widthEditBox);
            Controls.Add(lengthEditBox);
            Controls.Add(heightEditBox);
            Controls.Add(CageEditBtn);
            Controls.Add(label1);
            Controls.Add(materialCage1Label);
            Controls.Add(widthCage1Label);
            Controls.Add(heightCage1Label);
            Controls.Add(chosenCageLable);
            Controls.Add(dataGridBirds);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BirdsCage";
            Text = "BirdsCage";
            Load += BirdsCage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridBirds).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridBirds;
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
        private Label chosenCageLable;
        private Label label1;
        private Label materialCage1Label;
        private Label widthCage1Label;
        private Label heightCage1Label;
        private Button CageEditBtn;
        private TextBox heightEditBox;
        private TextBox lengthEditBox;
        private TextBox widthEditBox;
        private Label editCageLabel;
        private ComboBox materialEditBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox Exit;
    }
}