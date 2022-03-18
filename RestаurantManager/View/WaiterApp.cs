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
    public partial class WaiterApp : Form
    {
        public WaiterApp()
        {
            InitializeComponent();
        }

        private void SwitchAccountButton_Click(object sender, EventArgs e)
        {
            DialogResult switchAccounttBox = MessageBox.Show($"Are you sure you want to switch account? \n Your orders will be lost!", "Switch account?", MessageBoxButtons.OKCancel);
            if (switchAccounttBox == DialogResult.OK)
            {
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmExitBox = MessageBox.Show("Are you sure you want to exit application?\n Your orders will be lost!", "Exit?", MessageBoxButtons.OKCancel);
            if (confirmExitBox == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
