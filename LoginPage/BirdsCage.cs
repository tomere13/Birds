using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Excel = Microsoft.Office.Interop.Excel;

namespace LoginPage
{
    public partial class BirdsCage : Form
    {
        public string cageID;
        public string lengthCage;
        public string widthCage;
        public string heigthCage;
        public string materialCage;

        public BirdsCage()
        {
            InitializeComponent();


        }


        private void dataGridBirds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void BirdsCage_Load(object sender, EventArgs e)
        {
            string fileName = "birds.xlsx";
            string projectDirectory = System.IO.Path.GetDirectoryName(Application.StartupPath);
            string dataFolder = Path.Combine(projectDirectory, "Data");
            string filePath = System.IO.Path.Combine(dataFolder, fileName);
            bool fileExists = File.Exists(filePath);

            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            application.DisplayAlerts = false;
            workbook = application.Workbooks.Open(filePath);
            worksheet = workbook.Sheets[2];

            int lastRow = worksheet.UsedRange.Rows.Count + 1;
            int rowIndex = 0;
            int n = 0;

            dataGridBirds.Rows.Clear();
            heightEditBox.Text = heigthCage;
            widthEditBox.Text = widthCage;
            lengthEditBox.Text = lengthCage;
            materialEditBox.Text = materialCage;

            for (int i = 2; i <= lastRow; i++)
            { // Start from 2 to skip the header row
                try
                {

                    Excel.Range birdIDCell = worksheet.Cells[i, 1];
                    Excel.Range speciesCell = worksheet.Cells[i, 2];
                    Excel.Range subSpeciesCell = worksheet.Cells[i, 3];
                    Excel.Range genderCell = worksheet.Cells[i, 4];
                    Excel.Range motherCell = worksheet.Cells[i, 5];
                    Excel.Range fatherCell = worksheet.Cells[i, 6];
                    Excel.Range dateCell = worksheet.Cells[i, 7];
                    Excel.Range cageIDCell = worksheet.Cells[i, 8];
                    Excel.Range userIDCell = worksheet.Cells[i, 9];
                    Excel.Range headcell = worksheet.Cells[i, 10];
                    Excel.Range chestcell = worksheet.Cells[i, 11];
                    Excel.Range bodycell = worksheet.Cells[i, 12];

                    {


                        if (cageIDCell.Value == cageID)
                        {
                            rowIndex = dataGridBirds.Rows.Add();
                            dataGridBirds.Rows[rowIndex].Cells[0].Value = birdIDCell.Value;
                            dataGridBirds.Rows[rowIndex].Cells[1].Value = speciesCell.Value;
                            dataGridBirds.Rows[rowIndex].Cells[2].Value = subSpeciesCell.Value;
                            dataGridBirds.Rows[rowIndex].Cells[3].Value = genderCell.Value;
                            dataGridBirds.Rows[rowIndex].Cells[4].Value = motherCell.Value;
                            dataGridBirds.Rows[rowIndex].Cells[5].Value = fatherCell.Value;
                            dataGridBirds.Rows[rowIndex].Cells[6].Value = dateCell.Value;
                            dataGridBirds.Rows[rowIndex].Cells[7].Value = cageIDCell.Value;
                            dataGridBirds.Rows[rowIndex].Cells[8].Value = userIDCell.Value;
                            dataGridBirds.Rows[rowIndex].Cells[9].Value = headcell.Value;
                            dataGridBirds.Rows[rowIndex].Cells[10].Value = chestcell.Value;
                            dataGridBirds.Rows[rowIndex].Cells[11].Value = bodycell.Value;



                        }




                    }




                }
                catch
                {
                    MessageBox.Show("Invalid input to the id, please try again");
                    break;
                }

            }
            // Close the workbook and release the objects
            workbook.Close();
            Marshal.ReleaseComObject(workbook);

            application.Quit();
            Marshal.ReleaseComObject(application);
            Process[] pro = Process.GetProcessesByName("excel");

            pro[0].Kill();
            pro[0].WaitForExit();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void loginExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void CageEditBtn_Click(object sender, EventArgs e)
        {
            //open system runtime-app
            string fileName = "birds.xlsx";
            string projectDirectory = System.IO.Path.GetDirectoryName(Application.StartupPath);
            string dataFolder = Path.Combine(projectDirectory, "Data");
            string filePath = System.IO.Path.Combine(dataFolder, fileName);
            bool fileExists = File.Exists(filePath);

            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            application.DisplayAlerts = false;
            workbook = application.Workbooks.Open(filePath);
            worksheet = workbook.Sheets[3];


            int lastRow = worksheet.UsedRange.Rows.Count;
            int rowIndex = 0;
            int n = 0;

            for (int i = 2; i <= lastRow; i++)
            { // Start from 2 to skip the header row

                Excel.Range cageIDCell = worksheet.Cells[i, 1];


                if (cageIDCell.Value.ToString() == cageID)
                {
                    if (int.TryParse(lengthEditBox.Text, out n) && int.TryParse(widthEditBox.Text, out n) && int.TryParse(heightEditBox.Text, out n) && lengthEditBox.Text != "" && widthEditBox.Text != "" && heightEditBox.Text != "" && materialEditBox.Text != "" && int.Parse(lengthEditBox.Text) > 0 && int.Parse(widthEditBox.Text) > 0 && int.Parse(heightEditBox.Text) > 0)
                    {
                        worksheet.Cells[i, 2] = lengthEditBox.Text;
                        worksheet.Cells[i, 3] = widthEditBox.Text;
                        worksheet.Cells[i, 4] = heightEditBox.Text;
                        worksheet.Cells[i, 5] = materialEditBox.Text;
                        workbook.Save();
                        MessageBox.Show("Cage details changed successfully");
                        lengthEditBox.Text = null;
                        widthEditBox.Text = null;
                        heightEditBox.Text = null;
                        materialEditBox.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Invalid input");
                        lengthEditBox.Text = null;
                        widthEditBox.Text = null;
                        heightEditBox.Text = null;
                        materialEditBox.Text = null;

                    }



                }



            }
            workbook.Close();
            Marshal.ReleaseComObject(workbook);

            application.Quit();
            Marshal.ReleaseComObject(application);
            Process[] pro = Process.GetProcessesByName("excel");

            pro[0].Kill();
            pro[0].WaitForExit();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
