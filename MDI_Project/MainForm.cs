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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckGoods();
        }

        public void CheckGoods()
        {
            var c = " ";
            SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            sql.Open();
            string check_amount = "SELECT Amount FROM Goods";
            SQLiteCommand check = new SQLiteCommand(check_amount, sql);
            check.ExecuteNonQuery();
            SQLiteDataReader reader = check.ExecuteReader();
            while (reader.Read())
            {
                //if (reader[0] > (reader[0] - 10))
               // c =c + String.Format("{0}", reader[0]) + " \n";
                c = reader[0] + "";
            }
            textBox1.Text = c;

            

            sql.Close();
        }
    }
}
