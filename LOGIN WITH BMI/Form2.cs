using LOGIN_WITH_BMI.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static LOGIN_WITH_BMI.Form1;

namespace LOGIN_WITH_BMI
{
    public partial class Form2 : Form
    {
        private List<CalculationResult> calculationResults = new List<CalculationResult>();
        private string loggedInUsername;
        public Form2(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }
        public class CalculationResult
        {
            public string Username { get; set; }
            public double Height { get; set; }
            public double Weight { get; set; }
            public double BMI { get; set; }
            public string Remarks { get; set; }
        }
        double calculateBMI(double height, double weight)
        {
            double bmi = weight / (height * height);
            return bmi;
        }
        public class UserData
        {
            public string Username { get; set; }
        }

        public void SetLoggedInUsername(string username)
        {
            loggedInUsername = username;
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                double height = double.Parse(txtHeight1.Text);
                double weight = double.Parse(txtWeight1.Text);
                double bmi = calculateBMI(height, weight);

                lblBMI.Text = bmi.ToString();

                string remarks;
                if (bmi < 18.5)
                {
                    remarks = "Underweight";
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    remarks = "Normal";
                }
                else if (bmi >= 25 && bmi <= 29.5)
                {
                    remarks = "Overweight";
                }
                else
                {
                    remarks = "Obese";
                }

                lblRemarks.Text = remarks;

                var result = new CalculationResult
                {
                    Username = loggedInUsername,
                    Height = height,
                    Weight = weight,
                    BMI = bmi,
                    Remarks = remarks
                };

                List<CalculationResult> existingResults;
                string fileName = $"_{loggedInUsername}_calculated.json";
                if (File.Exists(fileName))
                {
                    string existingJson = File.ReadAllText(fileName);
                    existingResults = JsonConvert.DeserializeObject<List<CalculationResult>>(existingJson);
                }
                else
                {
                    existingResults = new List<CalculationResult>();
                }

                existingResults.Add(result);

                string json = JsonConvert.SerializeObject(existingResults);

                File.WriteAllText(fileName, json);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Height or Weight");
            }
        }


        private void Loadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryPath = Directory.GetCurrentDirectory();
                string[] files = Directory.GetFiles(directoryPath, $"_{loggedInUsername}_calculated.json");

                if (files.Length == 0)
                {
                    MessageBox.Show("No calculation results found.");
                }
                else
                {
                    dataGridView1.Columns.Clear(); 

                    dataGridView1.Columns.Add("UsernameColumn", "Username");
                    dataGridView1.Columns.Add("HeightColumn", "Height");
                    dataGridView1.Columns.Add("WeightColumn", "Weight");
                    dataGridView1.Columns.Add("RemarksColumn", "Remarks");
                    dataGridView1.Columns.Add("BMIColumn", "BMI");

                    foreach (string file in files)
                    {
                        try
                        {
                            string json = File.ReadAllText(file);
                            List<CalculationResult> results = JsonConvert.DeserializeObject<List<CalculationResult>>(json);

                            foreach (var result in results)
                            {
                                dataGridView1.Rows.Add(result.Username, result.Height, result.Weight, result.Remarks, Math.Round(result.BMI, 2));
                            }
                        }
                        catch (Exception ex)
                        {
                            
                        }
                    }

                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void txtWeight1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
