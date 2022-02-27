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
    public partial class WaiterLogin : Form
    {
        public WaiterLogin()
        {
            InitializeComponent();
        }

        private void WaiterLogin_Activated(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            ActiveForm.Hide();
            loginForm.Show();
        }
    }
}
