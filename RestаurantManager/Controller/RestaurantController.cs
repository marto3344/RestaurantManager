using RestаurantManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace RestаurantManager.Controller
{
    public class RestaurantController
    {
        private MySqlConnection dbCon = new MySqlConnection(DBConnection.GetConnectionString());
        public  bool AddMeal(string name,decimal price)
        {
            using (dbCon)
            {
                try
                {
                    dbCon.Open();
                    string sql = "SELECT*FROM meal";
                    var cmd = new MySqlCommand(sql, dbCon);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<Meal> meals = new List<Meal>();
                    while (rdr.Read())
                    {
                        meals.Add(new Meal(rdr.GetString(1),rdr.GetDecimal(2)));
                    }
                    foreach (var meal in meals)
                    {
                        if(meal.Name.ToLower()==name.ToLower())
                        {
                            return false;
                        }
                    }
                    rdr.Close();
                    cmd.CommandText = $"INSERT INTO meal (name,price) values(\"{name}\",{price})";
                    cmd.ExecuteNonQuery();
                    dbCon.Close();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }
    }
}
