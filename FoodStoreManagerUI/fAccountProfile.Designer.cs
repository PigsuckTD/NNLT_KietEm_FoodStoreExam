namespace FoodStoreManager_TuanKiet
{
    partial class fAccountProfile
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
            panel1 = new Panel();
            txtLogin = new TextBox();
            lblNameLogin = new Label();
            panel2 = new Panel();
            txtDisplay = new TextBox();
            lblDisplay = new Label();
            panel3 = new Panel();
            txtRestockPassword = new TextBox();
            lblRestockPassword = new Label();
            panel4 = new Panel();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            panel5 = new Panel();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnUpdate = new Button();
            btnCancle = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(lblNameLogin);
            panel1.Location = new Point(48, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 71);
            panel1.TabIndex = 0;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(239, 20);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(556, 35);
            txtLogin.TabIndex = 1;
            // 
            // lblNameLogin
            // 
            lblNameLogin.AutoSize = true;
            lblNameLogin.Location = new Point(27, 23);
            lblNameLogin.Name = "lblNameLogin";
            lblNameLogin.Size = new Size(151, 30);
            lblNameLogin.TabIndex = 0;
            lblNameLogin.Text = "Tên đăng nhập";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDisplay);
            panel2.Controls.Add(lblDisplay);
            panel2.Location = new Point(48, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(861, 71);
            panel2.TabIndex = 1;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(239, 20);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(556, 35);
            txtDisplay.TabIndex = 1;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(27, 23);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(121, 30);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "Tên hiển thị";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtRestockPassword);
            panel3.Controls.Add(lblRestockPassword);
            panel3.Location = new Point(51, 417);
            panel3.Name = "panel3";
            panel3.Size = new Size(861, 71);
            panel3.TabIndex = 2;
            // 
            // txtRestockPassword
            // 
            txtRestockPassword.Location = new Point(239, 20);
            txtRestockPassword.Name = "txtRestockPassword";
            txtRestockPassword.Size = new Size(556, 35);
            txtRestockPassword.TabIndex = 1;
            // 
            // lblRestockPassword
            // 
            lblRestockPassword.AutoSize = true;
            lblRestockPassword.Location = new Point(27, 23);
            lblRestockPassword.Name = "lblRestockPassword";
            lblRestockPassword.Size = new Size(91, 30);
            lblRestockPassword.TabIndex = 0;
            lblRestockPassword.Text = "Nhập lại";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtNewPassword);
            panel4.Controls.Add(lblNewPassword);
            panel4.Location = new Point(51, 315);
            panel4.Name = "panel4";
            panel4.Size = new Size(861, 71);
            panel4.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(239, 20);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(556, 35);
            txtNewPassword.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(27, 23);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(143, 30);
            lblNewPassword.TabIndex = 0;
            lblNewPassword.Text = "Mật khẩu mới";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtPassword);
            panel5.Controls.Add(lblPassword);
            panel5.Location = new Point(48, 219);
            panel5.Name = "panel5";
            panel5.Size = new Size(861, 71);
            panel5.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(239, 20);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(556, 35);
            txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(27, 23);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 30);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Mật khẩu";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(715, 531);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 53);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(558, 531);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(131, 53);
            btnCancle.TabIndex = 4;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = true;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancle;
            ClientSize = new Size(941, 628);
            Controls.Add(btnCancle);
            Controls.Add(btnUpdate);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAccountProfile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtLogin;
        private Label lblNameLogin;
        private Panel panel2;
        private TextBox txtDisplay;
        private Label lblDisplay;
        private Panel panel3;
        private TextBox txtRestockPassword;
        private Label lblRestockPassword;
        private Panel panel4;
        private TextBox txtNewPassword;
        private Label lblNewPassword;
        private Panel panel5;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnUpdate;
        private Button btnCancle;
    }
}