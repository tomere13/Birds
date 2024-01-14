using LoginPage.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Excel = Microsoft.Office.Interop.Excel;

namespace LoginPage
{
    public partial class Searchbird : Form
    {
        public Searchbird()
        {
            InitializeComponent();
        }

        private void Searchbird_Load(object sender, EventArgs e)
        {


        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (birdSearchBox.Text == "Species")
            {
                datePicker.Visible = false;
                idTextBox.Visible = false;

                SpecieBox.Visible = true;
                SpecieBox.Items.Clear();
                SpecieBox.Text = null;

                SpecieBox.Items.Add("Australian Gouldian");
                SpecieBox.Items.Add("European Gouldian");
                SpecieBox.Items.Add("American Gouldian");
            }
            else if (birdSearchBox.Text == "Hatch date")
            {
                SpecieBox.Items.Clear();
                SpecieBox.Text = null;

                idTextBox.Visible = false;
                SpecieBox.Visible = false;
                datePicker.Visible = true;

            }
            else if (birdSearchBox.Text == "Bird ID")
            {
                SpecieBox.Text = null;

                SpecieBox.Items.Clear();
                datePicker.Visible = false;
                SpecieBox.Visible = false;
                idTextBox.Visible = true;


            }
            else
            {
                datePicker.Visible = false;
                idTextBox.Visible = false;
                SpecieBox.Visible = true;
                SpecieBox.Text = null;

                SpecieBox.Items.Clear();
                SpecieBox.Items.Add("Male");
                SpecieBox.Items.Add("Female");

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
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
            int rowIndex = 0;
            int n = 0;
            dataGridBirds.Rows.Clear();
            for (int i = 2; i <= lastRow; i++)
            { // Start from 2 to skip the header row

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


                if (birdSearchBox.Text == "Bird ID" && userIDCell.Value.ToString() == currentId)
                {
                    try
                    {
                        if (birdIDCell.Value == int.Parse(idTextBox.Text))
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
                    catch
                    {
                        MessageBox.Show("Invalid input to the id, please try again");
                        break;
                    }

                }
                else if (birdSearchBox.Text == "Species" && userIDCell.Value.ToString() == currentId)
                {
                    if (SpecieBox.Text == "")
                    {
                        MessageBox.Show("Invalid input of the species, please try again");
                        break;
                    }
                    else if (speciesCell.Value == SpecieBox.Text)
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
                else if (birdSearchBox.Text == "Hatch date" && userIDCell.Value.ToString() == currentId)
                {
                    if (dateCell.Value == datePicker.Value.Date)
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
                else if (birdSearchBox.Text == "Gender" && userIDCell.Value.ToString() == currentId)
                {
                    if (SpecieBox.Text == "")
                    {
                        MessageBox.Show("Invalid input of the gender, please try again");
                        break;
                    }
                    else if (genderCell.Value == SpecieBox.Text)
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
                else
                {

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

        private void searchGroup_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void birdMainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage FormMain = new MainPage();
            FormMain.Show();
            this.Close();

        }



        private void dataGridBirds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the row that was double-clicked.
            int chosenRow = e.RowIndex;

            // Get the data for the row.

            string species = dataGridBirds.Rows[chosenRow].Cells[1].Value.ToString();
            string gender = dataGridBirds.Rows[chosenRow].Cells[3].Value.ToString();
            string subSpecies = dataGridBirds.Rows[chosenRow].Cells[2].Value.ToString();
            string cageID = dataGridBirds.Rows[chosenRow].Cells[7].Value.ToString();
            string birdID = dataGridBirds.Rows[chosenRow].Cells[0].Value.ToString();
            string headcolor = dataGridBirds.Rows[chosenRow].Cells[9].Value.ToString();
            string chestcolor = dataGridBirds.Rows[chosenRow].Cells[10].Value.ToString();
            string bodycolor = dataGridBirds.Rows[chosenRow].Cells[11].Value.ToString();
            DateTime dateParent = (DateTime)dataGridBirds.Rows[chosenRow].Cells[6].Value;


            // Create a new instance of the form that you want to send the data to.`
            Addchick form = new Addchick();

            if (gender == "Male")
            {
                form.reciveFromFather = true;
                form.reciveFromMothrer = false;
                form.motherChickBox.Visible = true;
                form.fatherChickBox.Visible = false;
                form.motherIdLabel.Visible = true;
                form.FatherIdLabel.Visible = false;

            }
            else
            {
                form.reciveFromFather = false;
                form.reciveFromMothrer = true;
                form.motherChickBox.Visible = false;
                form.motherIdLabel.Visible = false;
                form.FatherIdLabel.Visible = true;
                form.fatherChickBox.Visible = true;
            }
            // Set the data for the new form.

            form.birdID = birdID;
            form.species = species;
            form.subSpecies = subSpecies;
            form.cageID = cageID;
            form.gender = gender;
            form.headcolor = headcolor;
            form.chestcolor = chestcolor;
            form.bodycolor = bodycolor;
            form.dateParent = dateParent;
            // Show the new form.

            form.Show();


            //using (Addchick addchick = new Addchick())
            //    addchick.ShowDialog();
            //if (!IsDisposed) Show();
        }

        private void dataGridBirds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addChickLabels_Click(object sender, EventArgs e)
        {

        }

        private void SpecieBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
