using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.Net.NetworkInformation;

namespace employee_management_admin_
{
    public partial class Leave_Allocation : Form
    {
        private bool isDeactivated = false; // Flag to track the state
        public Leave_Allocation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NAVEEN5445;Initial Catalog=""Leave Management System"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("Select * from Leave_allocation ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            LeaveAllocationDetail.DataSource = dt;
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            if (isDeactivated)
            {
                MessageBox.Show("Data insertion is currently deactivated.");
                return; // Exit the method without inserting data
            }

            // Validate the Employee ID input
            if (!int.TryParse(EmpID.Text, out int Employee_ID))
            {
                MessageBox.Show("Please enter a valid numeric value for Employee ID.");
                return;
            }


            try
            {
                con.Open();

                // Check if the employee_id already exists
                string checkQuery = "SELECT COUNT(*) FROM Leave_allocation WHERE employee_id = @empID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@empID", EmpID.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // Employee ID already exists
                        MessageBox.Show("An entry with this Employee ID already exists.");
                        return;
                    }
                }

                SqlCommand cmd = new SqlCommand(
                       "INSERT INTO Leave_allocation (employee_id, total_annual_Leave, total_casual_Leave, total_short_Leave) " +
                       "VALUES (@empID, @TotalAL, @TotalCL, @TotalSL)", con);

                // Add parameters to avoid SQL injection and handle special characters correctly
                cmd.Parameters.AddWithValue("@TotalAL", TotalAL.Text);
                cmd.Parameters.AddWithValue("@TotalCL", TotalCL.Text);
                cmd.Parameters.AddWithValue("@TotalSL", TotalSL.Text);
                cmd.Parameters.AddWithValue("@empID", EmpID.Text);

                SqlCommand cmd2 = new SqlCommand(
                       "INSERT INTO Leave_balance_employee (employee_id, annual_Leave_balance, casual_Leave_balance, short_Leave_balance) " +
                       "VALUES (@empID, @TotalAL, @TotalCL, @TotalSL)", con);

                // Add parameters to avoid SQL injection and handle special characters correctly
                cmd2.Parameters.AddWithValue("@TotalAL", TotalAL.Text);
                cmd2.Parameters.AddWithValue("@TotalCL", TotalCL.Text);
                cmd2.Parameters.AddWithValue("@TotalSL", TotalSL.Text);
                cmd2.Parameters.AddWithValue("@empID", EmpID.Text);

                // Execute the command
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Data Insert Success..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
                BindData();
            }
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

        private void Deactivate_Click(object sender, EventArgs e)
        {
            if (EmpID.Text == null)
            {
                MessageBox.Show("Enter employee Id");
            }

            con.Open();
            SqlCommand cmd = new SqlCommand(@"
                UPDATE Leave_allocation 
                SET 
                    total_annual_Leave = COALESCE(NULLIF(@annual, ''), total_annual_Leave),
                    total_casual_Leave = COALESCE(NULLIF(@casual, ''), total_casual_Leave),
                    total_short_Leave = COALESCE(NULLIF(@short, ''), total_short_Leave)
                    
                WHERE employee_id = @employeeId", con);
           

            cmd.Parameters.AddWithValue("@annual", TotalAL.Text);
            cmd.Parameters.AddWithValue("@casual", TotalCL.Text);
            cmd.Parameters.AddWithValue("@short", TotalSL.Text);
            
            cmd.Parameters.AddWithValue("@employeeId", int.Parse(EmpID.Text));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Update Success..");
            con.Close();
            BindData();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(EmpID.Text, out int Employee_ID))
                {
                    MessageBox.Show("Please enter a valid numeric value for Employee ID.");
                    return;
                }

                SqlCommand cmd = new SqlCommand("Select * from Leave_allocation WHERE employee_id = @empID ", con);
                cmd.Parameters.AddWithValue("@empID", EmpID.Text);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                LeaveAllocationDetail.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
