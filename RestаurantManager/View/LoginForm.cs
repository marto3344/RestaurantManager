using RestаurantManager.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestаurantManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void WaiterButton_Click(object sender, EventArgs e)
        {
            this.Hide();        
            WaiterLogin waiterForm=new WaiterLogin();  
            waiterForm.Show();
        }
    }
}
