using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestаurantManager.Controller
{
    public  class UserAuthenticationService
    {
       

        public static bool CheckAdminLogin(string userName, string Password)
        {
            string server = "localhost";
            string database = "restaurant_manager";
            string uid = "root";
            string password = "123456";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection dbCon= new MySqlConnection(connectionString);
            using (dbCon)
            {
                try
                {
                    string result = "";
                    dbCon.Open();
                    string sql= "SELECT*FROM admins";
                    var cmd = new MySqlCommand(sql,dbCon);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        result = string.Format("{0} {1} {2}", rdr.GetInt32(0), rdr.GetString(1),
                                rdr.GetString(2));
                    }
                    MessageBox.Show(result);
                    return true;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }
        public static bool CheckWaiterLogin(string userName, string Password)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
        }
    }
}
