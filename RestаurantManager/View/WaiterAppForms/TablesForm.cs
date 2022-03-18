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
    public partial class TablesForm : Form
    {
        public TablesForm()
        {
            InitializeComponent();
        }
        RestaurantController controller = new RestaurantController();
        MySqlConnection dbCon = new MySqlConnection(DBConnection.GetConnectionString());
        private void TablesForm_Load(object sender, EventArgs e)
        {
            using(dbCon)
            {
                try
                {
                    dbCon.Open();
                    string sql = $"SELECT * FROM diner_table";
                    var cmd= new MySqlCommand(sql,dbCon);
                    var rdr=cmd.ExecuteReader();
                    List<Table> tables = new List<Table>();
                    while (rdr.Read())
                    {
                        tables.Add(new Table(rdr.GetString(1)));
                    }
                    //tablesLayoutPanel.
                    dbCon.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
