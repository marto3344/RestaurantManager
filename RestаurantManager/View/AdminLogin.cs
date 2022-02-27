using RestаurantManager.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestаurantManager.View
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            string adminName = AdminNameBox.Text;
            string adminPassword = AdminPasswordBox.Text;
            if(UserAuthenticationService.CheckAdminLogin(adminName, adminPassword))
            {
                this.Hide();
                MessageBox.Show("Successful login as admin");
            }
            else
            {
                MessageBox.Show("Invalid username or password!\nPlease chack your login information and try again");
            }

        }
        
        
    }
}
