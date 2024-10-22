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
using static System.Windows.Forms.AxHost;

namespace employee_management_admin_
{
    public partial class Employee_Registration : Form
    {
        private bool isDeactivated = false; // Flag to track the state
        public Employee_Registration()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NAVEEN5445;Initial Catalog=""Leave Management System"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void RoasterID_Click(object sender, EventArgs e)
        {

        }

        private void RoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeID_Click(object sender, EventArgs e)
        {

        }

        private void EmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("Select * from Employee ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            EmployeeRegistrationDeatils.DataSource = dt;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (EFName.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Employee where full_Name = '" + EFName.Text + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    EmployeeRegistrationDeatils.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Value Present");
                }
            }
            else
            {
                MessageBox.Show("Put First Name");
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (isDeactivated)
            {
                MessageBox.Show("Adding new employees is currently deactivated.");
                return; // Exit the method without inserting data
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                       "INSERT INTO Employee (nic_No, full_Name, address, date_of_birth, Age, civil_status,gender, contact_number, email_address, date_of_join,employee_type,designation) " +
                       "VALUES (@NICID, @EFName, @EAddress,  @EDOF ,@EAge,@ECStatus, @EGender, @ECNumber, @EID, @EDateofJ, @EEmpType, @EmpDesignation)", con);

                // Add parameters to avoid SQL injection and handle special characters correctly
                cmd.Parameters.AddWithValue("@NICID", NICID.Text);
                cmd.Parameters.AddWithValue("@EFName", EFName.Text);
                cmd.Parameters.AddWithValue("@EAddress", EAddress.Text);
                cmd.Parameters.AddWithValue("@EDOF", EDOF.Text);  // Ensure DOB format is compatible with the database
                cmd.Parameters.AddWithValue("@EAge", EAge.Text);
                cmd.Parameters.AddWithValue("@ECStatus", ECStatus.Text);
                cmd.Parameters.AddWithValue("@EGender", EGender.Text);
                cmd.Parameters.AddWithValue("@ECNumber", ECNumber.Text);
                cmd.Parameters.AddWithValue("@EID", EID.Text);
                cmd.Parameters.AddWithValue("@EDateofJ", EDateofJ.Text);
                cmd.Parameters.AddWithValue("@EEmpType", EEmpType.Text);
                cmd.Parameters.AddWithValue("@EmpDesignation", EmpDesignation.Text);

                // Execute the command
                cmd.ExecuteNonQuery();
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

        private void Update_Click(object sender, EventArgs e)
        {
            if(EmpID.Text == null)
            {
                MessageBox.Show("Enter employee Id");
            }

            con.Open();
            SqlCommand cmd = new SqlCommand(@"
                UPDATE Employee 
                SET 
                    nic_No = COALESCE(NULLIF(@nicNo, ''), nic_No),
                    full_Name = COALESCE(NULLIF(@fullName, ''), full_Name),
                    address = COALESCE(NULLIF(@address, ''), address),
                    date_of_birth = COALESCE(NULLIF(@dob, ''), date_of_birth),
                    Age = COALESCE(NULLIF(@age, ''), Age),
                    civil_status = COALESCE(NULLIF(@civilStatus, ''), civil_status),
                    gender = COALESCE(NULLIF(@gender, ''), gender),
                    contact_number = COALESCE(NULLIF(@contactNumber, ''), contact_number),
                    email_address = COALESCE(NULLIF(@email, ''), email_address),
                    date_of_join = COALESCE(NULLIF(@dateOfJoin, ''), date_of_join),
                    employee_type = COALESCE(NULLIF(@employeeType, ''), employee_type),
                    designation = COALESCE(NULLIF(@designation, ''), designation)
                WHERE employee_id = @employeeId", con);

            cmd.Parameters.AddWithValue("@nicNo", NICID.Text);
            cmd.Parameters.AddWithValue("@fullName", EFName.Text);
            cmd.Parameters.AddWithValue("@address", EAddress.Text);
            cmd.Parameters.AddWithValue("@dob", EDOF.Text);
            cmd.Parameters.AddWithValue("@age", EAge.Text);
            cmd.Parameters.AddWithValue("@civilStatus", ECStatus.Text);
            cmd.Parameters.AddWithValue("@gender", EGender.Text);
            cmd.Parameters.AddWithValue("@contactNumber", ECNumber.Text);
            cmd.Parameters.AddWithValue("@email", EID.Text);
            cmd.Parameters.AddWithValue("@dateOfJoin", EDateofJ.Text);
            cmd.Parameters.AddWithValue("@employeeType", EEmpType.Text);
            cmd.Parameters.AddWithValue("@designation", EmpDesignation.Text);
            cmd.Parameters.AddWithValue("@employeeId", int.Parse(EmpID.Text));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Update Success..");
            con.Close();
            BindData();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            isDeactivated = true; // Set the flag to true, indicating deactivation
            MessageBox.Show("New employee registration has been deactivated.");

            // Optionally, disable the "Insert" button to prevent user interaction
            Insert.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
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
    }
}
