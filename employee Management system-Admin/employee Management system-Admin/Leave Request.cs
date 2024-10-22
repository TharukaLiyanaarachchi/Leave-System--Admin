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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace employee_management_admin_
{
    public partial class Leave_Request : Form
    {
        public Leave_Request()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NAVEEN5445;Initial Catalog=""Leave Management System"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void AddNew_Click(object sender, EventArgs e)
        {
            {

                string query = "UPDATE Leave_request SET status = @Status WHERE leave_id = @Id";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Status", "approved");
                command.Parameters.AddWithValue("@Id", LID.Text);

                try
                {
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) updated.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("Select * from Leave_request ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        private void SetLeaveStatus(int leaveId, string status)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE LeaveRequest SET LeaveStatus = @Status WHERE LeaveID = @LeaveID", con);

                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@LeaveID", leaveId);

                cmd.ExecuteNonQuery();
                MessageBox.Show($"Leave request has been {status.ToLower()}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
                // Optionally, refresh the leave request data grid or form
            }
        }
        private void Approve_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(LID.Text, out int leaveId))
            {
                MessageBox.Show("Please enter a valid Leave ID.");
                return;
            }
            
                try
                {

                    con.Open();
                   
                    SqlCommand cmd = new SqlCommand("UPDATE Leave_request SET status = @Status WHERE Leave_id = @LeaveID", con);

                    cmd.Parameters.AddWithValue("@Status", "Approved");
                    cmd.Parameters.AddWithValue("@LeaveID", leaveId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Leave request Approved");
                    BindData();


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
        private void Reject_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(LID.Text, out int leaveId))
            {
                MessageBox.Show("Please enter a valid Leave ID.");

            }

            try
            {
                con.Open();

                int employee_id = 0;
                decimal? annual_leave = null, casual_leave = null, short_leave = null;

                SqlCommand cmd1 = new SqlCommand("SELECT employee_id, annual_Leave, casual_Leave, short_Leave FROM Leave_request WHERE Leave_id = @LeaveID", con);
                cmd1.Parameters.AddWithValue("@LeaveID", leaveId);

                SqlDataReader reader = cmd1.ExecuteReader();

                if (reader.Read()) {
                    employee_id = reader.GetInt32(reader.GetOrdinal("employee_id"));
                    annual_leave = reader.IsDBNull(reader.GetOrdinal("annual_Leave")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("annual_Leave"));
                    casual_leave = reader.IsDBNull(reader.GetOrdinal("casual_Leave")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("casual_Leave"));
                    short_leave = reader.IsDBNull(reader.GetOrdinal("short_Leave")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("short_Leave"));
                }
                else
                {
                    MessageBox.Show("leave request not found");
                    reader.Close();
                    return;
                }

                reader.Close();

                SqlCommand cmd2 = new SqlCommand("UPDATE Leave_balance_employee SET " +
                    "annual_Leave_balance = ISNULL(annual_Leave_balance, 0) + ISNULL(@AnnualLeave, 0), " +
                    "casual_Leave_balance = ISNULL(casual_Leave_balance, 0) + ISNULL(@CasualLeave, 0), " +
                    "short_Leave_balance = ISNULL(short_Leave_balance, 0) + ISNULL(@ShortLeave, 0) " +
                    "WHERE employee_id = @EmpId", con
                    );


                cmd2.Parameters.AddWithValue("@AnnualLeave", annual_leave ?? (object)DBNull.Value);
                cmd2.Parameters.AddWithValue("@CasualLeave", casual_leave ?? (object)DBNull.Value);
                cmd2.Parameters.AddWithValue("@ShortLeave", short_leave ?? (object)DBNull.Value);
                cmd2.Parameters.AddWithValue("@EmpId", employee_id);

                cmd2.ExecuteNonQuery();


                SqlCommand cmd = new SqlCommand("UPDATE Leave_request SET status = @Status WHERE Leave_id = @LeaveID", con);

                cmd.Parameters.AddWithValue("@Status", "Reject");
                cmd.Parameters.AddWithValue("@LeaveID", leaveId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Request Rejected.");
                BindData();
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
            finally { 
                con.Close();
            }
            
        }
        private void Pending_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LID.Text, out int leaveId))
            {
                SetLeaveStatus(leaveId, "Pending");
            }
            else
            {
                MessageBox.Show("Please enter a valid Leave ID.");
            }
        }

        private void Deactivate_Click(object sender, EventArgs e)
        {
            {

                string query = "UPDATE Leave_request SET status = @Status WHERE leave_id = @Id";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Status", "rejected");
                command.Parameters.AddWithValue("@Id", LID.Text);

                try
                {
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) updated.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
        }

        private void Leave_Request_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Leave_request where employee_id = '" + textBox1.Text + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Put Employee ID");
            }
        }
    }
}
