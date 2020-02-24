namespace ZIRO
{
    partial class Djelatnici
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_zaposlenDatum = new System.Windows.Forms.Label();
            this.dtp_zaposlen = new System.Windows.Forms.DateTimePicker();
            this.lbl_trenutniKorisnik = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.btn_izmjeni = new System.Windows.Forms.Button();
            this.btn_spremi = new System.Windows.Forms.Button();
            this.lbk_oib = new System.Windows.Forms.Label();
            this.txt_oib = new System.Windows.Forms.TextBox();
            this.lbl_personalNr = new System.Windows.Forms.Label();
            this.txt_personalBr = new System.Windows.Forms.TextBox();
            this.lbl_otkaz = new System.Windows.Forms.Label();
            this.dtp_otkaz = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(78, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 25);
            this.textBox1.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_zaposlenDatum
            // 
            this.lbl_zaposlenDatum.AutoSize = true;
            this.lbl_zaposlenDatum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zaposlenDatum.Location = new System.Drawing.Point(336, 53);
            this.lbl_zaposlenDatum.Name = "lbl_zaposlenDatum";
            this.lbl_zaposlenDatum.Size = new System.Drawing.Size(64, 17);
            this.lbl_zaposlenDatum.TabIndex = 28;
            this.lbl_zaposlenDatum.Text = "Zaposlen:";
            // 
            // dtp_zaposlen
            // 
            this.dtp_zaposlen.Location = new System.Drawing.Point(406, 49);
            this.dtp_zaposlen.Name = "dtp_zaposlen";
            this.dtp_zaposlen.Size = new System.Drawing.Size(182, 22);
            this.dtp_zaposlen.TabIndex = 27;
            // 
            // lbl_trenutniKorisnik
            // 
            this.lbl_trenutniKorisnik.AutoSize = true;
            this.lbl_trenutniKorisnik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trenutniKorisnik.Location = new System.Drawing.Point(12, 10);
            this.lbl_trenutniKorisnik.Name = "lbl_trenutniKorisnik";
            this.lbl_trenutniKorisnik.Size = new System.Drawing.Size(0, 17);
            this.lbl_trenutniKorisnik.TabIndex = 26;
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezime.Location = new System.Drawing.Point(15, 85);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(57, 17);
            this.lbl_prezime.TabIndex = 25;
            this.lbl_prezime.Text = "Prezime:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(78, 81);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(182, 25);
            this.textBox5.TabIndex = 21;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 215);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(860, 395);
            this.dgv.TabIndex = 20;
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime.Location = new System.Drawing.Point(40, 54);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(32, 17);
            this.lbl_ime.TabIndex = 19;
            this.lbl_ime.Text = "Ime:";
            // 
            // btn_izmjeni
            // 
            this.btn_izmjeni.Location = new System.Drawing.Point(670, 96);
            this.btn_izmjeni.Name = "btn_izmjeni";
            this.btn_izmjeni.Size = new System.Drawing.Size(88, 43);
            this.btn_izmjeni.TabIndex = 30;
            this.btn_izmjeni.Text = "Izmjeni";
            this.btn_izmjeni.UseVisualStyleBackColor = true;
            // 
            // btn_spremi
            // 
            this.btn_spremi.Location = new System.Drawing.Point(670, 50);
            this.btn_spremi.Name = "btn_spremi";
            this.btn_spremi.Size = new System.Drawing.Size(88, 43);
            this.btn_spremi.TabIndex = 29;
            this.btn_spremi.Text = "Spremi";
            this.btn_spremi.UseVisualStyleBackColor = true;
            // 
            // lbk_oib
            // 
            this.lbk_oib.AutoSize = true;
            this.lbk_oib.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbk_oib.Location = new System.Drawing.Point(41, 116);
            this.lbk_oib.Name = "lbk_oib";
            this.lbk_oib.Size = new System.Drawing.Size(31, 17);
            this.lbk_oib.TabIndex = 32;
            this.lbk_oib.Text = "OIB:";
            // 
            // txt_oib
            // 
            this.txt_oib.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oib.Location = new System.Drawing.Point(78, 112);
            this.txt_oib.Name = "txt_oib";
            this.txt_oib.Size = new System.Drawing.Size(182, 25);
            this.txt_oib.TabIndex = 31;
            // 
            // lbl_personalNr
            // 
            this.lbl_personalNr.AutoSize = true;
            this.lbl_personalNr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personalNr.Location = new System.Drawing.Point(27, 147);
            this.lbl_personalNr.Name = "lbl_personalNr";
            this.lbl_personalNr.Size = new System.Drawing.Size(45, 17);
            this.lbl_personalNr.TabIndex = 34;
            this.lbl_personalNr.Text = "PN br:";
            // 
            // txt_personalBr
            // 
            this.txt_personalBr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_personalBr.Location = new System.Drawing.Point(78, 143);
            this.txt_personalBr.Name = "txt_personalBr";
            this.txt_personalBr.Size = new System.Drawing.Size(182, 25);
            this.txt_personalBr.TabIndex = 33;
            // 
            // lbl_otkaz
            // 
            this.lbl_otkaz.AutoSize = true;
            this.lbl_otkaz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_otkaz.Location = new System.Drawing.Point(356, 81);
            this.lbl_otkaz.Name = "lbl_otkaz";
            this.lbl_otkaz.Size = new System.Drawing.Size(44, 17);
            this.lbl_otkaz.TabIndex = 36;
            this.lbl_otkaz.Text = "Otkaz:";
            // 
            // dtp_otkaz
            // 
            this.dtp_otkaz.Location = new System.Drawing.Point(406, 77);
            this.dtp_otkaz.Name = "dtp_otkaz";
            this.dtp_otkaz.Size = new System.Drawing.Size(182, 22);
            this.dtp_otkaz.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(406, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(352, 25);
            this.textBox2.TabIndex = 37;
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(315, 188);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(85, 17);
            this.lbl_pretrazivanje.TabIndex = 38;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // Djelatnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 621);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.lbl_otkaz);
            this.Controls.Add(this.dtp_otkaz);
            this.Controls.Add(this.lbl_personalNr);
            this.Controls.Add(this.txt_personalBr);
            this.Controls.Add(this.lbk_oib);
            this.Controls.Add(this.txt_oib);
            this.Controls.Add(this.btn_izmjeni);
            this.Controls.Add(this.btn_spremi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_zaposlenDatum);
            this.Controls.Add(this.dtp_zaposlen);
            this.Controls.Add(this.lbl_trenutniKorisnik);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbl_ime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Djelatnici";
            this.Text = "Djelatnici";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_zaposlenDatum;
        private System.Windows.Forms.DateTimePicker dtp_zaposlen;
        private System.Windows.Forms.Label lbl_trenutniKorisnik;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Button btn_izmjeni;
        private System.Windows.Forms.Button btn_spremi;
        private System.Windows.Forms.Label lbk_oib;
        private System.Windows.Forms.TextBox txt_oib;
        private System.Windows.Forms.Label lbl_personalNr;
        private System.Windows.Forms.TextBox txt_personalBr;
        private System.Windows.Forms.Label lbl_otkaz;
        private System.Windows.Forms.DateTimePicker dtp_otkaz;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_pretrazivanje;
    }
}