using MySql.Data.MySqlClient;
using RestаurantManager.Controller;
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
    public partial class ViewSalaryForm : Form
    {
        RestaurantController controller = new RestaurantController();
        MySqlConnection dbCon = new MySqlConnection(DBConnection.GetConnectionString());
        public ViewSalaryForm()
        {
            InitializeComponent();
        }

        private void ViewSalaryForm_Load(object sender, EventArgs e)
        {
            using (dbCon)
            {
                try
                {
                    dbCon.Open();
                    WaiterLogin waiterLogin=new WaiterLogin();

                    var sql = $"select salary from waiter where name=\"{WaiterLogin._waiterName}\" and password=\"{WaiterLogin._waiterPassword}\";";
                    var cmd = new MySqlCommand(sql, dbCon);
                    var rdr = cmd.ExecuteReader();
                    decimal waiterSalary = 0;
                    while (rdr.Read())
                    {
                        waiterSalary = rdr.GetDecimal(0);
                    }
                    rdr.Close();
                    SalaryLabel.Text = $"Your salary is {waiterSalary} lv. !";
                    dbCon.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
