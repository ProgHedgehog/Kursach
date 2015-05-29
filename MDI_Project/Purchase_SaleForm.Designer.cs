namespace MDI_Project
{
    partial class Purchase_SaleForm
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
            this.cMBmeasure = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cMBgoods = new System.Windows.Forms.ComboBox();
            this.nUDamount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nUDyear = new System.Windows.Forms.NumericUpDown();
            this.nUDmonth = new System.Windows.Forms.NumericUpDown();
            this.nUDday = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUDamount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDmonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDday)).BeginInit();
            this.SuspendLayout();
            // 
            // cMBmeasure
            // 
            this.cMBmeasure.AutoCompleteCustomSource.AddRange(new string[] {
            "Литры",
            "Килограммы",
            "Штуки",
            "Метры"});
            this.cMBmeasure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cMBmeasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMBmeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cMBmeasure.FormattingEnabled = true;
            this.cMBmeasure.ItemHeight = 24;
            this.cMBmeasure.Items.AddRange(new object[] {
            "кг",
            "шт",
            "л",
            "м"});
            this.cMBmeasure.Location = new System.Drawing.Point(563, 56);
            this.cMBmeasure.Name = "cMBmeasure";
            this.cMBmeasure.Size = new System.Drawing.Size(164, 32);
            this.cMBmeasure.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(340, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Введите количество и выберите единицы измерения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Выберите товар из списка";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(17, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 46);
            this.button2.TabIndex = 16;
            this.button2.Text = "Сформировать операцию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cMBgoods
            // 
            this.cMBgoods.AutoCompleteCustomSource.AddRange(new string[] {
            "Литры",
            "Килограммы",
            "Штуки",
            "Метры"});
            this.cMBgoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cMBgoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cMBgoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cMBgoods.FormattingEnabled = true;
            this.cMBgoods.ItemHeight = 24;
            this.cMBgoods.Location = new System.Drawing.Point(17, 56);
            this.cMBgoods.Name = "cMBgoods";
            this.cMBgoods.Size = new System.Drawing.Size(164, 32);
            this.cMBgoods.TabIndex = 22;
            // 
            // nUDamount
            // 
            this.nUDamount.Location = new System.Drawing.Point(345, 67);
            this.nUDamount.Name = "nUDamount";
            this.nUDamount.Size = new System.Drawing.Size(164, 20);
            this.nUDamount.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nUDyear);
            this.groupBox1.Controls.Add(this.nUDmonth);
            this.groupBox1.Controls.Add(this.nUDday);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(422, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите дату покупки";
            // 
            // nUDyear
            // 
            this.nUDyear.Location = new System.Drawing.Point(236, 42);
            this.nUDyear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nUDyear.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nUDyear.Name = "nUDyear";
            this.nUDyear.Size = new System.Drawing.Size(93, 26);
            this.nUDyear.TabIndex = 2;
            this.nUDyear.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // nUDmonth
            // 
            this.nUDmonth.Location = new System.Drawing.Point(122, 42);
            this.nUDmonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nUDmonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDmonth.Name = "nUDmonth";
            this.nUDmonth.Size = new System.Drawing.Size(93, 26);
            this.nUDmonth.TabIndex = 1;
            this.nUDmonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUDday
            // 
            this.nUDday.Location = new System.Drawing.Point(7, 42);
            this.nUDday.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nUDday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDday.Name = "nUDday";
            this.nUDday.Size = new System.Drawing.Size(93, 26);
            this.nUDday.TabIndex = 0;
            this.nUDday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Purchase_SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nUDamount);
            this.Controls.Add(this.cMBgoods);
            this.Controls.Add(this.cMBmeasure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase_SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Purchase_SaleForm";
            ((System.ComponentModel.ISupportInitialize)(this.nUDamount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUDyear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDmonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cMBmeasure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cMBgoods;
        private System.Windows.Forms.NumericUpDown nUDamount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nUDyear;
        private System.Windows.Forms.NumericUpDown nUDmonth;
        private System.Windows.Forms.NumericUpDown nUDday;

    }
}