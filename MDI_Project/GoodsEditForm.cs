using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MDI_Project
{
    public partial class GoodsEditForm : Form
    {
        public GoodsEditForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            string name_file = " ";
            string file_text = " ";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        
                        using (myStream)
                        {
                            string s;
                            name_file = openFileDialog.FileName;
                            StreamReader streamreader = File.OpenText(name_file);
                            while ((s = streamreader.ReadLine()) != null)
                            {                               
                                file_text += s + "\r\n";
                            }
                            //textBox1.Text = file_text;
                            textBox1.Text = File.ReadAllText(name_file , Encoding.Default);
                            streamreader.Close();
                                // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }
    }

}
