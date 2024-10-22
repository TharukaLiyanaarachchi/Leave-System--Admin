namespace employee_management_admin_
{
    partial class Form1
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
            PW = new TextBox();
            Password = new Button();
            AdminUsername = new TextBox();
            EmployeeNo = new Button();
            Exit = new Button();
            Login = new Button();
            Clear = new Button();
            AdminUser = new Label();
            SuspendLayout();
            // 
            // PW
            // 
            PW.Location = new Point(407, 214);
            PW.Margin = new Padding(3, 4, 3, 4);
            PW.Name = "PW";
            PW.Size = new Size(100, 27);
            PW.TabIndex = 23;
            // 
            // Password
            // 
            Password.Location = new Point(231, 214);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Name = "Password";
            Password.Size = new Size(115, 29);
            Password.TabIndex = 22;
            Password.Text = "Password";
            Password.UseVisualStyleBackColor = true;
            // 
            // AdminUsername
            // 
            AdminUsername.ForeColor = Color.Black;
            AdminUsername.Location = new Point(407, 165);
            AdminUsername.Margin = new Padding(3, 4, 3, 4);
            AdminUsername.Name = "AdminUsername";
            AdminUsername.Size = new Size(100, 27);
            AdminUsername.TabIndex = 21;
            AdminUsername.TextChanged += EmployeeNumber_TextChanged;
            // 
            // EmployeeNo
            // 
            EmployeeNo.Location = new Point(231, 165);
            EmployeeNo.Margin = new Padding(3, 4, 3, 4);
            EmployeeNo.Name = "EmployeeNo";
            EmployeeNo.Size = new Size(115, 29);
            EmployeeNo.TabIndex = 20;
            EmployeeNo.Text = "User Name";
            EmployeeNo.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.Location = new Point(57, 434);
            Exit.Margin = new Padding(3, 4, 3, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(132, 52);
            Exit.TabIndex = 19;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Login
            // 
            Login.Location = new Point(407, 296);
            Login.Margin = new Padding(3, 4, 3, 4);
            Login.Name = "Login";
            Login.Size = new Size(129, 49);
            Login.TabIndex = 18;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(214, 296);
            Clear.Margin = new Padding(3, 4, 3, 4);
            Clear.Name = "Clear";
            Clear.Size = new Size(132, 49);
            Clear.TabIndex = 17;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // AdminUser
            // 
            AdminUser.AutoSize = true;
            AdminUser.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminUser.Location = new Point(259, 52);
            AdminUser.Name = "AdminUser";
            AdminUser.Size = new Size(238, 46);
            AdminUser.TabIndex = 7;
            AdminUser.Text = "Admin User";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(PW);
            Controls.Add(Password);
            Controls.Add(AdminUsername);
            Controls.Add(EmployeeNo);
            Controls.Add(Exit);
            Controls.Add(Login);
            Controls.Add(Clear);
            Controls.Add(AdminUser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.Button Password;
        private System.Windows.Forms.TextBox AdminUsername;
        private System.Windows.Forms.Button EmployeeNo;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label AdminUser;
    }
}

