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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lbl_zaposlenDatum = new System.Windows.Forms.Label();
            this.dtpZaposlen = new System.Windows.Forms.DateTimePicker();
            this.lbl_trenutniKorisnik = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.btn_izmjeni = new System.Windows.Forms.Button();
            this.btn_spremi = new System.Windows.Forms.Button();
            this.lbk_oib = new System.Windows.Forms.Label();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.lbl_otkaz = new System.Windows.Forms.Label();
            this.dtpOtkaz = new System.Windows.Forms.DateTimePicker();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.menuOstaleForme = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmjeniUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOdjel = new System.Windows.Forms.Label();
            this.txtOdjel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuOstaleForme.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(78, 50);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(182, 25);
            this.txtIme.TabIndex = 1;
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
            // dtpZaposlen
            // 
            this.dtpZaposlen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpZaposlen.Location = new System.Drawing.Point(406, 49);
            this.dtpZaposlen.Name = "dtpZaposlen";
            this.dtpZaposlen.Size = new System.Drawing.Size(182, 22);
            this.dtpZaposlen.TabIndex = 5;
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
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(78, 81);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(182, 25);
            this.txtPrezime.TabIndex = 2;
            // 
            // dgv
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 215);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(860, 395);
            this.dgv.TabIndex = 20;
            this.dgv.TabStop = false;
            this.dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_RowHeaderMouseDoubleClick);
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
            this.btn_izmjeni.Location = new System.Drawing.Point(670, 76);
            this.btn_izmjeni.Name = "btn_izmjeni";
            this.btn_izmjeni.Size = new System.Drawing.Size(88, 25);
            this.btn_izmjeni.TabIndex = 30;
            this.btn_izmjeni.TabStop = false;
            this.btn_izmjeni.Text = "Izmjeni (F3)";
            this.btn_izmjeni.UseVisualStyleBackColor = true;
            this.btn_izmjeni.Click += new System.EventHandler(this.Btn_izmjeni_Click);
            // 
            // btn_spremi
            // 
            this.btn_spremi.Location = new System.Drawing.Point(670, 48);
            this.btn_spremi.Name = "btn_spremi";
            this.btn_spremi.Size = new System.Drawing.Size(88, 25);
            this.btn_spremi.TabIndex = 29;
            this.btn_spremi.TabStop = false;
            this.btn_spremi.Text = "Spremi (F4)";
            this.btn_spremi.UseVisualStyleBackColor = true;
            this.btn_spremi.Click += new System.EventHandler(this.Btn_spremi_Click);
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
            // txtOib
            // 
            this.txtOib.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOib.Location = new System.Drawing.Point(78, 112);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(182, 25);
            this.txtOib.TabIndex = 3;
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
            // dtpOtkaz
            // 
            this.dtpOtkaz.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOtkaz.Location = new System.Drawing.Point(406, 77);
            this.dtpOtkaz.Name = "dtpOtkaz";
            this.dtpOtkaz.Size = new System.Drawing.Size(182, 22);
            this.dtpOtkaz.TabIndex = 35;
            this.dtpOtkaz.TabStop = false;
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretrazivanje.Location = new System.Drawing.Point(406, 184);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(352, 25);
            this.txtPretrazivanje.TabIndex = 37;
            this.txtPretrazivanje.TabStop = false;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.TxtPretrazivanje_TextChanged);
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
            // menuOstaleForme
            // 
            this.menuOstaleForme.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOstaleForme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuOstaleForme.Location = new System.Drawing.Point(0, 0);
            this.menuOstaleForme.Name = "menuOstaleForme";
            this.menuOstaleForme.Size = new System.Drawing.Size(884, 28);
            this.menuOstaleForme.TabIndex = 39;
            this.menuOstaleForme.Text = "menuOstaleForme";
            this.menuOstaleForme.Visible = false;
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spremiUnosToolStripMenuItem,
            this.izmjeniUnosToolStripMenuItem});
            this.datotekaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // spremiUnosToolStripMenuItem
            // 
            this.spremiUnosToolStripMenuItem.Name = "spremiUnosToolStripMenuItem";
            this.spremiUnosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.spremiUnosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.spremiUnosToolStripMenuItem.Text = "Spremi unos ";
            this.spremiUnosToolStripMenuItem.Click += new System.EventHandler(this.SpremiUnosToolStripMenuItem_Click);
            // 
            // izmjeniUnosToolStripMenuItem
            // 
            this.izmjeniUnosToolStripMenuItem.Name = "izmjeniUnosToolStripMenuItem";
            this.izmjeniUnosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.izmjeniUnosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.izmjeniUnosToolStripMenuItem.Text = "Izmjeni unos";
            this.izmjeniUnosToolStripMenuItem.Click += new System.EventHandler(this.IzmjeniUnosToolStripMenuItem_Click);
            // 
            // lblOdjel
            // 
            this.lblOdjel.AutoSize = true;
            this.lblOdjel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdjel.Location = new System.Drawing.Point(358, 112);
            this.lblOdjel.Name = "lblOdjel";
            this.lblOdjel.Size = new System.Drawing.Size(42, 17);
            this.lblOdjel.TabIndex = 41;
            this.lblOdjel.Text = "Odjel:";
            // 
            // txtOdjel
            // 
            this.txtOdjel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOdjel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOdjel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOdjel.Location = new System.Drawing.Point(406, 108);
            this.txtOdjel.Name = "txtOdjel";
            this.txtOdjel.Size = new System.Drawing.Size(182, 25);
            this.txtOdjel.TabIndex = 4;
            // 
            // Djelatnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 621);
            this.Controls.Add(this.lblOdjel);
            this.Controls.Add(this.txtOdjel);
            this.Controls.Add(this.menuOstaleForme);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.lbl_otkaz);
            this.Controls.Add(this.dtpOtkaz);
            this.Controls.Add(this.lbk_oib);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.btn_izmjeni);
            this.Controls.Add(this.btn_spremi);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lbl_zaposlenDatum);
            this.Controls.Add(this.dtpZaposlen);
            this.Controls.Add(this.lbl_trenutniKorisnik);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbl_ime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Djelatnici";
            this.Text = "Djelatnici";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuOstaleForme.ResumeLayout(false);
            this.menuOstaleForme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lbl_zaposlenDatum;
        private System.Windows.Forms.DateTimePicker dtpZaposlen;
        private System.Windows.Forms.Label lbl_trenutniKorisnik;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Button btn_izmjeni;
        private System.Windows.Forms.Button btn_spremi;
        private System.Windows.Forms.Label lbk_oib;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.Label lbl_otkaz;
        private System.Windows.Forms.DateTimePicker dtpOtkaz;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lbl_pretrazivanje;
        private System.Windows.Forms.MenuStrip menuOstaleForme;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmjeniUnosToolStripMenuItem;
        private System.Windows.Forms.Label lblOdjel;
        private System.Windows.Forms.TextBox txtOdjel;
    }
}