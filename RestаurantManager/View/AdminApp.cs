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
            TablesButton.MouseEnter += TablesButton_Enter;
            TablesButton.MouseLeave += TablesButton_Leave;
            MealsButton.MouseEnter += MealsButton_Enter;
            MealsButton.MouseLeave += MealsButton_Leave;
            ViewWaitersButton.MouseEnter += ViewWaitersButton_Enter;
            ViewWaitersButton.MouseLeave += ViewWaitersButton_Leave;
            ExitButton.MouseEnter += ExitButton_Enter;
            ExitButton.MouseLeave += ExitButton_Leave;
            SwitchAccountButton.MouseEnter += SwitchAccountButton_Enter;
            SwitchAccountButton.MouseLeave += SwitchAccountButton_Leave;
        }

        private void AdminApp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MealsButton_MouseHover(object sender, EventArgs e)
        {
           // MealsButton.BackColor = Color.RoyalBlue;
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

        private void TablesButton_Enter(object sender, EventArgs e)
        {
            TablesButton.BackColor = Color.RoyalBlue;
        }

        private void TablesButton_Leave(object sender, EventArgs e)
        {
            TablesButton.BackColor = Color.DeepSkyBlue;
        }

        private void MealsButton_Enter(object sender, EventArgs e)
        {
            MealsButton.BackColor=Color.RoyalBlue;
        }

        private void MealsButton_Leave(object sender, EventArgs e)
        {
            MealsButton.BackColor = Color.DeepSkyBlue;
        }

        private void ViewWaitersButton_Enter(object sender, EventArgs e)
        {
            ViewWaitersButton.BackColor = Color.RoyalBlue;
        }

        private void ViewWaitersButton_Leave(object sender, EventArgs e)
        {
            ViewWaitersButton.BackColor = Color.DeepSkyBlue;
        }

        private void ExitButton_Enter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.RoyalBlue;
        }

        private void ExitButton_Leave(object sender, EventArgs e)
        {
            ExitButton.BackColor= Color.DeepSkyBlue;
        }

        private void SwitchAccountButton_Enter(object sender, EventArgs e)
        {
            SwitchAccountButton.BackColor = Color.RoyalBlue;
        }

        private void SwitchAccountButton_Leave(object sender, EventArgs e)
        {
            SwitchAccountButton.BackColor= Color.DeepSkyBlue;
        }
    }
}
