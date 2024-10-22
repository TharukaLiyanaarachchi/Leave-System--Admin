using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace employee_management_admin_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NAVEEN5445;Initial Catalog=Leave Management System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        private void Login_Click(object sender, EventArgs e)
        {
            String username, password;
            username = AdminUsername.Text;
            password = PW.Text;


            try
            {

                Console.WriteLine("user" + AdminUsername.Text + "password" + PW.Text);

                String query = "SELECT * FROM Login_Employee_User WHERE username = '" + AdminUsername.Text + "'AND password = '" + PW.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    username = AdminUsername.Text;
                    password = PW.Text;

                    //page that needed to be load next
                    Dashboard form2 = new Dashboard();
                    form2.ShowDialog();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AdminUsername.Clear();
                    PW.Clear();

                    // to focus username 
                    AdminUsername.Focus();
                    PW.Focus();


                }

            }
            catch (Exception ex)
            {
                
                    MessageBox.Show("Error", ex.Message);
                
            }
            finally
            {
                con.Close();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            AdminUsername.Clear();
            PW.Clear();


            AdminUsername.Focus();
            PW.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void EmployeeNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
