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
                        mealItem.SubItems.Add(meal.Price.ToString());
                        listView1.Items.Add(mealItem);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = mealNameBox.Text;
            decimal price = decimal.Parse(mealPriceBox.Text);
            if (controller.AddMeal(name, price))
            {
                MessageBox.Show("Meal added successfully");
                ListViewItem mealItem = new ListViewItem(name);
                mealItem.SubItems.Add(price.ToString());
                listView1.Items.Add(mealItem);
            }
            else MessageBox.Show("This meal already exists!\nTry again!");
        }

    }
}
