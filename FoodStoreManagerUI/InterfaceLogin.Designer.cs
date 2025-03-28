namespace FoodStoreManagerUI
{
    partial class InterfaceLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceLogin));
            btnLogin = new Button();
            btnCancle = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(1016, 474);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 40);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.White;
            btnCancle.FlatStyle = FlatStyle.Flat;
            btnCancle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancle.ForeColor = Color.Black;
            btnCancle.Location = new Point(870, 474);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(131, 40);
            btnCancle.TabIndex = 1;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(819, 333);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(378, 40);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.White;
            lblEmail.FlatStyle = FlatStyle.Flat;
            lblEmail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(684, 336);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(92, 32);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.FlatStyle = FlatStyle.Flat;
            lblPassword.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(684, 415);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(129, 32);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(819, 412);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(378, 40);
            txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(918, 245);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 8;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("SimSun-ExtB", 26.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(739, 235);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(411, 61);
            lblLogin.TabIndex = 9;
            lblLogin.Text = "PLEASE LOGIN";
            // 
            // InterfaceLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnCancle;
            ClientSize = new Size(1209, 1032);
            Controls.Add(lblLogin);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnCancle);
            Controls.Add(btnLogin);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "InterfaceLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JoLLiKEm_LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnCancle;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label label1;
        private Label lblLogin;
    }
}
