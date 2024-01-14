using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using LoginPage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private string userName;
        private string password;
        private string id;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
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
            userName = usernameBox.Text;
            password = passwordBox.Text;
            workbook = application.Workbooks.Open(filePath);
            worksheet = workbook.Sheets[1]; // Get the first worksheet in the workbook
            // Get the last row number
            int lastRow = worksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
            // Check if the username and pass viald
            bool LoginSuccess = false;
            for (int i = 2; i <= lastRow; i++)
            { // Start from 2 to skip the header row

                Excel.Range userCell = worksheet.Cells[i, 1];
                Excel.Range PassCell = worksheet.Cells[i, 2];
                Excel.Range idCell = worksheet.Cells[i, 3];
                if (userCell.Value != null && userCell.Value.ToString() == userName && PassCell.Value != null && PassCell.Value.ToString() == password )
                {
                    LoginSuccess = true;
                    id = idCell.Value.ToString();
                }
            }

            if (!LoginSuccess)
            {
                invalidAuth.Visible = true;
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
            else
            {
                // התחברת בהצלחה
                this.Hide();
                MessageBox.Show("User has logged in");

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

                new MainPage().Show();
            }
            
            //worksheet = null;
            //workbook = null;
            //application = null;
        }
        // get user name amd password,id from the  login form 
        public String getusername()
        {
            return userName;
        }
        public String getpassword()
        {
            return password;
        }
        public String getid()
        {
            return id;
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void regPage_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the login form
            RegForm formReg = new RegForm(this); // Pass the login form instance to the registration form
            formReg.Show(); // Show the registration form
        }

        private void usernameBox_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}