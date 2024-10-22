namespace employee_management_admin_
{
    partial class Individual_Employee_Leave_History
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
            LeaveHistoryReport = new Label();
            Empid = new TextBox();
            EmployeeNo = new Button();
            LevaeHistory = new DataGridView();
            Cancel = new Button();
            Search = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)LevaeHistory).BeginInit();
            SuspendLayout();
            // 
            // LeaveHistoryReport
            // 
            LeaveHistoryReport.AutoSize = true;
            LeaveHistoryReport.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LeaveHistoryReport.Location = new Point(232, 49);
            LeaveHistoryReport.Name = "LeaveHistoryReport";
            LeaveHistoryReport.Size = new Size(314, 36);
            LeaveHistoryReport.TabIndex = 97;
            LeaveHistoryReport.Text = "Leave History Report";
            LeaveHistoryReport.Click += IndividualLeaveHistoryReport_Click;
            // 
            // Empid
            // 
            Empid.Location = new Point(232, 130);
            Empid.Margin = new Padding(3, 4, 3, 4);
            Empid.Name = "Empid";
            Empid.Size = new Size(116, 27);
            Empid.TabIndex = 107;
            // 
            // EmployeeNo
            // 
            EmployeeNo.Location = new Point(32, 128);
            EmployeeNo.Margin = new Padding(3, 4, 3, 4);
            EmployeeNo.Name = "EmployeeNo";
            EmployeeNo.Size = new Size(115, 29);
            EmployeeNo.TabIndex = 106;
            EmployeeNo.Text = "Employee No";
            EmployeeNo.UseVisualStyleBackColor = true;
            // 
            // LevaeHistory
            // 
            LevaeHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LevaeHistory.Location = new Point(32, 296);
            LevaeHistory.Margin = new Padding(3, 4, 3, 4);
            LevaeHistory.Name = "LevaeHistory";
            LevaeHistory.RowHeadersWidth = 51;
            LevaeHistory.RowTemplate.Height = 24;
            LevaeHistory.Size = new Size(743, 241);
            LevaeHistory.TabIndex = 108;
            LevaeHistory.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(32, 217);
            Cancel.Margin = new Padding(3, 4, 3, 4);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(138, 52);
            Cancel.TabIndex = 109;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Search
            // 
            Search.Location = new Point(459, 217);
            Search.Margin = new Padding(3, 4, 3, 4);
            Search.Name = "Search";
            Search.Size = new Size(138, 52);
            Search.TabIndex = 110;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // button1
            // 
            button1.Location = new Point(637, 217);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(138, 52);
            button1.TabIndex = 111;
            button1.Text = "Genarate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Individual_Employee_Leave_History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(button1);
            Controls.Add(Search);
            Controls.Add(Cancel);
            Controls.Add(LevaeHistory);
            Controls.Add(Empid);
            Controls.Add(EmployeeNo);
            Controls.Add(LeaveHistoryReport);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Individual_Employee_Leave_History";
            Text = "Individual_Employee_Leave_History";
            ((System.ComponentModel.ISupportInitialize)LevaeHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label LeaveHistoryReport;
        private System.Windows.Forms.TextBox Empid;
        private System.Windows.Forms.Button EmployeeNo;
        private System.Windows.Forms.DataGridView LevaeHistory;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Search;
        private Button button1;
    }
}