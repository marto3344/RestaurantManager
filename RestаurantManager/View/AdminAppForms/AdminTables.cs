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
    public partial class AdminTables : Form
    {
        RestaurantController controller = new RestaurantController();
        MySqlConnection dbCon = new MySqlConnection(DBConnection.GetConnectionString());
        public AdminTables()
        {
            InitializeComponent();
            using (dbCon)
            {
                try
                {
                    dbCon.Open();
                    Table table;
                    string sql = "SELECT*FROM diner_table";
                    var cmd = new MySqlCommand(sql, dbCon);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        table = new Table(rdr.GetString(1));
                        ListViewItem tableItem = new ListViewItem(table.Name);
                        tableList.Items.Add(tableItem);
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

        private void addTableButton_Click(object sender, EventArgs e)
        {
            string name = tableNameBox.Text;
            if (tableNameBox.Text == null)
            {
                MessageBox.Show("Insert table name!");
                return;
            }
            else
            {
                if (controller.AddTable(name))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = name;
                    tableList.Items.Add(item);
                    tableNameBox.Clear();
                    MessageBox.Show($"Successfully added {name}!");
                }
                else
                {
                    MessageBox.Show("Error \n This table already exists!");
                }
            }
        }

        private void removeTableButton_Click(object sender, EventArgs e)
        {
            if (tableList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Table!");
                return;
            }
            string removedTableName = tableList.SelectedItems[0].Text;
            DialogResult confirmRemoveBox = MessageBox.Show($"Are you sure you want to remove {removedTableName}?", "Remove meal?", MessageBoxButtons.OKCancel);
            if (confirmRemoveBox == DialogResult.OK)
            {
                if (controller.RemoveTable(removedTableName))
                {
                    tableList.SelectedItems[0].Remove();
                    MessageBox.Show($"{removedTableName} was removed successfully!");
                }
                else MessageBox.Show("Error! \n Table was not removed!");
            }
        }

        private void confirmEditButton_Click(object sender, EventArgs e)
        {
            string preEditedName = tableList.SelectedItems[0].Text;
            string newName = tableNameBox.Text;
            if (newName == "")
            {
                MessageBox.Show("Please enter valid name!");
            }
            else
            {
                if (controller.EditTable(preEditedName, newName))
                {
                    tableList.SelectedItems[0].Text = newName;
                    confirmEditButton.Visible = false;
                    addTableButton.BringToFront();
                    tableNameBox.Clear();
                    addTableBox.Text = "Add meal";
                    MessageBox.Show($"Successfully edited {preEditedName} to {newName}!");

                }
                else MessageBox.Show($"Error \n {preEditedName} was not edited!\n Please try again!");
            }
        }

        private void editMealButton_Click(object sender, EventArgs e)
        {
            if (tableList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select Table!");
                return;
            }
            MessageBox.Show($"Please edit {tableList.SelectedItems[0].Text} in Add Table panel!");
            addTableBox.Text = "Edit Table";
            confirmEditButton.Visible = true;
            confirmEditButton.BringToFront();
            tableNameBox.Text = tableList.SelectedItems[0].Text;
        }
    }
}
