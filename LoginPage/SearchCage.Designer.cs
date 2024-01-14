namespace LoginPage
{
    partial class SearchCage
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
            dataGridCages = new DataGridView();
            cageIDColumn = new DataGridViewTextBoxColumn();
            lengthColumn = new DataGridViewTextBoxColumn();
            widthColumn = new DataGridViewTextBoxColumn();
            heightColumn = new DataGridViewTextBoxColumn();
            materialColumn = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            searchGroup = new GroupBox();
            editCageLabels = new Label();
            Exit = new PictureBox();
            pictureBox1 = new PictureBox();
            searchLabel = new Label();
            cageSearchMenuBtn = new Button();
            idTextBox = new TextBox();
            materialListBox = new ComboBox();
            searchBtn = new Button();
            cageSearchBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridCages).BeginInit();
            searchGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridCages
            // 
            dataGridCages.AllowUserToAddRows = false;
            dataGridCages.AllowUserToDeleteRows = false;
            dataGridCages.AllowUserToResizeRows = false;
            dataGridCages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCages.BackgroundColor = Color.LightBlue;
            dataGridCages.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridCages.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridCages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCages.Columns.AddRange(new DataGridViewColumn[] { cageIDColumn, lengthColumn, widthColumn, heightColumn, materialColumn, UserId });
            dataGridCages.EnableHeadersVisualStyles = false;
            dataGridCages.GridColor = Color.Black;
            dataGridCages.Location = new Point(224, 51);
            dataGridCages.MultiSelect = false;
            dataGridCages.Name = "dataGridCages";
            dataGridCages.ReadOnly = true;
            dataGridCages.RowHeadersVisible = false;
            dataGridCages.RowTemplate.Height = 30;
            dataGridCages.ScrollBars = ScrollBars.Vertical;
            dataGridCages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCages.Size = new Size(543, 378);
            dataGridCages.TabIndex = 5;
            dataGridCages.TabStop = false;
            dataGridCages.CellContentClick += dataGridCages_CellContentClick;
            dataGridCages.CellMouseDoubleClick += dataGridCages_CellMouseDoubleClick;
            // 
            // cageIDColumn
            // 
            cageIDColumn.HeaderText = "Cage ID";
            cageIDColumn.Name = "cageIDColumn";
            cageIDColumn.ReadOnly = true;
            // 
            // lengthColumn
            // 
            lengthColumn.HeaderText = "Length";
            lengthColumn.Name = "lengthColumn";
            lengthColumn.ReadOnly = true;
            // 
            // widthColumn
            // 
            widthColumn.HeaderText = "Width";
            widthColumn.Name = "widthColumn";
            widthColumn.ReadOnly = true;
            // 
            // heightColumn
            // 
            heightColumn.HeaderText = "Height";
            heightColumn.Name = "heightColumn";
            heightColumn.ReadOnly = true;
            // 
            // materialColumn
            // 
            materialColumn.HeaderText = "Material";
            materialColumn.Name = "materialColumn";
            materialColumn.ReadOnly = true;
            // 
            // UserId
            // 
            UserId.HeaderText = "User ID";
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            // 
            // searchGroup
            // 
            searchGroup.BackgroundImageLayout = ImageLayout.Zoom;
            searchGroup.Controls.Add(editCageLabels);
            searchGroup.Controls.Add(Exit);
            searchGroup.Controls.Add(pictureBox1);
            searchGroup.Controls.Add(searchLabel);
            searchGroup.Controls.Add(cageSearchMenuBtn);
            searchGroup.Controls.Add(idTextBox);
            searchGroup.Controls.Add(materialListBox);
            searchGroup.Controls.Add(searchBtn);
            searchGroup.Controls.Add(cageSearchBox);
            searchGroup.Controls.Add(dataGridCages);
            searchGroup.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchGroup.ForeColor = Color.Black;
            searchGroup.Location = new Point(12, 0);
            searchGroup.Name = "searchGroup";
            searchGroup.Size = new Size(779, 435);
            searchGroup.TabIndex = 2;
            searchGroup.TabStop = false;
            searchGroup.Text = "Search Cage";
            // 
            // editCageLabels
            // 
            editCageLabels.AutoSize = true;
            editCageLabels.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            editCageLabels.ForeColor = Color.Black;
            editCageLabels.Location = new Point(303, 22);
            editCageLabels.Name = "editCageLabels";
            editCageLabels.Size = new Size(364, 26);
            editCageLabels.TabIndex = 9;
            editCageLabels.Text = "Double click edit cage and see the birds inside.\r\n";
            // 
            // Exit
            // 
            Exit.Cursor = Cursors.Hand;
            Exit.Image = Properties.Resources.standby;
            Exit.Location = new Point(739, 2);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 36);
            Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Exit.TabIndex = 34;
            Exit.TabStop = false;
            Exit.Click += Exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(27, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(49, 158);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(113, 23);
            searchLabel.TabIndex = 3;
            searchLabel.Text = "Choose to filter:";
            // 
            // cageSearchMenuBtn
            // 
            cageSearchMenuBtn.BackColor = Color.LightBlue;
            cageSearchMenuBtn.FlatAppearance.BorderSize = 0;
            cageSearchMenuBtn.FlatStyle = FlatStyle.Popup;
            cageSearchMenuBtn.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cageSearchMenuBtn.ForeColor = Color.Black;
            cageSearchMenuBtn.Location = new Point(45, 328);
            cageSearchMenuBtn.Name = "cageSearchMenuBtn";
            cageSearchMenuBtn.Size = new Size(121, 30);
            cageSearchMenuBtn.TabIndex = 3;
            cageSearchMenuBtn.Text = "Main menu";
            cageSearchMenuBtn.UseVisualStyleBackColor = false;
            cageSearchMenuBtn.Click += cageSearchMenuBtn_Click;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(45, 237);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(121, 30);
            idTextBox.TabIndex = 4;
            idTextBox.Visible = false;
            // 
            // materialListBox
            // 
            materialListBox.FormattingEnabled = true;
            materialListBox.Items.AddRange(new object[] { "wood", "plastic", "iron" });
            materialListBox.Location = new Point(45, 236);
            materialListBox.Name = "materialListBox";
            materialListBox.Size = new Size(121, 31);
            materialListBox.TabIndex = 2;
            materialListBox.Visible = false;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.LightBlue;
            searchBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatStyle = FlatStyle.Popup;
            searchBtn.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchBtn.ForeColor = Color.Black;
            searchBtn.Location = new Point(45, 283);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(121, 30);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // cageSearchBox
            // 
            cageSearchBox.FormattingEnabled = true;
            cageSearchBox.Items.AddRange(new object[] { "Cage ID", "Material" });
            cageSearchBox.Location = new Point(45, 189);
            cageSearchBox.Name = "cageSearchBox";
            cageSearchBox.Size = new Size(121, 31);
            cageSearchBox.TabIndex = 0;
            cageSearchBox.SelectedIndexChanged += cageSearchBox_SelectedIndexChanged;
            // 
            // SearchCage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(791, 447);
            Controls.Add(searchGroup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchCage";
            Text = "SearchCage";
            ((System.ComponentModel.ISupportInitialize)dataGridCages).EndInit();
            searchGroup.ResumeLayout(false);
            searchGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridCages;
        private GroupBox searchGroup;
        private TextBox idTextBox;
        private ComboBox materialListBox;
        private Button searchBtn;
        private ComboBox cageSearchBox;
        private Button cageSearchMenuBtn;
        private Label searchLabel;
        private DataGridViewTextBoxColumn cageIDColumn;
        private DataGridViewTextBoxColumn lengthColumn;
        private DataGridViewTextBoxColumn widthColumn;
        private DataGridViewTextBoxColumn heightColumn;
        private DataGridViewTextBoxColumn materialColumn;
        private DataGridViewTextBoxColumn UserId;
        private PictureBox pictureBox1;
        private PictureBox Exit;
        private Label editCageLabels;
    }
}