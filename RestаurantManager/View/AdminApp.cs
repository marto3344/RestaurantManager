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
        private Form activeForm;
        public AdminApp()
        {
            InitializeComponent();
            
        }

        private void AdminApp_Load(object sender, EventArgs e)
        {
            OpenContentForm(new AdminAppForms.AdminTables(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenContentForm(new AdminAppForms.MealsForm(), sender);
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

        //Button Hover animation
        private void TablesButton_Enter(object sender, EventArgs e)
        {
            //TablesButton.BackColor = Color.DeepSkyBlue;
        }

        private void TablesButton_Leave(object sender, EventArgs e)
        {
            //TablesButton.BackColor = Color.DeepSkyBlue;
        }

        private void MealsButton_Enter(object sender, EventArgs e)
        {
            //MealsButton.BackColor=Color.RoyalBlue;
        }

        private void MealsButton_Leave(object sender, EventArgs e)
        {
            //MealsButton.BackColor = Color.DeepSkyBlue;
        }

        private void ViewWaitersButton_Enter(object sender, EventArgs e)
        {
            //ViewWaitersButton.BackColor = Color.RoyalBlue;
        }

        private void ViewWaitersButton_Leave(object sender, EventArgs e)
        {
            //ViewWaitersButton.BackColor = Color.DeepSkyBlue;
        }

        private void ExitButton_Enter(object sender, EventArgs e)
        {
            //ExitButton.BackColor = Color.RoyalBlue;
        }

        private void ExitButton_Leave(object sender, EventArgs e)
        {
            //ExitButton.BackColor= Color.DeepSkyBlue;
        }

        private void SwitchAccountButton_Enter(object sender, EventArgs e)
        {
            //SwitchAccountButton.BackColor = Color.RoyalBlue;
        }

        private void SwitchAccountButton_Leave(object sender, EventArgs e)
        {
            //SwitchAccountButton.BackColor= Color.DeepSkyBlue;
        }
        private void OpenContentForm(Form contentForm,object btnSender)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = contentForm;
            contentForm.TopLevel=false;
            contentForm.FormBorderStyle= FormBorderStyle.None;
            contentForm.Dock = DockStyle.Fill;  
            this.contentPanel.Controls.Add(contentForm);
            this.contentPanel.Tag = contentForm;
            contentForm.BringToFront(); 
            contentForm.Show();

        }
        

        private void TablesButton_Click(object sender, EventArgs e)
        {
            OpenContentForm(new AdminAppForms.AdminTables(),sender);
        }

        private void ViewWaitersButton_Click(object sender, EventArgs e)
        {
            OpenContentForm(new AdminAppForms.AdminWaiters(),sender);
        }

       
    }
}
