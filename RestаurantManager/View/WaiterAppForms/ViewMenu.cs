using MySql.Data.MySqlClient;
using RestаurantManager.Controller;
using RestаurantManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestаurantManager.View.WaiterAppForms
{
    public partial class ViewMenu : Form
    {
        RestaurantController controller = new RestaurantController();
        MySqlConnection dbCon = new MySqlConnection(DBConnection.GetConnectionString());
        public ViewMenu()
        {
            InitializeComponent();
        }

        private void ViewMenu_Load(object sender, EventArgs e)
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
                        menuList.Items.Add(mealItem);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
