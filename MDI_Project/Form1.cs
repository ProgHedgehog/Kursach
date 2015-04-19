using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }


        MainForm mf;
        private void MainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mf == null)
            {
                mf = new MainForm();
                mf.MdiParent = this;
                mf.Show();
            }
            else
            {
                mf.Activate();
            }
            
        }
      

        Purchase_SaleForm ps;

        private void Purchase_SaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ps == null)
            {
                ps = new Purchase_SaleForm();
                ps.MdiParent = this;
                ps.TopMost = true;
                ps.Show();
            }
            else
            {
                ps.Activate();
            }    
        }

        ReportForm rf;

        private void ReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (rf == null)
            {
                rf = new ReportForm();
                rf.MdiParent = this;
                rf.Show();
            }
            else
            {
                rf.Activate();
            }
        }

        GoodsEditForm ge;

        private void GoodsEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ge == null)
            {
                ge = new GoodsEditForm();
                ge.MdiParent = this;
                ge.Show();
            }
            else
            {
                ge.Activate();
            }
        }

        ProviderEditForm pe;
        private void ProviderEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pe == null)
            {
                pe = new ProviderEditForm();
                pe.MdiParent = this;
                pe.Show();
            }
            else
            {
                pe.Activate();
            }
        }
    }
}
