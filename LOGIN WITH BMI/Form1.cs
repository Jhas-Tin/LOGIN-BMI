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
using System.Net.NetworkInformation;

namespace LOGIN_WITH_BMI
{
    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();
        private DataGridViewTextBoxColumn usernameColumn;
       // private DataGridViewTextBoxColumn passwordColumn;
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridViewColumns();
            LoadUserData();
        }
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;

            string filePath = "Datas.json";
            try
            {
               
                string json = File.ReadAllText(filePath);
                users = JsonConvert.DeserializeObject<List<User>>(json);

                User foundUser = users.Find(u => u.Username == username && u.Password == password);
                if (foundUser != null)
                {
                    MessageBox.Show("Sign-in successful!");
                    Form2 form2 = new Form2(username); 
                    this.Hide();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (FileNotFoundException)
            {
            }
            catch (Exception ex)
            {
            }
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = txtuser.Text,
                Password = txtpass.Text
            };

            users.Add(user);

            string json = JsonConvert.SerializeObject(users);

            string filePath = "Datas.json";

            try
            {
                File.WriteAllText(filePath, json);
                MessageBox.Show("Register Successfully");
                txtpass.Text = "";
                txtuser.Text = "";
            }
            catch (Exception ex)
            {
            }
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                dgvtable.Rows.Clear();

                foreach (var user in users)
                {
                    dgvtable.Rows.Add(user.Username, user.Password);
                }

            }
            catch (Exception ex)
            {
           
            }
        }
        private void InitializeDataGridViewColumns()
        {
            int usernameColumnWidth = dgvtable.Width / 2;
            usernameColumn = new DataGridViewTextBoxColumn();
            usernameColumn.HeaderText = "Username";
            usernameColumn.Name = "usernameColumn";
            /*
            passwordColumn = new DataGridViewTextBoxColumn();
            passwordColumn.HeaderText = "Password";
            passwordColumn.Name = "passwordColumn";
            */
            dgvtable.Columns.Add(usernameColumn);
            //dgvtable.Columns.Add(passwordColumn);
        }
        private void LoadUserData()
        {
            string filePath = "Datas.json";

            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);

                users = JsonConvert.DeserializeObject<List<User>>(jsonData);
            }
        }
    }
}
