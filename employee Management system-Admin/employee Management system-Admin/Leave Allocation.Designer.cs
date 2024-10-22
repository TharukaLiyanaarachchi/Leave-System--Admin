namespace employee_management_admin_
{
    partial class Leave_Allocation
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
            RoID = new TextBox();
            RoasterID = new Button();
            Search = new Button();
            EmpID = new TextBox();
            EmployeeID = new Button();
            RoasterAllo = new Label();
            TotalAn = new Button();
            TotalCL = new TextBox();
            TotalAL = new TextBox();
            ToShortL = new Button();
            ToCas = new Button();
            Cancel = new Button();
            AddNew = new Button();
            Deactivate = new Button();
            TotalSL = new TextBox();
            LeaveAllocationDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)LeaveAllocationDetail).BeginInit();
            SuspendLayout();
            // 
            // RoID
            // 
            RoID.Location = new Point(190, 85);
            RoID.Margin = new Padding(3, 4, 3, 4);
            RoID.Name = "RoID";
            RoID.Size = new Size(100, 27);
            RoID.TabIndex = 112;
            // 
            // RoasterID
            // 
            RoasterID.Location = new Point(55, 85);
            RoasterID.Margin = new Padding(3, 4, 3, 4);
            RoasterID.Name = "RoasterID";
            RoasterID.Size = new Size(115, 29);
            RoasterID.TabIndex = 111;
            RoasterID.Text = "Leave ID";
            RoasterID.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            Search.Location = new Point(639, 76);
            Search.Margin = new Padding(3, 4, 3, 4);
            Search.Name = "Search";
            Search.Size = new Size(115, 46);
            Search.TabIndex = 110;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // EmpID
            // 
            EmpID.Location = new Point(523, 83);
            EmpID.Margin = new Padding(3, 4, 3, 4);
            EmpID.Name = "EmpID";
            EmpID.Size = new Size(100, 27);
            EmpID.TabIndex = 109;
            // 
            // EmployeeID
            // 
            EmployeeID.Location = new Point(384, 83);
            EmployeeID.Margin = new Padding(3, 4, 3, 4);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(115, 29);
            EmployeeID.TabIndex = 108;
            EmployeeID.Text = "Employee ID";
            EmployeeID.UseVisualStyleBackColor = true;
            // 
            // RoasterAllo
            // 
            RoasterAllo.AutoSize = true;
            RoasterAllo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoasterAllo.Location = new Point(248, 32);
            RoasterAllo.Name = "RoasterAllo";
            RoasterAllo.Size = new Size(251, 36);
            RoasterAllo.TabIndex = 107;
            RoasterAllo.Text = "Leave Allocation";
            // 
            // TotalAn
            // 
            TotalAn.Location = new Point(55, 148);
            TotalAn.Margin = new Padding(3, 4, 3, 4);
            TotalAn.Name = "TotalAn";
            TotalAn.Size = new Size(156, 29);
            TotalAn.TabIndex = 124;
            TotalAn.Text = "Total Annual Leave";
            TotalAn.UseVisualStyleBackColor = true;
            // 
            // TotalCL
            // 
            TotalCL.Location = new Point(299, 205);
            TotalCL.Margin = new Padding(3, 4, 3, 4);
            TotalCL.Name = "TotalCL";
            TotalCL.Size = new Size(100, 27);
            TotalCL.TabIndex = 123;
            // 
            // TotalAL
            // 
            TotalAL.Location = new Point(299, 150);
            TotalAL.Margin = new Padding(3, 4, 3, 4);
            TotalAL.Name = "TotalAL";
            TotalAL.Size = new Size(100, 27);
            TotalAL.TabIndex = 122;
            // 
            // ToShortL
            // 
            ToShortL.Location = new Point(55, 263);
            ToShortL.Margin = new Padding(3, 4, 3, 4);
            ToShortL.Name = "ToShortL";
            ToShortL.Size = new Size(156, 29);
            ToShortL.TabIndex = 121;
            ToShortL.Text = "Total Short Leave";
            ToShortL.UseVisualStyleBackColor = true;
            // 
            // ToCas
            // 
            ToCas.Location = new Point(55, 203);
            ToCas.Margin = new Padding(3, 4, 3, 4);
            ToCas.Name = "ToCas";
            ToCas.Size = new Size(156, 29);
            ToCas.TabIndex = 120;
            ToCas.Text = "Total Casual Leave";
            ToCas.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(55, 313);
            Cancel.Margin = new Padding(3, 4, 3, 4);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(115, 46);
            Cancel.TabIndex = 119;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // AddNew
            // 
            AddNew.Location = new Point(639, 307);
            AddNew.Margin = new Padding(3, 4, 3, 4);
            AddNew.Name = "AddNew";
            AddNew.Size = new Size(115, 52);
            AddNew.TabIndex = 118;
            AddNew.Text = "Add New";
            AddNew.UseVisualStyleBackColor = true;
            AddNew.Click += AddNew_Click;
            // 
            // Deactivate
            // 
            Deactivate.Location = new Point(494, 313);
            Deactivate.Margin = new Padding(3, 4, 3, 4);
            Deactivate.Name = "Deactivate";
            Deactivate.Size = new Size(114, 46);
            Deactivate.TabIndex = 117;
            Deactivate.Text = "Update";
            Deactivate.UseVisualStyleBackColor = true;
            Deactivate.Click += Deactivate_Click;
            // 
            // TotalSL
            // 
            TotalSL.Location = new Point(299, 263);
            TotalSL.Margin = new Padding(3, 4, 3, 4);
            TotalSL.Name = "TotalSL";
            TotalSL.Size = new Size(100, 27);
            TotalSL.TabIndex = 125;
            // 
            // LeaveAllocationDetail
            // 
            LeaveAllocationDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LeaveAllocationDetail.Location = new Point(55, 367);
            LeaveAllocationDetail.Margin = new Padding(3, 4, 3, 4);
            LeaveAllocationDetail.Name = "LeaveAllocationDetail";
            LeaveAllocationDetail.RowHeadersWidth = 51;
            LeaveAllocationDetail.RowTemplate.Height = 24;
            LeaveAllocationDetail.Size = new Size(699, 188);
            LeaveAllocationDetail.TabIndex = 126;
            // 
            // Leave_Allocation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(LeaveAllocationDetail);
            Controls.Add(TotalSL);
            Controls.Add(TotalAn);
            Controls.Add(TotalCL);
            Controls.Add(TotalAL);
            Controls.Add(ToShortL);
            Controls.Add(ToCas);
            Controls.Add(Cancel);
            Controls.Add(AddNew);
            Controls.Add(Deactivate);
            Controls.Add(RoID);
            Controls.Add(RoasterID);
            Controls.Add(Search);
            Controls.Add(EmpID);
            Controls.Add(EmployeeID);
            Controls.Add(RoasterAllo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Leave_Allocation";
            Text = "Leave_Allocation";
            ((System.ComponentModel.ISupportInitialize)LeaveAllocationDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox RoID;
        private System.Windows.Forms.Button RoasterID;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox EmpID;
        private System.Windows.Forms.Button EmployeeID;
        private System.Windows.Forms.Label RoasterAllo;
        private System.Windows.Forms.Button TotalAn;
        private System.Windows.Forms.TextBox TotalCL;
        private System.Windows.Forms.TextBox TotalAL;
        private System.Windows.Forms.Button ToShortL;
        private System.Windows.Forms.Button ToCas;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button Deactivate;
        private System.Windows.Forms.TextBox TotalSL;
        private System.Windows.Forms.DataGridView LeaveAllocationDetail;
    }
}