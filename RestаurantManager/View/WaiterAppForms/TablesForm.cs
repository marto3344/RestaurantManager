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
        private List<Table> tables = new List<Table>();
        private List<Meal> meals = new List<Meal>();    
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
                    while (rdr.Read())
                    {
                        this.tables.Add(new Table(rdr.GetString(1)));
                        tableBox.Items.Add(rdr.GetString(1));
                    }
                    rdr.Close();
                    sql= $"SELECT * FROM meal";
                    cmd=new MySqlCommand(sql,dbCon);
                    rdr=cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        this.meals.Add(new Meal(rdr.GetString(1), rdr.GetDecimal(2)));
                        mealBox.Items.Add(rdr.GetString(1));
                    }
                    rdr.Close();
                    dbCon.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }



        private void addMeal_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                int tableIndex = tableBox.SelectedIndex;
                int mealIndex = mealBox.SelectedIndex;
                int count = int.Parse(quantityBox.Text);
                string result = "";
                result = $"{meals[mealIndex].Name} - {count}* {meals[mealBox.SelectedIndex].Price} lv.";
                tables[tableBox.SelectedIndex].Order += Environment.NewLine + result;
                tables[tableBox.SelectedIndex].Bill += count * meals[mealBox.SelectedIndex].Price;
                billBox.Text = tables[tableBox.SelectedIndex].Order;
                totalCostLabel.Text = $"Total: {tables[tableBox.SelectedIndex].Bill} lv.";
            }

        }

        private void tableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            billBox.Text=tables[tableBox.SelectedIndex].Order;
            totalCostLabel.Text = $"Total: {tables[tableBox.SelectedIndex].Bill} lv.";
        }
        private bool CheckInput()
        {
            if (tableBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select table");
                return false;
            }
            if (mealBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select meal!");
                return false;
            }
            try
            {
               int quantity=int.Parse(quantityBox.Text);
                if (quantity<=0)
                {
                    MessageBox.Show("Please enter valid quantity!");
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid quantity!");
                return false;
            }

        }

       

        private void completeOrder_Click(object sender, EventArgs e)
        {
            DialogResult confirmExitBox = MessageBox.Show("Are you sure you want to complete order?", "Recieve bill?", MessageBoxButtons.OKCancel);
            if (confirmExitBox == DialogResult.OK)
            {
                MessageBox.Show("Order completed! \nPlease get the receipt!");
                tables[tableBox.SelectedIndex].Order = "";
                tables[tableBox.SelectedIndex].Bill = 0;
                billBox.Clear();
                mealBox.SelectedItem = null;
                quantityBox.Text = "";
                totalCostLabel.Text = "Total: ";
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if(billBox.Text=="")
            {
                MessageBox.Show("There is nothing to undo!");
            }
            else
            {
                string[] orderText = billBox.Text.Split('\n').ToArray();
                string lastOrder=orderText[orderText.Length-1];
                Console.WriteLine(lastOrder);
                int count=lastOrder.Split('-').ElementAt(1).Split('*').Select(int.Parse).First();
                decimal newCost= tables[tableBox.SelectedIndex].Bill - meals[mealBox.SelectedIndex].Price * count;
                totalCostLabel.Text = $"Total cost: {newCost} lv."; 
                billBox.Text=string.Join("\n",orderText.Skip(orderText.Length-1));
            }
        }
    }
}
