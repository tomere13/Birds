using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms; // If you're using Windows Forms
using System.Diagnostics;

namespace LoginPage
{
    public partial class MainPage : Form
    {
        public MainPage()
        {  

            InitializeComponent();
        }


        private void AddBbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addbird searchbird = new Addbird();
            searchbird.Show();
            this.Close();
        }

        private void Addcbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addcage addcage = new Addcage();
            addcage.Show();
            this.Close();
        }


        private void SearchBbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searchbird searchbird = new Searchbird();
            searchbird.Show();
            this.Close();


        }
        private void SearchCbtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            SearchCage searchbird = new SearchCage();
            searchbird.Show();
            this.Close();
        }



        private void mainExit_Click(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            string fileName = "birds.xlsx";
            string projectDirectory = System.IO.Path.GetDirectoryName(Application.StartupPath);
            string dataFolder = Path.Combine(projectDirectory, "Data");
            string filePath = System.IO.Path.Combine(dataFolder, fileName);
            bool fileExists = File.Exists(filePath);
            String currentId = ((LoginForm)Application.OpenForms["LoginForm"]).getid();
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            application.DisplayAlerts = false;
            workbook = application.Workbooks.Open(filePath);
            worksheet = workbook.Sheets[2];

            int lastRow = worksheet.UsedRange.Rows.Count;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            for (int i = 2; i <= lastRow; i++)
            {
                Excel.Range userIDCell = worksheet.Cells[i, 9];
                Excel.Range speciesCell = worksheet.Cells[i, 2];

                if (userIDCell.Value.ToString() == currentId)
                {
                    count4++;
                    if (speciesCell.Value.ToString() == "American Gouldian")
                    {
                        count1++;
                    }
                    else if (speciesCell.Value.ToString() == "European Gouldian")
                    {
                        count2++;
                    }
                    else
                    {
                        count3++;
                    }
                }

            }
            PieSeries pieSeries = new PieSeries
            {
                StrokeThickness = 2.0,
                InsideLabelPosition = 0.8,
                AngleSpan = 360,
                StartAngle = 0
            };

            pieSeries.Slices.Add(new PieSlice("American Gouldian", count1) { Fill = OxyColors.LightSkyBlue });
            pieSeries.Slices.Add(new PieSlice("European Gouldian", count2) { Fill = OxyColors.MediumSpringGreen });
            pieSeries.Slices.Add(new PieSlice("Australian Gouldian", count3) { Fill = OxyColors.MediumSlateBlue });

            PlotModel plotModel = new PlotModel();
            plotModel.Series.Add(pieSeries);
            label5.Text = count4.ToString();
            label6.Text = cageNumber();
            // Assign the plotModel to the existing PlotView control
            plotView.Model = plotModel;

            //Close the workbook and release the objects
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
        private string cageNumber()
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
            int countCage = 0;
            bool cageExist = false;
            for (int i = 2; i <= lastRow; i++)
            {
                // Start from 2 to skip the header row
                Excel.Range userID = worksheet.Cells[i, 6];
                if (userID.Value.ToString() == ((LoginForm)Application.OpenForms["LoginForm"]).getid())
                {
                    countCage++;
                }

            }
            // Close the workbook and release the objects
            workbook.Close();
            Marshal.ReleaseComObject(workbook);
            application.Quit();
            Marshal.ReleaseComObject(application);

            return countCage.ToString();
        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
