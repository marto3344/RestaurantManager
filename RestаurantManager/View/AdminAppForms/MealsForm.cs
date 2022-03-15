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
    public partial class MealsForm : Form
    {
        private MySqlConnection dbCon = new MySqlConnection(DBConnection.GetConnectionString());
        private RestaurantController controller = new RestaurantController();

        public MealsForm()
        {
            InitializeComponent();
            
        }

        private void removeMealButton_Click(object sender, EventArgs e)
        {

        }

        private void mealPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MealsForm_Load(object sender, EventArgs e)
        {
            using (dbCon)
            {
                try
                {
                    dbCon.Open();
                    Meal meal;
                    string sql = "SELECT*FROM meal";
                    var cmd = new MySqlCommand(sql, dbCon);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        meal = new Meal(rdr.GetString(1), rdr.GetDecimal(2));
                        ListViewItem mealItem = new ListViewItem(meal.Name);
                        mealItem.SubItems.Add($"{meal.Price:f2} lv.");
                        listView1.Items.Add(mealItem);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//Add meal button
        {
            string name = mealNameBox.Text;
            decimal price = decimal.Parse(mealPriceBox.Text);
            Console.WriteLine(price);
            if (controller.AddMeal(name, price))
            {
                ListViewItem mealItem = new ListViewItem(name);
                mealItem.SubItems.Add($"{price:f2} lv.");
                listView1.Items.Add(mealItem);
                mealNameBox.Clear();
                mealPriceBox.Clear();
                MessageBox.Show("Meal added successfully");
            }
            else MessageBox.Show("This meal already exists!\nTry again!");

        }

        private void removeMealButton_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Meal!");
                return;
            }
            string removedMealName = listView1.SelectedItems[0].Text;
            DialogResult confirmRemoveBox = MessageBox.Show($"Are you sure you want to remove {removedMealName}?", "Remove meal?", MessageBoxButtons.OKCancel);
            if (confirmRemoveBox == DialogResult.OK)
            {
                if (controller.RemoveMeal(removedMealName))
                {
                    listView1.SelectedItems[0].Remove();
                    MessageBox.Show($"{removedMealName} was removed successfully!");
                }
                else MessageBox.Show("Error! \n Meal was not removed!");
            }
        }

        private void editMealButton_Click(object sender, EventArgs e)
        {
         
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Meal!");
                return;
            }
            MessageBox.Show($"Please edit {listView1.SelectedItems[0].Text} in Add Meal panel!");
            addMealBox.Text = "Edit Meal";
            confirmEditButton.Visible = true;
            confirmEditButton.BringToFront();
            mealNameBox.Text = listView1.SelectedItems[0].Text;
            mealPriceBox.Text = listView1.SelectedItems[0].SubItems[1].Text.Split(' ').First();
        }

        private void confirmEditButton_Click(object sender, EventArgs e)
        {
            string preEditedName = listView1.SelectedItems[0].Text;
            string[] priceColumn = listView1.SelectedItems[0].SubItems[1].Text.Split(' ').ToArray();
            decimal preEditedPrice = decimal.Parse(priceColumn[0]);
            string newName = mealNameBox.Text;
            decimal newPrice = decimal.Parse(mealPriceBox.Text);
            if (newName == "" || newPrice <= 0 || mealPriceBox.Text == "")
            {
                MessageBox.Show("Please enter valid values!");
            }
            else
            {
                if (controller.EditMeal(preEditedName, preEditedPrice, newName, newPrice))
                {
                    listView1.SelectedItems[0].Text = newName;
                    listView1.SelectedItems[0].SubItems[1].Text = $"{newPrice:f2} lv.";
                    confirmEditButton.Visible = false;
                    button2.BringToFront();
                    mealNameBox.Clear();
                    mealPriceBox.Clear();
                    addMealBox.Text = "Add meal";
                    MessageBox.Show($"Successfully edited {preEditedName} {preEditedPrice:f2} lv. to {newName} {newPrice:f2} lv. !");

                }
                else MessageBox.Show($"Error \n {preEditedName} was not edited!");
            }
        }
    }

}
