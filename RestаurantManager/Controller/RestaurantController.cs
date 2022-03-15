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
        public bool AddMeal(string name, decimal price)
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
                        meals.Add(new Meal(rdr.GetString(1), rdr.GetDecimal(2)));
                    }
                    foreach (var meal in meals)
                    {
                        if (meal.Name.ToLower() == name.ToLower())
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
                    var cmd = new MySqlCommand(sql, dbCon);
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
        public bool EditMeal(string name, decimal price, string newName, decimal newPrice)
        {
            using (dbCon)
            {
                try
                {
                    dbCon.Open();
                    string sql = $"SELECT id FROM meal  WHERE name=\"{name}\"";
                    var cmd = new MySqlCommand(sql, dbCon);
                    var rdr = cmd.ExecuteReader();
                    int mealId = 0;
                    while (rdr.Read())
                    {
                        mealId = rdr.GetInt32(0);
                    }
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
        public bool AddTable(string name)
        {
            using (dbCon)
            {
                try
                {
                    dbCon.Open();
                    string sql = "SELECT*FROM waiter";
                    var cmd = new MySqlCommand(sql, dbCon);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<Table> tables = new List<Table>();
                    while (rdr.Read())
                    {
                        tables.Add(new Table(rdr.GetString(1)));
                    }
                    foreach (var table in tables)
                    {
                        if (table.Name.ToLower() == name.ToLower())
                        {
                            return false;
                        }
                    }
                    rdr.Close();
                    cmd.CommandText = $"INSERT INTO diner_table (name) values(\"{name}\")";
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
        public bool RemoveTable(string name)
        {
            using (dbCon)
            {
                try
                {
                    dbCon.Open();
                    string sql = $"DELETE FROM diner_table WHERE name =\"{name}\"";
                    var cmd = new MySqlCommand(sql, dbCon);
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
        public bool EditTable(string name, string newName)
        {
            using(dbCon)
            {
                try
                {
                    dbCon.Open();
                    string sql = $"SELECT id FROM diner_table  WHERE name=\"{name}\"";
                    var cmd = new MySqlCommand(sql, dbCon);
                    var rdr = cmd.ExecuteReader();
                    int tableId = 0;
                    while (rdr.Read())
                    {
                        tableId = rdr.GetInt32(0);
                    }
                    rdr.Close();
                    cmd.CommandText = $"UPDATE meal SET name=\"{newName}\" WHERE id={tableId}";
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
        public bool AddWaiter(string name,string password,decimal salary)
        {
            using(dbCon)
            {
                try
                {
                    dbCon.Open();
                    string sql = "SELECT*FROM waiter";
                    var cmd = new MySqlCommand(sql, dbCon);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<Waiter> waiters = new List<Waiter>();
                    while (rdr.Read())
                    {
                        waiters.Add(new Waiter(rdr.GetString(1),rdr.GetString(2), rdr.GetDecimal(3)));
                    }
                    foreach (var waiter in waiters)
                    {
                        if (waiter.Name.ToLower() == name.ToLower())
                        {
                            return false;
                        }
                    }
                    rdr.Close();
                    cmd.CommandText = $"INSERT INTO waiter (name,password,salary) values(\"{name}\",{password},{salary})";
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
        public bool RemoveWaiter(string name)
        {
            using (dbCon)
            {
                try
                {
                    dbCon.Open();
                    string sql = $"DELETE FROM waiter WHERE name =\"{name}\"";
                    var cmd = new MySqlCommand(sql, dbCon);
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
        public bool EditWaiter(string name,string password,decimal salary,string newName,string newPassword,decimal newSalary)
        {
            using(dbCon)
            {
                try
                {
                    dbCon.Open();
                    string sql = $"SELECT id FROM waiter  WHERE name=\"{name}\"";
                    var cmd = new MySqlCommand(sql, dbCon);
                    var rdr = cmd.ExecuteReader();
                    int waiterId = 0;
                    while (rdr.Read())
                    {
                        waiterId = rdr.GetInt32(0);
                    }
                    rdr.Close();
                    cmd.CommandText = $"UPDATE waiter SET name=\"{newName}\", password={newPassword},salary={newSalary} WHERE id={waiterId}";
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
