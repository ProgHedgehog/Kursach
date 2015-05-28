using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace MDI_Project
{
    class DataBase
    {
        SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
        public void AddDataBase()
        {
            SQLiteConnection.CreateFile(@"C:\Users\user\Desktop\КУРСОВАЯ!!!\Kursach\MDI_Project\bin\Debug\Database.sqlite");
            SQLiteCommand contractor = new SQLiteCommand("create table if not exists Contractor(ContractorID INTEGER PRIMARY KEY, ContractorName TEXT, Email TEXT)", sql);
            SQLiteCommand goods = new SQLiteCommand("create table if not exists Goods(GoodsID INTEGER PRIMARY KEY, ContractorID INTEGER, Name TEXT, Price INTEGER, Amount IMTEGER, CONSTRAINT Goods_Contractorfk FOREIGN KEY (ContractorID) REFERENCES Contractor(ContractorID))", sql);
            SQLiteCommand contractor_goods = new SQLiteCommand("create table if not exists ContractorGoods(ContractorGoodsID INTEGER PRIMARY KEY, ContractorID INTEGER, GoodsID INTEGER, CONSTRAINT CotractorGoods_Goodsfk FOREIGN KEY (GoodsID) REFERENCES Goods(GoodsID))", sql);
            SQLiteCommand sale_purchase = new SQLiteCommand("create table if not exists SalePurchase(SalePurchaseID INTEGER PRIMARY KEY, GoodsID INTEGER, DateOfPurchase TEXT, CONSTRAINT SalePurchase_Goodsfk FOREIGN KEY (GoodsID) REFERENCES Goods(GoodsID))", sql);
            SQLiteCommand goods_sale_purchase = new SQLiteCommand("create table if not exists GoodsSalePurchase(GoodsSalePurchaseID INTEGER PRIMARY KEY, GoodsID INTEGER, SalePurchaseID INTEGER, CONSTRAINT GoodsSalePurchase_Goodsfk FOREIGN KEY (GoodsID) REFERENCES Goods(GoodsID), CONSTRAINT GoodsSalePurchase_SalePurchasefk FOREIGN KEY (SalePurchaseID) REFERENCES SalePurchase(SalePurchaseID))", sql);
           
            sql.Open();
            contractor.ExecuteNonQuery();
            goods.ExecuteNonQuery();
            contractor_goods.ExecuteNonQuery();
            sale_purchase.ExecuteNonQuery();
            goods_sale_purchase.ExecuteNonQuery();
            sql.Close();    
        }
        public void Fill(string command_line)
        {
            //new SQLiteCommand(command_line, sql);
            //command_line.ExecuteNonQuery();
        }
    }
}