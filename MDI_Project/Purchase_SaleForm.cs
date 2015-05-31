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
        public string id = "";
        public string name = "";
        public string amount = "";
        public string measure = "";
        public string date = "";
        public string price = "";
        public string final_price = "";

        AMTgoods pdf = new AMTgoods();

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
            if ((cMBgoods.SelectedIndex != -1) && (cMBmeasure.SelectedIndex != -1) && (nUDamount.Value != 0))
            {
                //Получение данных для построения заказа
                sql.Open();

                string current_name = "";
                string check_name = "SELECT Name FROM Goods  WHERE Name LIKE '" + Convert.ToString(cMBgoods.SelectedItem) + "'";
                SQLiteCommand get_name = new SQLiteCommand(check_name, sql);
                SQLiteDataReader reader_name = get_name.ExecuteReader();
                while (reader_name.Read())
                {
                    current_name = reader_name[0] + "";
                }

                string current_price = "";
                string check_price = "SELECT Price FROM Goods  WHERE Name LIKE '" + Convert.ToString(cMBgoods.SelectedItem) + "'";
                SQLiteCommand get_price = new SQLiteCommand(check_price, sql);
                SQLiteDataReader reader_price = get_price.ExecuteReader();
                while (reader_price.Read())
                {
                    current_price = reader_price[0] + "";
                }

                string current_id = "";
                string check_id = "SELECT GoodsID FROM Goods  WHERE Name LIKE '" + Convert.ToString(cMBgoods.SelectedItem) + "'";
                SQLiteCommand get_id = new SQLiteCommand(check_id, sql);
                SQLiteDataReader reader_id = get_id.ExecuteReader();
                while (reader_id.Read())
                {
                    current_id = reader_id[0] + "";
                }

                id = current_id;
                name = current_name;
                amount = Convert.ToString(nUDamount.Value);
                measure = Convert.ToString(cMBmeasure.SelectedItem);
                date = Convert.ToString(nUDday.Value) + "." + Convert.ToString(nUDamount.Value) + "." + Convert.ToString(nUDyear.Value);
                price = current_price;
                final_price = (Convert.ToInt32(current_price) * Convert.ToInt32(nUDamount.Value)).ToString();
                //Нахождение разницы того сколько товаров было и того сколько купили

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

                //проверка количества товаров на складе после оформления операции купли-продажи
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
                        MessageBox.Show(" Невозможно отослать запрос на покупку товара. Проверьте , заполнена ли быза данных поставщиков ");
                    }
                sql.Close();
            }
            else
            {
                MessageBox.Show(" Не все поля заполнены ");
            }

        }

        public void Check_Amount()
        {
            string smtpServer = "smtp.mail.ru";
            string from = "hedgehoggy@mail.ru";
            string password = "31415926afaf";
            string mailto = "";
            string contractor = "";

            string contractorid = "";
            string check_mail1 = "SELECT ContractorID FROM Goods WHERE Name LIKE '" + Convert.ToString(cMBgoods.SelectedItem) + "'";
            SQLiteCommand get_mail1 = new SQLiteCommand(check_mail1, sql);
            SQLiteDataReader reader_mail1 = get_mail1.ExecuteReader();
            while (reader_mail1.Read())
            {
                contractorid = reader_mail1[0] + "";
            }


            string check_mail = "SELECT Email FROM Contractor  WHERE ContractorID LIKE " + contractorid;
            SQLiteCommand get_mail = new SQLiteCommand(check_mail, sql);
            SQLiteDataReader reader_mail = get_mail.ExecuteReader();
            while (reader_mail.Read())
            {
                mailto = reader_mail[0] + "";
            }
            string check_contractor = "SELECT ContractorName FROM Contractor WHERE Email LIKE '" + mailto + "'";
            SQLiteCommand get_contractor = new SQLiteCommand(check_contractor, sql);
            SQLiteDataReader reader_contractor = get_contractor.ExecuteReader();
            while (reader_contractor.Read())
            {
                contractor = reader_contractor[0] + "";
            }
            string caption = "Заказ";
            string message = "Уважаемый" + contractor + " напоминаем вам о том что необходимо поставить товар. Счёт прилагается к письму";
            string attachFile = @"C:\Temp\PdfFile.pdf";
            pdf.Add_PDF(id, name, amount, measure, date, price, final_price);
            Mail.SendMail(smtpServer, from, password, mailto, caption, message, attachFile);
        }


        private void nUDmonth_ValueChanged_1(object sender, EventArgs e)
        {
            if (nUDmonth.Value == 2)
            {
                nUDday.Maximum = 28;
            }
            else
                if ((nUDmonth.Value == 4) || (nUDmonth.Value == 6) || (nUDmonth.Value == 9) || (nUDmonth.Value == 11))
                {
                    nUDday.Maximum = 30;
                }
                else
                    nUDday.Maximum = 31;

        }

    }
}
