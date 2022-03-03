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
    public partial class AdminApp : Form
    {
        public AdminApp()
        {
            InitializeComponent();
        }

        private void AdminApp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MealsButton_MouseHover(object sender, EventArgs e)
        {
            MealsButton.BackColor = Color.RoyalBlue;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmExitBox = MessageBox.Show("Are you sure you want to exit application?", "Exit?", MessageBoxButtons.OKCancel);
            if (confirmExitBox==DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void SwitchAccountButton_Click(object sender, EventArgs e)
        {
            DialogResult switchAccounttBox = MessageBox.Show("Are you sure you want to switch account?", "Switch account?", MessageBoxButtons.OKCancel);
            if (switchAccounttBox == DialogResult.OK)
            {
                LoginForm loginForm=new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }
    }
}
