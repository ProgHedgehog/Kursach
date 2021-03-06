﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace MDI_Project
{
    public partial class GoodsEditForm : Form
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");

        public GoodsEditForm()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();

        private void button1_Click(object sender, EventArgs e)
        {
            db.AddDataBase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql.Open();
            try
            { 
                SQLiteCommand sqlcon = new SQLiteCommand(sql);
                sqlcon.CommandText = @"SELECT * FROM Goods;";
                SQLiteDataReader srd = sqlcon.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(srd);
                dataGridView1.DataSource = dt;
                srd.Close();
            }
            catch
            {
                MessageBox.Show("Вывод базы данных невозможен");
            }

            sql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string line;
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader file = new StreamReader(openFileDialog1.FileName);
                            while ((line = file.ReadLine()) != null)
                            {
                                sql.Open();
                                //string insert = "insert into contractor (ContractorID, ContractorName, Email) values (0, 'Avtoraai Kia', 'hedgehoggy@mail.ru')";
                                SQLiteCommand command_insert = new SQLiteCommand(line, sql);
                                command_insert.ExecuteNonQuery();
                                sql.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AMTgoods.GenerateFile();
        }
    }

}
