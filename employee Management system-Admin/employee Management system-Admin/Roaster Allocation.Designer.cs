namespace employee_management_admin_
{
    partial class Roaster_Allocation
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
            dataGridView1 = new DataGridView();
            ROTime = new TextBox();
            Date = new Button();
            RInTime = new TextBox();
            RDate = new TextBox();
            OutTime = new Button();
            Intime = new Button();
            Cancel = new Button();
            AddNew = new Button();
            Search = new Button();
            EmpID = new TextBox();
            EmployeeID = new Button();
            RoasterAllo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 362);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(699, 188);
            dataGridView1.TabIndex = 142;
            // 
            // ROTime
            // 
            ROTime.Location = new Point(276, 250);
            ROTime.Margin = new Padding(3, 4, 3, 4);
            ROTime.Name = "ROTime";
            ROTime.Size = new Size(100, 27);
            ROTime.TabIndex = 141;
            // 
            // Date
            // 
            Date.Location = new Point(51, 146);
            Date.Margin = new Padding(3, 4, 3, 4);
            Date.Name = "Date";
            Date.Size = new Size(156, 29);
            Date.TabIndex = 140;
            Date.Text = "Date";
            Date.UseVisualStyleBackColor = true;
            // 
            // RInTime
            // 
            RInTime.Location = new Point(276, 199);
            RInTime.Margin = new Padding(3, 4, 3, 4);
            RInTime.Name = "RInTime";
            RInTime.Size = new Size(100, 27);
            RInTime.TabIndex = 139;
            // 
            // RDate
            // 
            RDate.Location = new Point(276, 146);
            RDate.Margin = new Padding(3, 4, 3, 4);
            RDate.Name = "RDate";
            RDate.Size = new Size(100, 27);
            RDate.TabIndex = 138;
            // 
            // OutTime
            // 
            OutTime.AutoEllipsis = true;
            OutTime.Location = new Point(51, 250);
            OutTime.Margin = new Padding(3, 4, 3, 4);
            OutTime.Name = "OutTime";
            OutTime.Size = new Size(156, 29);
            OutTime.TabIndex = 137;
            OutTime.Text = "Out Time";
            OutTime.UseVisualStyleBackColor = true;
            // 
            // Intime
            // 
            Intime.Location = new Point(51, 198);
            Intime.Margin = new Padding(3, 4, 3, 4);
            Intime.Name = "Intime";
            Intime.Size = new Size(156, 29);
            Intime.TabIndex = 136;
            Intime.Text = "In Time";
            Intime.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(51, 298);
            Cancel.Margin = new Padding(3, 4, 3, 4);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(142, 58);
            Cancel.TabIndex = 135;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // AddNew
            // 
            AddNew.Location = new Point(616, 298);
            AddNew.Margin = new Padding(3, 4, 3, 4);
            AddNew.Name = "AddNew";
            AddNew.Size = new Size(134, 56);
            AddNew.TabIndex = 134;
            AddNew.Text = "Add New";
            AddNew.UseVisualStyleBackColor = true;
            AddNew.Click += AddNew_Click;
            // 
            // Search
            // 
            Search.Location = new Point(502, 60);
            Search.Margin = new Padding(3, 4, 3, 4);
            Search.Name = "Search";
            Search.Size = new Size(112, 39);
            Search.TabIndex = 130;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // EmpID
            // 
            EmpID.Location = new Point(276, 72);
            EmpID.Margin = new Padding(3, 4, 3, 4);
            EmpID.Name = "EmpID";
            EmpID.Size = new Size(100, 27);
            EmpID.TabIndex = 129;
            // 
            // EmployeeID
            // 
            EmployeeID.Location = new Point(51, 71);
            EmployeeID.Margin = new Padding(3, 4, 3, 4);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(115, 29);
            EmployeeID.TabIndex = 128;
            EmployeeID.Text = "Employee ID";
            EmployeeID.UseVisualStyleBackColor = true;
            // 
            // RoasterAllo
            // 
            RoasterAllo.AutoSize = true;
            RoasterAllo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoasterAllo.Location = new Point(224, 12);
            RoasterAllo.Name = "RoasterAllo";
            RoasterAllo.Size = new Size(277, 36);
            RoasterAllo.TabIndex = 127;
            RoasterAllo.Text = "Roaster Allocation";
            // 
            // Roaster_Allocation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(dataGridView1);
            Controls.Add(ROTime);
            Controls.Add(Date);
            Controls.Add(RInTime);
            Controls.Add(RDate);
            Controls.Add(OutTime);
            Controls.Add(Intime);
            Controls.Add(Cancel);
            Controls.Add(AddNew);
            Controls.Add(Search);
            Controls.Add(EmpID);
            Controls.Add(EmployeeID);
            Controls.Add(RoasterAllo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Roaster_Allocation";
            Text = "Roaster_Allocation";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ROTime;
        private System.Windows.Forms.Button Date;
        private System.Windows.Forms.TextBox RInTime;
        private System.Windows.Forms.TextBox RDate;
        private System.Windows.Forms.Button OutTime;
        private System.Windows.Forms.Button Intime;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox EmpID;
        private System.Windows.Forms.Button EmployeeID;
        private System.Windows.Forms.Label RoasterAllo;
    }
}