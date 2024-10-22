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

namespace employee_management_admin_
{
    public partial class Roaster_Allocation : Form
    {
        public Roaster_Allocation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NAVEEN5445;Initial Catalog=""Leave Management System"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

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

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("Select * from Employee_Roaster_allocation ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            try // Wrapping in try-catch for error handling
            {
                if (!int.TryParse(EmpID.Text, out int Employee_ID))
                {
                    MessageBox.Show("Please enter a valid numeric value for Employee ID.");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand(
                       "INSERT INTO Employee_Roaster_allocation (employee_id,date, in_time, out_time) " +
                       "VALUES (@empid, @RDate, @RInTime, @ROTime)", con);

                // Add parameters to avoid SQL injection and handle special characters correctly
                cmd.Parameters.AddWithValue("@RDate", RDate.Text);
                cmd.Parameters.AddWithValue("@RInTime", RInTime.Text);
                cmd.Parameters.AddWithValue("@ROTime", ROTime.Text);
                cmd.Parameters.AddWithValue("@empid", Employee_ID);

                // Execute the command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Insert Success.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
                BindData(); // Assuming you have this method to refresh the data in the UI
            }
        }

        private void Deactivate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Assuming RosterID is the unique identifier and a TextBox or control with this name exists in your form
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Employee_Roaster_allocation SET IsActive = 0 WHERE RosterID = @RosterID", con);

                // Add the RosterID parameter to avoid SQL injection
                //cmd.Parameters.AddWithValue("@RosterID", RoID.Text);

                // Execute the command
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Roster deactivated successfully.");
                }
                else
                {
                    MessageBox.Show("No roster found with the specified ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
                BindData(); // Refresh the data in the UI after deactivation
            }
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

                SqlCommand cmd = new SqlCommand("Select * from Employee_Roaster_allocation WHERE employee_id = @empid ", con);
                cmd.Parameters.AddWithValue("@empid", Employee_ID);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
