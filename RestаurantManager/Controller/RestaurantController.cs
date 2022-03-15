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
        public bool RemoveMeal(string name)
        {
            using (dbCon)
            {
                try
                {
                    dbCon.Open();
                    string sql = $"DELETE FROM meal WHERE name =\"{name}\"";
                    var cmd = new MySqlCommand(sql,dbCon);
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
        public bool EditMeal(string name,decimal price,string newName,decimal newPrice)
        {
            using(dbCon)
            {
                try
                {
                    dbCon.Open();
                    string sql = $"SELECT id FROM meal  WHERE name=\"{name}\"";
                    var cmd=new MySqlCommand(sql,dbCon);
                    var rdr=cmd.ExecuteReader();
                    int mealId = 0;
                    while (rdr.Read())
                    {
                        mealId = rdr.GetInt32(0);
                    }
                    Console.WriteLine(mealId);
                    rdr.Close();
                    cmd.CommandText = $"UPDATE meal SET name=\"{newName}\", price={newPrice} WHERE id={mealId}";
                    cmd.ExecuteNonQuery();
                    dbCon.Close();
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    return false;               
                }
            }
        }
    }
}
