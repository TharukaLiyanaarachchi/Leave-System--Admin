using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_management_admin_
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Employee_Registration emp = new Employee_Registration();
                this.Hide();
                emp.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to Log out?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Leave_Request lr = new Leave_Request();
                this.Hide();
                lr.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Leave_Allocation lr = new Leave_Allocation();
                this.Hide();
                lr.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Roaster_Allocation lr = new Roaster_Allocation();
                this.Hide();
                lr.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Individual_Employee_Leave_History lr = new Individual_Employee_Leave_History();
                this.Hide();
                lr.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
    }

}
