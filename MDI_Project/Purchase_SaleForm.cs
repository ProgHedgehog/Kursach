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
        public string name = "";
        public string amount = "";
        public string measure = "";
        public string date = "";

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
            name = check.ExecuteNonQuery().ToString();
            amount = Convert.ToString(nUDamount.Value);
            measure = Convert.ToString(cMBmeasure.SelectedItem);
            date = Convert.ToString(nUDday.Value) + "." + Convert.ToString(nUDamount.Value) + "." + Convert.ToString(nUDyear.Value);

            string c = "";
            string get_amount = "SELECT Amount FROM Goods WHERE Name LIKE '" + Convert.ToString(cMBgoods.SelectedItem) + "'";
            SQLiteCommand get = new SQLiteCommand(get_amount, sql);
            get.ExecuteNonQuery();
            SQLiteDataReader reader = get.ExecuteReader();
            while (reader.Read())
            {
                c = reader[0] + "";
            }
            int difference = Convert.ToInt32(c) - Convert.ToInt32(amount);
            string update_goods_amount = "UPDATE Goods SET Amount = " + (Convert.ToInt32(c) - Convert.ToInt32(amount)) + " WHERE Name LIKE '" + Convert.ToString(cMBgoods.SelectedItem) + "'";
            SQLiteCommand update = new SQLiteCommand(update_goods_amount, sql);
            update.ExecuteNonQuery();
            MessageBox.Show("Операция выполнена успешно");



            string q = "";
            string get_min_amount = "SELECT MinAmount FROM Goods WHERE Name LIKE '" + Convert.ToString(cMBgoods.SelectedItem) + "'";
            SQLiteCommand get_min = new SQLiteCommand(get_min_amount, sql);
            get_min.ExecuteNonQuery();
            SQLiteDataReader reader_min = get_min.ExecuteReader();
            while (reader_min.Read())
            {
                q = reader_min[0] + "";
            }

            if (Convert.ToInt32(c) < Convert.ToInt32(q))
                try
                {
                    Check_Amount();
                }
                catch
                {

                }
            Check_Amount();
            sql.Close();
        }

        public void Check_Amount()
        {

            pdf.Add_PDF(name, amount, measure, date);
        }

    }
}
