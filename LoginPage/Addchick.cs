using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Boolean = System.Boolean;

namespace LoginPage
{
    public partial class Addchick : Form
    {
        // all the data that come from the parent who choosen 
        public string birdID;
        public string species;
        public string subSpecies;
        public string cageID;
        public string gender;
        public string headcolor;
        public string chestcolor;
        public string bodycolor;
        public Boolean reciveFromMothrer;
        public Boolean reciveFromFather;
        public string sheadcolor;
        public string schestcolor;
        public string sbodycolor;
        public string editNewCage;
        public DateTime dateParent;

        public Addchick()
        {

            InitializeComponent();

        }

        private void chickGroup_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chickMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (MainPage FormMain = new MainPage())
                FormMain.ShowDialog();
            Show();
        }

        private void exitChickBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void addChickBtn_Click(object sender, EventArgs e)
        {
            Boolean motherSerial = false;
            Boolean fatherSerial = false;
            DateTime selectedDate = dateChickBox.Value.Date;
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
            worksheet = workbook.Sheets[2]; // Get the second worksheet in the workbook
            string sheadcolor = "";
            string schestcolor = "";
            string sbodycolor = "";
            DateTime otherParent = DateTime.Now;
            // Get the last row number
            int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            if (reciveFromFather)
            {
                motherChickBox.Visible = true;
                fatherChickBox.Visible = false;
                for (int i = 2; i <= lastRow; i++)
                {
                    // Start from 2 to skip the header row
                    Excel.Range userCell = worksheet.Cells[i, 1];
                    if (userCell.Value.ToString() == motherChickBox.Text)
                    {
                        Excel.Range GenderCell = worksheet.Cells[i, 4];
                        if (GenderCell.Value.ToString() == "Female")
                        {
                            otherParent = (DateTime)worksheet.Cells[i, 7].Value;
                            sheadcolor = worksheet.Cells[i, 10].Value.ToString();
                            schestcolor = worksheet.Cells[i, 11].Value.ToString();
                            sbodycolor = worksheet.Cells[i, 12].Value.ToString();
                            motherSerial = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                fatherChickBox.Visible = true;
                motherChickBox.Visible = false;
                for (int i = 2; i <= lastRow; i++)
                {
                    // Start from 2 to skip the header row
                    Excel.Range user2Cell = worksheet.Cells[i, 1];
                    if (user2Cell.Value.ToString() == fatherChickBox.Text)
                    {
                        Excel.Range Gender2Cell = worksheet.Cells[i, 4];
                        if (Gender2Cell.Value.ToString() == "Male")
                        {
                            otherParent = (DateTime)worksheet.Cells[i, 7].Value;
                            sheadcolor = worksheet.Cells[i, 10].Value.ToString();
                            schestcolor = worksheet.Cells[i, 11].Value.ToString();
                            sbodycolor = worksheet.Cells[i, 12].Value.ToString();
                            fatherSerial = true;
                            break;
                        }
                    }
                }

            }

            if (selectedDate != null && chickGenderCombo.Text != "" && ((reciveFromFather && motherSerial) || (reciveFromMothrer && fatherSerial)) && selectedDate >= dateParent && selectedDate >= otherParent)
            {

                int newRow = lastRow + 1;
                worksheet.Cells[newRow, 1] = newRow - 1;
                worksheet.Cells[newRow, 2] = species;
                worksheet.Cells[newRow, 3] = subSpecies;
                worksheet.Cells[newRow, 4] = chickGenderCombo.Text;
                if (reciveFromFather && motherSerial)
                {
                    worksheet.Cells[newRow, 5] = motherChickBox.Text;
                    worksheet.Cells[newRow, 6] = birdID;

                }

                else if (reciveFromFather && fatherSerial)
                {
                    worksheet.Cells[newRow, 5] = birdID;
                    worksheet.Cells[newRow, 6] = fatherChickBox.Text;


                }
                worksheet.Cells[newRow, 7] = selectedDate;
                worksheet.Cells[newRow, 8] = cageID.ToString();
                worksheet.Cells[newRow, 9] = ((LoginForm)Application.OpenForms["LoginForm"]).getid();

                if (headcolor == sheadcolor)
                {
                    worksheet.Cells[newRow, 10] = headcolor;
                }
                if (headcolor != sheadcolor)
                {
                    if (gender == "Male" && headcolor == "Black" && sheadcolor == "Red")
                    {
                        if (chickGenderCombo.Text == "Male")
                            worksheet.Cells[newRow, 10] = sheadcolor;
                        else
                            worksheet.Cells[newRow, 10] = headcolor;
                    }
                    if (gender == "Female" && headcolor == "Black" && sheadcolor == "Red")
                    {
                        worksheet.Cells[newRow, 10] = sheadcolor;
                    }
                    else
                        if (headcolor == "Black" || sheadcolor == "Black")
                        worksheet.Cells[newRow, 10] = "Black";
                    else
                        worksheet.Cells[newRow, 10] = "Red";
                }

                if (chestcolor == "Purple" || schestcolor == "Purple")
                {
                    worksheet.Cells[newRow, 11] = "Purple";
                }
                else if (chestcolor == "Lilac" || schestcolor == "Lilac")
                {
                    worksheet.Cells[newRow, 11] = "Lilac";
                }
                else
                {
                    worksheet.Cells[newRow, 11] = "White";
                }
                if (bodycolor == sbodycolor)
                {
                    worksheet.Cells[newRow, 12] = bodycolor;
                }
                if (bodycolor != sbodycolor)
                {
                    if (gender == "Male")
                    {
                        if (bodycolor == "Yellow" && sbodycolor == "Green")
                        {
                            if (chickGenderCombo.Text == "Male")
                            {
                                worksheet.Cells[newRow, 12] = "Diluted";
                            }
                            else
                            {
                                worksheet.Cells[newRow, 12] = "Yellow";
                            }

                        }
                    }
                    else
                    {
                        if (bodycolor == "Yellow" && sbodycolor == "Green")
                        {
                            if (chickGenderCombo.Text == "Male")
                                worksheet.Cells[newRow, 12] = "Diluted";
                            else
                            {
                                worksheet.Cells[newRow, 12] = sbodycolor;
                            }
                        }
                    }
                    if (bodycolor == "Blue" && sbodycolor == "Yellow" || bodycolor == "Yellow" && sbodycolor == "Blue")
                    {
                        worksheet.Cells[newRow, 12] = "Silver";
                    }
                    else
                    {
                        worksheet.Cells[newRow, 12] = bodycolor;
                    }
                }


                workbook.Save();
                MessageBox.Show("Bird was added successfully");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invaild input, Bird was not added");
                this.Hide();

            }

            chickGenderCombo.Text = null;
            motherChickBox.Text = null;
            fatherChickBox.Text = null;
            selectedDate = DateTime.Today;

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

            // Release COM objects
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(application);

        }


        private void SpacieLabel_Click(object sender, EventArgs e)
        {

        }

        private void Addchick_Load(object sender, EventArgs e)
        {
            IdLabel.Text = birdID;
            SpacieLabel.Text = species;
            subLabel.Text = subSpecies;
            genderLabel.Text = gender;
            cageTxt.Text = cageID;
            HeadCLabel.Text = headcolor;
            ChestCLabel.Text = chestcolor;
            bodyCLabel.Text = bodycolor;

        }

        private void subLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateChickLabel_Click(object sender, EventArgs e)
        {

        }

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void cageMainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cageTxt_TextChanged(object sender, EventArgs e)
        {
            editNewCage = cageTxt.Text;
        }

        private Boolean CageExist(string cage)
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
            worksheet = workbook.Sheets[3]; // Get the third worksheet in the workbook

            // Get the last row number
            int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;

            bool cageExist = false;
            for (int i = 2; i <= lastRow; i++)
            {
                // Start from 2 to skip the header row
                Excel.Range cageCell = worksheet.Cells[i, 1];
                Excel.Range userID = worksheet.Cells[i, 6];
                if (cageCell.Value != null && cageCell.Value.ToString() == cage && userID.Value.ToString() == ((LoginForm)Application.OpenForms["LoginForm"]).getid())
                {
                    cageExist = true;
                    break;
                }

            }
            // Close the workbook and release the objects
            workbook.Close();
            Marshal.ReleaseComObject(workbook);

            application.Quit();
            Marshal.ReleaseComObject(application);
            return cageExist;
        }


        private void ChangeCage_Click(object sender, EventArgs e)
        {
            //open system runtime-app
            string fileName = "birds.xlsx";
            string projectDirectory = System.IO.Path.GetDirectoryName(Application.StartupPath);
            string dataFolder = Path.Combine(projectDirectory, "Data");
            string filePath = System.IO.Path.Combine(dataFolder, fileName);
            bool fileExists = File.Exists(filePath);

            Excel.Application application2 = new Excel.Application();
            Excel.Workbook workbook2;
            Excel.Worksheet worksheet2;
            application2.DisplayAlerts = false;
            workbook2 = application2.Workbooks.Open(filePath);
            worksheet2 = workbook2.Sheets[2]; // Get the second worksheet in the workbook

            string newCageID = cageTxt.Text;

            int lastRow = worksheet2.UsedRange.Rows.Count;
            int rowIndex = 0;
            int n = 0;
            for (int i = 2; i <= lastRow; i++)
            { // Start from 2 to skip the header row
                try
                {
                    Excel.Range birdIDCell = worksheet2.Cells[i, 1];

                    if (birdIDCell.Value.ToString() == birdID)
                    {
                        if (CageExist(newCageID))
                        {
                            worksheet2.Cells[i, 8] = newCageID;
                            workbook2.Save();
                            MessageBox.Show("Bird cage changed successfully");
                            break;
                        }

                        else
                        {
                            MessageBox.Show("Cage number is not exist, try again.");
                            break;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error, try again.");
                    break;

                }


            }
            // Close the workbook and release the objects
            workbook2.Close();
            Marshal.ReleaseComObject(workbook2);

            application2.Quit();
            Marshal.ReleaseComObject(application2);
            Process[] pro = Process.GetProcessesByName("excel");

            pro[0].Kill();
            pro[0].WaitForExit();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Release COM objects
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet2);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook2);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(application2);

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

