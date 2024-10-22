using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
using System.Xml.Linq;

namespace employee_management_admin_
{
    public partial class Individual_Employee_Leave_History : Form
    {
        public Individual_Employee_Leave_History()
        {
            InitializeComponent();


        }

        SqlConnection con = new SqlConnection(@"Data Source=NAVEEN5445;Initial Catalog=""Leave Management System"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void LeaveID_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Create a SQL query to fetch all leave requests
                SqlCommand cmd = new SqlCommand("SELECT * FROM Leave_request", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                // Fill the DataTable with the result of the query
                da.Fill(dt);

                // Set the DataSource of the DataGridView to the DataTable
                LevaeHistory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IndividualLeaveHistoryReport_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Dashboard d = new Dashboard();
                this.Hide();
                d.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                // Create a SQL query to fetch all leave requests
                SqlCommand cmd = new SqlCommand("SELECT * FROM Leave_request WHERE employee_id = @empid", con);
                cmd.Parameters.AddWithValue("@empid", Empid.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                // Fill the DataTable with the result of the query
                da.Fill(dt);

                // Set the DataSource of the DataGridView to the DataTable
                LevaeHistory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
