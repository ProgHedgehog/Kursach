using System;
using System.Collections.Generic;
using iTextSharp.text;
using iTextSharp;
using System.IO;
using iTextSharp.text.pdf;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace MDI_Project
{
    class AMTgoods
    {
            public Document _doc;
            private AMTgoods()
            {
                _doc = new Document();
                string path = @"C:\Temp\PdfFile.pdf";
                try
                {
                    File.Delete(path);
                }
                catch { }
                PdfWriter.GetInstance(_doc, new FileStream(path, FileMode.CreateNew));
                _doc.Open();

                CreateTable();

                _doc.Close();
            }

            public static void GenerateFile()
            {
                var file = new AMTgoods();
            }

            private void CreateTable()
            {
                string fg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Fradm.TTF");
                BaseFont fgBaseFont = BaseFont.CreateFont(fg, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                Font fgFont = new Font(fgBaseFont, 9, Font.NORMAL, BaseColor.BLACK);

                var title = new Paragraph("Счет на оплату", fgFont);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 5;

                var chapter = new Chapter(1);
                var table = new PdfPTable(6);
                Phrase p;

                p = new Phrase("номер по порядку", fgFont);
                table.AddCell(CreateCell(p, rows: 2));

                p = new Phrase("товар", fgFont);
                table.AddCell(CreateCell(p, rows: 1));

                p = new Phrase("единица измерения", fgFont);
                table.AddCell(CreateCell(p, rows: 1));

                p = new Phrase("количество", fgFont);
                table.AddCell(CreateCell(p, rows: 2));

                p = new Phrase("цена за единицу товара", fgFont);
                table.AddCell(CreateCell(p, rows: 2));

                p = new Phrase("общая цена", fgFont);
                table.AddCell(CreateCell(p, rows: 2));

                p = new Phrase("наименование", fgFont);
                table.AddCell(CreateCell(p));

                p = new Phrase("наименование", fgFont);
                table.AddCell(CreateCell(p));

                p = new Phrase("1 ");
                table.AddCell(CreateCell(p));

                p = new Phrase("2 ");
                table.AddCell(CreateCell(p));

                p = new Phrase("3 ");
                table.AddCell(CreateCell(p));

                p = new Phrase("4 ");
                table.AddCell(CreateCell(p));

                p = new Phrase("5 ");
                table.AddCell(CreateCell(p));

                p = new Phrase("6 ");
                table.AddCell(CreateCell(p));

                p = new Phrase(" ");
                table.AddCell(CreateCell(p));

                p = new Phrase(" ");
                table.AddCell(CreateCell(p));

                p = new Phrase(" ");
                table.AddCell(CreateCell(p));

                p = new Phrase(" ");
                table.AddCell(CreateCell(p));

                p = new Phrase(" ");
                table.AddCell(CreateCell(p));

                p = new Phrase(" ");
                table.AddCell(CreateCell(p));

                table.SpacingAfter = 10;

                var subtitle1 = new Paragraph("___________", fgFont);
                subtitle1.Alignment = Element.ALIGN_RIGHT;

                var subtitle = new Paragraph("Подпись", fgFont);
                subtitle.Alignment = Element.ALIGN_RIGHT;
                subtitle.SpacingAfter = 5;

                chapter.Add(title);
                chapter.Add(table);
                chapter.Add(subtitle1);
                chapter.Add(subtitle);
                _doc.Add(chapter);
            }

            private PdfPCell CreateCell(Phrase phrase, int rows = 1, int cols = 1)
            {
                var cell = new PdfPCell(phrase);
                cell.Colspan = cols;
                cell.Rowspan = rows;

                return cell;
            }

            private void sample() 
            { 
            SQLiteConnection sql = new SQLiteConnection(@"Data Source=base.sqlite;Version=3");
            sql.Open();
            string selectCmnd = "SELECT Name From Goods";
            string selectCmnd1 = "SELECT Price From Goods";
            string selectCmnd2 = "SELECT Amount From Goods";

            SQLiteCommand sqlcmndN = new SQLiteCommand(selectCmnd, sql);
            SQLiteCommand sqlcmndP = new SQLiteCommand(selectCmnd1, sql);
            SQLiteCommand sqlcmndA= new SQLiteCommand(selectCmnd2, sql);
            sql.Close();
            }
            

            
        }
}
