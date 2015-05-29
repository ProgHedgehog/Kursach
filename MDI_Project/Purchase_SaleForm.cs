using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MDI_Project
{
    public partial class Purchase_SaleForm : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");

        public Purchase_SaleForm()
        {
            InitializeComponent();
            AddToComboBox();

        }

        private void AddToComboBox()
        {
            var c = " ";
            sql.Open();
            string check_name = "SELECT Name FROM Goods";
            SQLiteCommand check = new SQLiteCommand(check_name, sql);
            check.ExecuteNonQuery();
            SQLiteDataReader reader = check.ExecuteReader();
            while (reader.Read())
            {
                c = reader[0] + "";
                cMBgoods.Items.Add(c);
            }
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql.Open();
            string check_name = "SELECT Name FROM Goods  WHERE Name LIKE '" + Convert.ToString(cMBgoods.SelectedItem) + "'";
            SQLiteCommand check = new SQLiteCommand(check_name, sql);
            string name = check.ExecuteNonQuery().ToString();
            string amount = Convert.ToString(nUDamount.Value);
            string measure = Convert.ToString(cMBmeasure.SelectedItem);
            string date = Convert.ToString(nUDday.Value) + "." + Convert.ToString(nUDamount.Value) + "." + Convert.ToString(nUDyear.Value);











            string get_amount = "SELECT Amount FROM Goods WHERE Name LIKE '" + Convert.ToString(cMBgoods.SelectedItem) + "'";
            SQLiteCommand get = new SQLiteCommand(get_amount, sql);
            
            int q = get.ExecuteNonQuery();
            MessageBox.Show(q.ToString());
            //SQLiteCommand get = new SQLiteCommand(get_amount, sql);
            //string q = Convert.ToString(get.ExecuteNonQuery());    
            //int difference = get.ExecuteNonQuery() - Convert.ToInt32(nUDamount.Value);

            string update_goods_amount = "UPDATE Goods SET Amount = " + Convert.ToString(get.ExecuteNonQuery() - nUDamount.Value)  + " WHERE Name LIKE '" + Convert.ToString(cMBgoods.SelectedItem) + "'";
            //SQLiteCommand update = new SQLiteCommand(update_goods_amount, sql);
            //update.ExecuteNonQuery();
            MessageBox.Show("Операция выполнена успешно");
            sql.Close();
        }



    }
}
