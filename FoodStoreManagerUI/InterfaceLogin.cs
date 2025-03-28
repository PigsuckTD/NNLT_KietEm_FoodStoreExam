using FoodStoreManager_TuanKiet;
using Repositories.Entities;
using Services;

namespace FoodStoreManagerUI
{
    public partial class InterfaceLogin : Form
    {
        public InterfaceLogin()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult anwer = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (anwer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please iput both email and password!", "Input plz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserAccountServices services = new();
            UserAccount? acc = services.CheckLogin(txtEmail.Text, txtPassword.Text);

            if(acc == null)
            {
                MessageBox.Show("Login failed. Check the email and password again!", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //m? form chính 
            InterFaceUI f = new InterFaceUI();
            f.Show();
            this.Hide(); //?n form ??ng nh?p hi?n t?i 
        }
    }
}
