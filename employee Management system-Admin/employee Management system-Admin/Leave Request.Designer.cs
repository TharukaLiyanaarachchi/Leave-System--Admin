namespace employee_management_admin_
{
    partial class Leave_Request
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cancel = new Button();
            reject = new Button();
            Search = new Button();
            EmployeeNo = new Button();
            textBox1 = new TextBox();
            EmployeeLeaveRequest = new Label();
            Approve = new Button();
            dataGridView1 = new DataGridView();
            LID = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.Location = new Point(46, 234);
            Cancel.Margin = new Padding(3, 4, 3, 4);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(123, 58);
            Cancel.TabIndex = 105;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // reject
            // 
            reject.Location = new Point(470, 234);
            reject.Margin = new Padding(3, 4, 3, 4);
            reject.Name = "reject";
            reject.Size = new Size(115, 58);
            reject.TabIndex = 103;
            reject.Text = "Reject";
            reject.UseVisualStyleBackColor = true;
            reject.Click += Reject_Click;
            // 
            // Search
            // 
            Search.Location = new Point(470, 123);
            Search.Margin = new Padding(3, 4, 3, 4);
            Search.Name = "Search";
            Search.Size = new Size(115, 58);
            Search.TabIndex = 102;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // EmployeeNo
            // 
            EmployeeNo.Location = new Point(46, 123);
            EmployeeNo.Margin = new Padding(3, 4, 3, 4);
            EmployeeNo.Name = "EmployeeNo";
            EmployeeNo.Size = new Size(115, 29);
            EmployeeNo.TabIndex = 100;
            EmployeeNo.Text = "Employee No";
            EmployeeNo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 123);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 27);
            textBox1.TabIndex = 99;
            // 
            // EmployeeLeaveRequest
            // 
            EmployeeLeaveRequest.AutoSize = true;
            EmployeeLeaveRequest.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeLeaveRequest.Location = new Point(244, 55);
            EmployeeLeaveRequest.Name = "EmployeeLeaveRequest";
            EmployeeLeaveRequest.Size = new Size(375, 36);
            EmployeeLeaveRequest.TabIndex = 97;
            EmployeeLeaveRequest.Text = "Employee Leave Request";
            // 
            // Approve
            // 
            Approve.Location = new Point(630, 234);
            Approve.Margin = new Padding(3, 4, 3, 4);
            Approve.Name = "Approve";
            Approve.Size = new Size(115, 58);
            Approve.TabIndex = 104;
            Approve.Text = "Approve";
            Approve.UseVisualStyleBackColor = true;
            Approve.Click += Approve_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 319);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(699, 188);
            dataGridView1.TabIndex = 106;
            // 
            // LID
            // 
            LID.ForeColor = Color.Black;
            LID.Location = new Point(231, 177);
            LID.Margin = new Padding(3, 4, 3, 4);
            LID.Name = "LID";
            LID.Size = new Size(136, 27);
            LID.TabIndex = 110;
            LID.TextChanged += textBox6_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(46, 177);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(114, 29);
            button2.TabIndex = 109;
            button2.Text = "Leave ID";
            button2.UseVisualStyleBackColor = true;
            // 
            // Leave_Request
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(LID);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(Cancel);
            Controls.Add(Approve);
            Controls.Add(reject);
            Controls.Add(Search);
            Controls.Add(EmployeeNo);
            Controls.Add(textBox1);
            Controls.Add(EmployeeLeaveRequest);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Leave_Request";
            Text = "Leave_Request";
            Load += Leave_Request_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button reject;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button EmployeeNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label EmployeeLeaveRequest;
        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox LID;
        private System.Windows.Forms.Button button2;
    }
}