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
    public partial class GoodsCount : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        public GoodsCount()
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
                cmBGoods.Items.Add(c);               
            }
            sql.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sql.Open();
            string check_name = "UPDATE Goods SET MinAmount = "+ Convert.ToString(nUDgoods.Value) + " WHERE Name LIKE '" +cmBGoods.SelectedItem + "'";
            SQLiteCommand check = new SQLiteCommand(check_name, sql);
            check.ExecuteNonQuery();
            string c = "Пороговое значение для товара " + cmBGoods.SelectedItem + " задано.";
            MessageBox.Show(c);
            sql.Close();
        }
    }
}
