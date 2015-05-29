namespace MDI_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Purchase_SaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoodsEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProviderEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoodsCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiDataSet1 = new MDI_Project.MDIDataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(32)))), ((int)(((byte)(121)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainToolStripMenuItem,
            this.Purchase_SaleToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ReportToolStripMenuItem,
            this.GoodsCountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainToolStripMenuItem
            // 
            this.MainToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainToolStripMenuItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.MainToolStripMenuItem.Name = "MainToolStripMenuItem";
            this.MainToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.MainToolStripMenuItem.Text = "На главную";
            this.MainToolStripMenuItem.Click += new System.EventHandler(this.MainToolStripMenuItem_Click);
            // 
            // Purchase_SaleToolStripMenuItem
            // 
            this.Purchase_SaleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Purchase_SaleToolStripMenuItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.Purchase_SaleToolStripMenuItem.Name = "Purchase_SaleToolStripMenuItem";
            this.Purchase_SaleToolStripMenuItem.Size = new System.Drawing.Size(302, 25);
            this.Purchase_SaleToolStripMenuItem.Text = "Создать операцию купли-продажи";
            this.Purchase_SaleToolStripMenuItem.Click += new System.EventHandler(this.Purchase_SaleToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoodsEditToolStripMenuItem,
            this.ProviderEditToolStripMenuItem});
            this.EditToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditToolStripMenuItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(153, 25);
            this.EditToolStripMenuItem.Text = "Редактирование";
            // 
            // GoodsEditToolStripMenuItem
            // 
            this.GoodsEditToolStripMenuItem.Name = "GoodsEditToolStripMenuItem";
            this.GoodsEditToolStripMenuItem.Size = new System.Drawing.Size(347, 26);
            this.GoodsEditToolStripMenuItem.Text = "Редактировать базу товаров";
            this.GoodsEditToolStripMenuItem.Click += new System.EventHandler(this.GoodsEditToolStripMenuItem_Click);
            // 
            // ProviderEditToolStripMenuItem
            // 
            this.ProviderEditToolStripMenuItem.Name = "ProviderEditToolStripMenuItem";
            this.ProviderEditToolStripMenuItem.Size = new System.Drawing.Size(347, 26);
            this.ProviderEditToolStripMenuItem.Text = "Редактировать базу поставщиков";
            this.ProviderEditToolStripMenuItem.Click += new System.EventHandler(this.ProviderEditToolStripMenuItem_Click);
            // 
            // ReportToolStripMenuItem
            // 
            this.ReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportToolStripMenuItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
            this.ReportToolStripMenuItem.Size = new System.Drawing.Size(197, 25);
            this.ReportToolStripMenuItem.Text = "Отчёт о популярности";
            this.ReportToolStripMenuItem.Click += new System.EventHandler(this.ReportToolStripMenuItem_Click_1);
            // 
            // GoodsCountToolStripMenuItem
            // 
            this.GoodsCountToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GoodsCountToolStripMenuItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.GoodsCountToolStripMenuItem.Name = "GoodsCountToolStripMenuItem";
            this.GoodsCountToolStripMenuItem.Size = new System.Drawing.Size(237, 25);
            this.GoodsCountToolStripMenuItem.Text = "Количество номенклатуры";
            this.GoodsCountToolStripMenuItem.Click += new System.EventHandler(this.GoodsCountToolStripMenuItem_Click);
            // 
            // mdiDataSet1
            // 
            this.mdiDataSet1.DataSetName = "MDIDataSet";
            this.mdiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1059, 494);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Прграмма учёта купли-продажи";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoodsEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProviderEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Purchase_SaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportToolStripMenuItem;
        private MDIDataSet mdiDataSet1;
        private System.Windows.Forms.ToolStripMenuItem GoodsCountToolStripMenuItem;
    }
}

