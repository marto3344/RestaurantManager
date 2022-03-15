using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RestаurantManager.Controller;
using RestаurantManager.Model;

namespace RestаurantManager.View.AdminAppForms
{
    public partial class AdminWaiters : Form
    {
        RestaurantController controller = new RestaurantController();
        MySqlConnection dbCon = new MySqlConnection(DBConnection.GetConnectionString());
        public AdminWaiters()
        {
            InitializeComponent();
            using (dbCon)
            {
                try
                {
                    dbCon.Open();
                    Waiter waiter;
                    string sql = "SELECT*FROM waiter";
                    var cmd = new MySqlCommand(sql, dbCon);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        waiter = new Waiter( rdr.GetString(1), rdr.GetString(2), rdr.GetDecimal(3));
                        ListViewItem waiterItem = new ListViewItem(waiter.Name);
                        waiterItem.SubItems.Add(waiter.Password);
                        waiterItem.SubItems.Add($"{waiter.Salary:f2} lv.");
                        waitersList.Items.Add(waiterItem);
                    }
                    rdr.Close();
                    dbCon.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void addWaiterButton_Click(object sender, EventArgs e)
        {
            string name = waiterNameBox.Text;
            decimal salary = decimal.Parse(waiterSalaryBox.Text);
            string password=waiterPasswordBox.Text; 
            if (controller.AddWaiter(name,password,salary))
            {
                ListViewItem waiterItem = new ListViewItem(name);
                waiterItem.SubItems.Add(password);
                waiterItem.SubItems.Add($"{salary:f2} lv.");
                waitersList.Items.Add(waiterItem);
                waiterNameBox.Clear();
                waiterPasswordBox.Clear();
                waiterSalaryBox.Clear();
                MessageBox.Show("Waiter added successfully");
            }
            else MessageBox.Show("Waiter with this name already exists!\nTry again!");
        }

        private void removeWaiterButton_Click(object sender, EventArgs e)
        {
            if (waitersList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select Waiter!");
                return;
            }
            string removedWaiterName = waitersList.SelectedItems[0].Text;
            DialogResult confirmRemoveBox = MessageBox.Show($"Are you sure you want to remove {removedWaiterName}?", "Remove waiter?", MessageBoxButtons.OKCancel);
            if (confirmRemoveBox == DialogResult.OK)
            {
                if (controller.RemoveWaiter(removedWaiterName))
                {
                    waitersList.SelectedItems[0].Remove();
                    MessageBox.Show($"{removedWaiterName} was removed successfully!");
                }
                else MessageBox.Show("Error! \n Waiter was not removed!");
            }
        }

        private void editWaiterButton_Click(object sender, EventArgs e)
        {
            if (waitersList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Waiter!");
                return;
            }
            MessageBox.Show($"Please edit {waitersList.SelectedItems[0].Text} in Add Waiter panel!");
            addWaiterBox.Text = "Edit Waiter";
            confirmEditButton.Visible = true;
            confirmEditButton.BringToFront();
            waiterNameBox.Text = waitersList.SelectedItems[0].Text;
            waiterSalaryBox.Text = waitersList.SelectedItems[0].SubItems[2].Text.Split(' ').First();
            waiterPasswordBox.Text = waitersList.SelectedItems[0].SubItems[1].Text;
        }

        private void confirmEditButton_Click(object sender, EventArgs e)
        {
            string preEditedName = waitersList.SelectedItems[0].Text;
            string[] salaryColumn = waitersList.SelectedItems[0].SubItems[2].Text.Split(' ').ToArray();
            decimal preEditedSalary = decimal.Parse(salaryColumn[0]);
            string preEditedPassword = waitersList.SelectedItems[0].SubItems[1].Text;

            string newName = waiterNameBox.Text;           
            string newPassword = waiterPasswordBox.Text;
            decimal newSalary = decimal.Parse(waiterSalaryBox.Text);
            
            if (newName == "" || newSalary <= 0 || waiterSalaryBox.Text == "")
            {
                MessageBox.Show("Please enter valid values!");
            }
            else
            {
                if (controller.EditWaiter(preEditedName, preEditedPassword,preEditedSalary, newName, newPassword,newSalary))
                {
                    waitersList.SelectedItems[0].Text = newName;
                    waitersList.SelectedItems[0].SubItems[2].Text = $"{newSalary:f2} lv.";
                    confirmEditButton.Visible = false;
                    addWaiterButton.BringToFront();
                    waiterNameBox.Clear();
                    waiterPasswordBox.Clear();
                    waiterSalaryBox.Clear();
                    addWaiterBox.Text = "Add waiter to the system";
                    MessageBox.Show($"Successfully edited {preEditedName}");

                }
                else MessageBox.Show($"Error \n {preEditedName} was not edited!");
            }
        }
    }
}
