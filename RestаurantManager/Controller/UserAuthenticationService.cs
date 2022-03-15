using MySql.Data.MySqlClient;
using RestаurantManager.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestаurantManager.Controller
{
    public class UserAuthenticationService
    {


        public static bool CheckAdminLogin(string userName, string userPassword)
        {         
            MySqlConnection dbCon = new MySqlConnection(DBConnection.GetConnectionString());
            using (dbCon)
            {
                try
                {
                    Admin admin;
                    dbCon.Open();
                    string sql = "SELECT*FROM admins";
                    var cmd = new MySqlCommand(sql, dbCon);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<Admin> admins = new List<Admin>();
                    while (rdr.Read())
                    {
                        admin = new Admin(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2));
                        admins.Add(admin);
                    }
                    foreach (var admin1 in admins)
                    {
                        if(admin1.AdminName==userName&&admin1.AdminPassword==userPassword)
                        {
                            return true;
                        }
                    }
                    dbCon.Close();
                    return false;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }
        public static bool CheckWaiterLogin(string userName, string userPassword)
        { 
            MySqlConnection dbCon = new MySqlConnection(DBConnection.GetConnectionString());
            using (dbCon)
            {
                try
                {
                    Waiter waiter;
                    dbCon.Open();
                    string sql = "SELECT*FROM waiter";
                    var cmd = new MySqlCommand(sql, dbCon);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    List<Waiter> waiters = new List<Waiter>();
                    while (rdr.Read())
                    {
                        waiter = new Waiter( rdr.GetString(1), rdr.GetString(2),rdr.GetDecimal(3));
                        waiters.Add(waiter);
                    }
                    foreach (var item in waiters)
                    {
                        if (item.Name == userName && item.Password == userPassword)
                        {
                            return true;
                        }
                    }
                    dbCon.Close();
                    return false;

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
