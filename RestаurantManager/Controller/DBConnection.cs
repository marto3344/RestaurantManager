using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestаurantManager.Controller
{
    public class DBConnection
    {   
        public static string GetConnectionString()
        {
            string server = "sql11.freesqldatabase.com";
            string database = "sql11478499";
            string uid = "sql11478499";
            string password = "dpzG4c5BKX";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            return connectionString;
        }

    }
}
