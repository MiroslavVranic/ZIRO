namespace ZIRO
{
    partial class ZiR
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_djelatnik = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_zaduzi = new System.Windows.Forms.Button();
            this.btn_razduzi = new System.Windows.Forms.Button();
            this.btn_pretrazi = new System.Windows.Forms.Button();
            this.lbl_inventar = new System.Windows.Forms.Label();
            this.lbl_trenutniKorisnik = new System.Windows.Forms.Label();
            this.dtp_datum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(78, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 25);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_djelatnik
            // 
            this.lbl_djelatnik.AutoSize = true;
            this.lbl_djelatnik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_djelatnik.Location = new System.Drawing.Point(12, 53);
            this.lbl_djelatnik.Name = "lbl_djelatnik";
            this.lbl_djelatnik.Size = new System.Drawing.Size(60, 17);
            this.lbl_djelatnik.TabIndex = 2;
            this.lbl_djelatnik.Text = "Djelatnik:";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 214);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(860, 395);
            this.dgv.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(457, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 25);
            this.textBox5.TabIndex = 7;
            // 
            // btn_zaduzi
            // 
            this.btn_zaduzi.Location = new System.Drawing.Point(645, 49);
            this.btn_zaduzi.Name = "btn_zaduzi";
            this.btn_zaduzi.Size = new System.Drawing.Size(88, 43);
            this.btn_zaduzi.TabIndex = 10;
            this.btn_zaduzi.Text = "Zaduži";
            this.btn_zaduzi.UseVisualStyleBackColor = true;
            // 
            // btn_razduzi
            // 
            this.btn_razduzi.Location = new System.Drawing.Point(645, 95);
            this.btn_razduzi.Name = "btn_razduzi";
            this.btn_razduzi.Size = new System.Drawing.Size(88, 43);
            this.btn_razduzi.TabIndex = 11;
            this.btn_razduzi.Text = "Razduži";
            this.btn_razduzi.UseVisualStyleBackColor = true;
            // 
            // btn_pretrazi
            // 
            this.btn_pretrazi.Location = new System.Drawing.Point(266, 49);
            this.btn_pretrazi.Name = "btn_pretrazi";
            this.btn_pretrazi.Size = new System.Drawing.Size(88, 89);
            this.btn_pretrazi.TabIndex = 12;
            this.btn_pretrazi.Text = "Pretraži";
            this.btn_pretrazi.UseVisualStyleBackColor = true;
            // 
            // lbl_inventar
            // 
            this.lbl_inventar.AutoSize = true;
            this.lbl_inventar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventar.Location = new System.Drawing.Point(394, 55);
            this.lbl_inventar.Name = "lbl_inventar";
            this.lbl_inventar.Size = new System.Drawing.Size(57, 17);
            this.lbl_inventar.TabIndex = 14;
            this.lbl_inventar.Text = "Inventar:";
            // 
            // lbl_trenutniKorisnik
            // 
            this.lbl_trenutniKorisnik.AutoSize = true;
            this.lbl_trenutniKorisnik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trenutniKorisnik.Location = new System.Drawing.Point(12, 9);
            this.lbl_trenutniKorisnik.Name = "lbl_trenutniKorisnik";
            this.lbl_trenutniKorisnik.Size = new System.Drawing.Size(0, 17);
            this.lbl_trenutniKorisnik.TabIndex = 15;
            // 
            // dtp_datum
            // 
            this.dtp_datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datum.Location = new System.Drawing.Point(78, 116);
            this.dtp_datum.Name = "dtp_datum";
            this.dtp_datum.Size = new System.Drawing.Size(182, 22);
            this.dtp_datum.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Datum:";
            // 
            // ZiR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 621);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_datum);
            this.Controls.Add(this.lbl_trenutniKorisnik);
            this.Controls.Add(this.lbl_inventar);
            this.Controls.Add(this.btn_pretrazi);
            this.Controls.Add(this.btn_razduzi);
            this.Controls.Add(this.btn_zaduzi);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbl_djelatnik);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZiR";
            this.Text = "ZiR";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_djelatnik;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_zaduzi;
        private System.Windows.Forms.Button btn_razduzi;
        private System.Windows.Forms.Button btn_pretrazi;
        private System.Windows.Forms.Label lbl_inventar;
        private System.Windows.Forms.Label lbl_trenutniKorisnik;
        private System.Windows.Forms.DateTimePicker dtp_datum;
        private System.Windows.Forms.Label label1;
    }
}