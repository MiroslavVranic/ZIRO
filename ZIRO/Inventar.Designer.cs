namespace ZIRO
{
    partial class Inventar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNazivOpreme = new System.Windows.Forms.TextBox();
            this.lbl_kupljenoDatum = new System.Windows.Forms.Label();
            this.dtpKupljeno = new System.Windows.Forms.DateTimePicker();
            this.lbl_trenutniKorisnik = new System.Windows.Forms.Label();
            this.btn_izmjeni = new System.Windows.Forms.Button();
            this.btn_spremi = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbl_nazivOpreme = new System.Windows.Forms.Label();
            this.txtSerijskiBroj = new System.Windows.Forms.TextBox();
            this.lbl_serBr = new System.Windows.Forms.Label();
            this.lbl_invBroj = new System.Windows.Forms.Label();
            this.txtInvBroj = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.cmbVrstaOpreme = new System.Windows.Forms.ComboBox();
            this.lbl_rashodDatum = new System.Windows.Forms.Label();
            this.dtpRashodovano = new System.Windows.Forms.DateTimePicker();
            this.lbl_vrsta = new System.Windows.Forms.Label();
            this.lbl_pretrazi = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.menuOstaleForme = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmjeniUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBrisanjeRashoda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuOstaleForme.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNazivOpreme
            // 
            this.txtNazivOpreme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivOpreme.Location = new System.Drawing.Point(78, 81);
            this.txtNazivOpreme.Name = "txtNazivOpreme";
            this.txtNazivOpreme.Size = new System.Drawing.Size(182, 25);
            this.txtNazivOpreme.TabIndex = 18;
            // 
            // lbl_kupljenoDatum
            // 
            this.lbl_kupljenoDatum.AutoSize = true;
            this.lbl_kupljenoDatum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kupljenoDatum.Location = new System.Drawing.Point(447, 55);
            this.lbl_kupljenoDatum.Name = "lbl_kupljenoDatum";
            this.lbl_kupljenoDatum.Size = new System.Drawing.Size(62, 17);
            this.lbl_kupljenoDatum.TabIndex = 28;
            this.lbl_kupljenoDatum.Text = "Kupljeno:";
            // 
            // dtpKupljeno
            // 
            this.dtpKupljeno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKupljeno.Location = new System.Drawing.Point(515, 52);
            this.dtpKupljeno.Name = "dtpKupljeno";
            this.dtpKupljeno.Size = new System.Drawing.Size(182, 22);
            this.dtpKupljeno.TabIndex = 27;
            // 
            // lbl_trenutniKorisnik
            // 
            this.lbl_trenutniKorisnik.AutoSize = true;
            this.lbl_trenutniKorisnik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trenutniKorisnik.Location = new System.Drawing.Point(12, 22);
            this.lbl_trenutniKorisnik.Name = "lbl_trenutniKorisnik";
            this.lbl_trenutniKorisnik.Size = new System.Drawing.Size(0, 17);
            this.lbl_trenutniKorisnik.TabIndex = 26;
            // 
            // btn_izmjeni
            // 
            this.btn_izmjeni.Location = new System.Drawing.Point(703, 84);
            this.btn_izmjeni.Name = "btn_izmjeni";
            this.btn_izmjeni.Size = new System.Drawing.Size(88, 25);
            this.btn_izmjeni.TabIndex = 23;
            this.btn_izmjeni.Text = "Izmjeni (F3)";
            this.btn_izmjeni.UseVisualStyleBackColor = true;
            this.btn_izmjeni.Click += new System.EventHandler(this.Btn_izmjeni_Click);
            // 
            // btn_spremi
            // 
            this.btn_spremi.Location = new System.Drawing.Point(703, 51);
            this.btn_spremi.Name = "btn_spremi";
            this.btn_spremi.Size = new System.Drawing.Size(88, 25);
            this.btn_spremi.TabIndex = 22;
            this.btn_spremi.Text = "Spremi (F4)";
            this.btn_spremi.UseVisualStyleBackColor = true;
            this.btn_spremi.Click += new System.EventHandler(this.Btn_spremi_Click);
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_RowHeaderMouseClick);
            // 
            // lbl_nazivOpreme
            // 
            this.lbl_nazivOpreme.AutoSize = true;
            this.lbl_nazivOpreme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nazivOpreme.Location = new System.Drawing.Point(29, 85);
            this.lbl_nazivOpreme.Name = "lbl_nazivOpreme";
            this.lbl_nazivOpreme.Size = new System.Drawing.Size(43, 17);
            this.lbl_nazivOpreme.TabIndex = 19;
            this.lbl_nazivOpreme.Text = "Naziv:";
            // 
            // txtSerijskiBroj
            // 
            this.txtSerijskiBroj.Location = new System.Drawing.Point(78, 114);
            this.txtSerijskiBroj.Name = "txtSerijskiBroj";
            this.txtSerijskiBroj.Size = new System.Drawing.Size(182, 22);
            this.txtSerijskiBroj.TabIndex = 29;
            // 
            // lbl_serBr
            // 
            this.lbl_serBr.AutoSize = true;
            this.lbl_serBr.Location = new System.Drawing.Point(26, 117);
            this.lbl_serBr.Name = "lbl_serBr";
            this.lbl_serBr.Size = new System.Drawing.Size(46, 16);
            this.lbl_serBr.TabIndex = 30;
            this.lbl_serBr.Text = "SR Br:";
            // 
            // lbl_invBroj
            // 
            this.lbl_invBroj.AutoSize = true;
            this.lbl_invBroj.Location = new System.Drawing.Point(23, 147);
            this.lbl_invBroj.Name = "lbl_invBroj";
            this.lbl_invBroj.Size = new System.Drawing.Size(49, 16);
            this.lbl_invBroj.TabIndex = 31;
            this.lbl_invBroj.Text = "Inv. br.:";
            // 
            // txtInvBroj
            // 
            this.txtInvBroj.Location = new System.Drawing.Point(78, 144);
            this.txtInvBroj.Name = "txtInvBroj";
            this.txtInvBroj.ReadOnly = true;
            this.txtInvBroj.Size = new System.Drawing.Size(182, 22);
            this.txtInvBroj.TabIndex = 32;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(78, 51);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(182, 22);
            this.txtID.TabIndex = 33;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(48, 54);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(24, 16);
            this.lbl_id.TabIndex = 34;
            this.lbl_id.Text = "ID:";
            // 
            // cmbVrstaOpreme
            // 
            this.cmbVrstaOpreme.FormattingEnabled = true;
            this.cmbVrstaOpreme.Location = new System.Drawing.Point(515, 118);
            this.cmbVrstaOpreme.Name = "cmbVrstaOpreme";
            this.cmbVrstaOpreme.Size = new System.Drawing.Size(182, 24);
            this.cmbVrstaOpreme.TabIndex = 35;
            // 
            // lbl_rashodDatum
            // 
            this.lbl_rashodDatum.AutoSize = true;
            this.lbl_rashodDatum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rashodDatum.Location = new System.Drawing.Point(410, 88);
            this.lbl_rashodDatum.Name = "lbl_rashodDatum";
            this.lbl_rashodDatum.Size = new System.Drawing.Size(99, 17);
            this.lbl_rashodDatum.TabIndex = 37;
            this.lbl_rashodDatum.Text = "Rasohodovano:";
            // 
            // dtpRashodovano
            // 
            this.dtpRashodovano.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRashodovano.Location = new System.Drawing.Point(515, 85);
            this.dtpRashodovano.Name = "dtpRashodovano";
            this.dtpRashodovano.Size = new System.Drawing.Size(182, 22);
            this.dtpRashodovano.TabIndex = 36;
            // 
            // lbl_vrsta
            // 
            this.lbl_vrsta.AutoSize = true;
            this.lbl_vrsta.Location = new System.Drawing.Point(467, 122);
            this.lbl_vrsta.Name = "lbl_vrsta";
            this.lbl_vrsta.Size = new System.Drawing.Size(42, 16);
            this.lbl_vrsta.TabIndex = 38;
            this.lbl_vrsta.Text = "Vrsta:";
            // 
            // lbl_pretrazi
            // 
            this.lbl_pretrazi.AutoSize = true;
            this.lbl_pretrazi.Location = new System.Drawing.Point(313, 175);
            this.lbl_pretrazi.Name = "lbl_pretrazi";
            this.lbl_pretrazi.Size = new System.Drawing.Size(56, 16);
            this.lbl_pretrazi.TabIndex = 39;
            this.lbl_pretrazi.Text = "Pretraži:";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(375, 172);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(322, 22);
            this.txtPretrazi.TabIndex = 40;
            // 
            // menuOstaleForme
            // 
            this.menuOstaleForme.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOstaleForme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuOstaleForme.Location = new System.Drawing.Point(0, 0);
            this.menuOstaleForme.Name = "menuOstaleForme";
            this.menuOstaleForme.Size = new System.Drawing.Size(884, 24);
            this.menuOstaleForme.TabIndex = 41;
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
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // spremiUnosToolStripMenuItem
            // 
            this.spremiUnosToolStripMenuItem.Name = "spremiUnosToolStripMenuItem";
            this.spremiUnosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.spremiUnosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.spremiUnosToolStripMenuItem.Text = "Spremi unos ";
            // 
            // izmjeniUnosToolStripMenuItem
            // 
            this.izmjeniUnosToolStripMenuItem.Name = "izmjeniUnosToolStripMenuItem";
            this.izmjeniUnosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.izmjeniUnosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.izmjeniUnosToolStripMenuItem.Text = "Izmjeni unos";
            // 
            // btnBrisanjeRashoda
            // 
            this.btnBrisanjeRashoda.Location = new System.Drawing.Point(703, 118);
            this.btnBrisanjeRashoda.Name = "btnBrisanjeRashoda";
            this.btnBrisanjeRashoda.Size = new System.Drawing.Size(88, 45);
            this.btnBrisanjeRashoda.TabIndex = 42;
            this.btnBrisanjeRashoda.Text = "Brisanje rashoda";
            this.btnBrisanjeRashoda.UseVisualStyleBackColor = true;
            this.btnBrisanjeRashoda.Click += new System.EventHandler(this.BtnBrisanjeRashoda_Click);
            // 
            // Inventar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 621);
            this.Controls.Add(this.btnBrisanjeRashoda);
            this.Controls.Add(this.menuOstaleForme);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lbl_pretrazi);
            this.Controls.Add(this.lbl_vrsta);
            this.Controls.Add(this.lbl_rashodDatum);
            this.Controls.Add(this.dtpRashodovano);
            this.Controls.Add(this.cmbVrstaOpreme);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtInvBroj);
            this.Controls.Add(this.lbl_invBroj);
            this.Controls.Add(this.lbl_serBr);
            this.Controls.Add(this.txtSerijskiBroj);
            this.Controls.Add(this.txtNazivOpreme);
            this.Controls.Add(this.lbl_kupljenoDatum);
            this.Controls.Add(this.dtpKupljeno);
            this.Controls.Add(this.lbl_trenutniKorisnik);
            this.Controls.Add(this.btn_izmjeni);
            this.Controls.Add(this.btn_spremi);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbl_nazivOpreme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventar";
            this.Text = "Inventar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuOstaleForme.ResumeLayout(false);
            this.menuOstaleForme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazivOpreme;
        private System.Windows.Forms.Label lbl_kupljenoDatum;
        private System.Windows.Forms.DateTimePicker dtpKupljeno;
        private System.Windows.Forms.Label lbl_trenutniKorisnik;
        private System.Windows.Forms.Button btn_izmjeni;
        private System.Windows.Forms.Button btn_spremi;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbl_nazivOpreme;
        private System.Windows.Forms.TextBox txtSerijskiBroj;
        private System.Windows.Forms.Label lbl_serBr;
        private System.Windows.Forms.Label lbl_invBroj;
        private System.Windows.Forms.TextBox txtInvBroj;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.ComboBox cmbVrstaOpreme;
        private System.Windows.Forms.Label lbl_rashodDatum;
        private System.Windows.Forms.DateTimePicker dtpRashodovano;
        private System.Windows.Forms.Label lbl_vrsta;
        private System.Windows.Forms.Label lbl_pretrazi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.MenuStrip menuOstaleForme;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmjeniUnosToolStripMenuItem;
        private System.Windows.Forms.Button btnBrisanjeRashoda;
    }
}