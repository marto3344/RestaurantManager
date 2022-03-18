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
        private Form activeForm;

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

        private void WaiterApp_Load(object sender, EventArgs e)
        {
            OpenContentForm(new WaiterAppForms.TablesForm(),sender);
        }
        private void OpenContentForm(Form contentForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = contentForm;
            contentForm.TopLevel = false;
            contentForm.FormBorderStyle = FormBorderStyle.None;
            contentForm.Dock = DockStyle.Fill;
            this.contentPanel.Controls.Add(contentForm);
            this.contentPanel.Tag = contentForm;
            contentForm.BringToFront();
            contentForm.Show();

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            OpenContentForm(new WaiterAppForms.ViewMenu(),sender);
        }

        private void TablesButton_Click(object sender, EventArgs e)
        {
            OpenContentForm(new WaiterAppForms.TablesForm(),sender);
        }

        private void ViewSalaryButton_Click(object sender, EventArgs e)
        {
            OpenContentForm(new WaiterAppForms.ViewSalaryForm(),sender);
        }
    }
}
