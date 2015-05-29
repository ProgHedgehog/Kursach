namespace MDI_Project
{
    partial class GoodsCount
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
            this.nUDgoods = new System.Windows.Forms.NumericUpDown();
            this.cmBGoods = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDgoods)).BeginInit();
            this.SuspendLayout();
            // 
            // nUDgoods
            // 
            this.nUDgoods.Location = new System.Drawing.Point(605, 118);
            this.nUDgoods.Name = "nUDgoods";
            this.nUDgoods.Size = new System.Drawing.Size(120, 20);
            this.nUDgoods.TabIndex = 0;
            // 
            // cmBGoods
            // 
            this.cmBGoods.FormattingEnabled = true;
            this.cmBGoods.Location = new System.Drawing.Point(297, 118);
            this.cmBGoods.Name = "cmBGoods";
            this.cmBGoods.Size = new System.Drawing.Size(154, 21);
            this.cmBGoods.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(293, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(504, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Укажите минимальное количество";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(387, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(241, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GoodsCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 460);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBGoods);
            this.Controls.Add(this.nUDgoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoodsCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ATMcount";
            ((System.ComponentModel.ISupportInitialize)(this.nUDgoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUDgoods;
        private System.Windows.Forms.ComboBox cmBGoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
    }
}