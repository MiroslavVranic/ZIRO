namespace ZIRO
{
    partial class Odjeli
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
            this.txt_odjel = new System.Windows.Forms.TextBox();
            this.lbl_trenutniKorisnik = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_izmjeni = new System.Windows.Forms.Button();
            this.btn_spremi = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbl_djelatnik = new System.Windows.Forms.Label();
            this.txt_pretrazivanje = new System.Windows.Forms.TextBox();
            this.lbl_pretrazivanje = new System.Windows.Forms.Label();
            this.menuOstaleForme = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmjeniUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuOstaleForme.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_odjel
            // 
            this.txt_odjel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_odjel.Location = new System.Drawing.Point(78, 86);
            this.txt_odjel.Name = "txt_odjel";
            this.txt_odjel.Size = new System.Drawing.Size(182, 29);
            this.txt_odjel.TabIndex = 18;
            // 
            // lbl_trenutniKorisnik
            // 
            this.lbl_trenutniKorisnik.AutoSize = true;
            this.lbl_trenutniKorisnik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trenutniKorisnik.Location = new System.Drawing.Point(12, 27);
            this.lbl_trenutniKorisnik.Name = "lbl_trenutniKorisnik";
            this.lbl_trenutniKorisnik.Size = new System.Drawing.Size(0, 23);
            this.lbl_trenutniKorisnik.TabIndex = 26;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(15, 53);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(31, 23);
            this.lbl_id.TabIndex = 25;
            this.lbl_id.Text = "ID:";
            // 
            // btn_izmjeni
            // 
            this.btn_izmjeni.Location = new System.Drawing.Point(271, 96);
            this.btn_izmjeni.Name = "btn_izmjeni";
            this.btn_izmjeni.Size = new System.Drawing.Size(88, 43);
            this.btn_izmjeni.TabIndex = 23;
            this.btn_izmjeni.Text = "Izmjeni";
            this.btn_izmjeni.UseVisualStyleBackColor = true;
            this.btn_izmjeni.Click += new System.EventHandler(this.btn_izmjeni_Click);
            // 
            // btn_spremi
            // 
            this.btn_spremi.Location = new System.Drawing.Point(271, 50);
            this.btn_spremi.Name = "btn_spremi";
            this.btn_spremi.Size = new System.Drawing.Size(88, 43);
            this.btn_spremi.TabIndex = 22;
            this.btn_spremi.Text = "Spremi";
            this.btn_spremi.UseVisualStyleBackColor = true;
            this.btn_spremi.Click += new System.EventHandler(this.Btn_spremi_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(78, 50);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(182, 29);
            this.txt_id.TabIndex = 21;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 215);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(860, 395);
            this.dgv.TabIndex = 20;
            this.dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseDoubleClick);
            // 
            // lbl_djelatnik
            // 
            this.lbl_djelatnik.AutoSize = true;
            this.lbl_djelatnik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_djelatnik.Location = new System.Drawing.Point(12, 90);
            this.lbl_djelatnik.Name = "lbl_djelatnik";
            this.lbl_djelatnik.Size = new System.Drawing.Size(56, 23);
            this.lbl_djelatnik.TabIndex = 19;
            this.lbl_djelatnik.Text = "Naziv:";
            // 
            // txt_pretrazivanje
            // 
            this.txt_pretrazivanje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pretrazivanje.Location = new System.Drawing.Point(113, 184);
            this.txt_pretrazivanje.Name = "txt_pretrazivanje";
            this.txt_pretrazivanje.Size = new System.Drawing.Size(366, 29);
            this.txt_pretrazivanje.TabIndex = 27;
            this.txt_pretrazivanje.TextChanged += new System.EventHandler(this.txt_pretrazivanje_TextChanged_1);
            // 
            // lbl_pretrazivanje
            // 
            this.lbl_pretrazivanje.AutoSize = true;
            this.lbl_pretrazivanje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pretrazivanje.Location = new System.Drawing.Point(14, 188);
            this.lbl_pretrazivanje.Name = "lbl_pretrazivanje";
            this.lbl_pretrazivanje.Size = new System.Drawing.Size(112, 23);
            this.lbl_pretrazivanje.TabIndex = 28;
            this.lbl_pretrazivanje.Text = "Pretraživanje:";
            // 
            // menuOstaleForme
            // 
            this.menuOstaleForme.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOstaleForme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem});
            this.menuOstaleForme.Location = new System.Drawing.Point(0, 0);
            this.menuOstaleForme.Name = "menuOstaleForme";
            this.menuOstaleForme.Size = new System.Drawing.Size(884, 24);
            this.menuOstaleForme.TabIndex = 29;
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
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // spremiUnosToolStripMenuItem
            // 
            this.spremiUnosToolStripMenuItem.Name = "spremiUnosToolStripMenuItem";
            this.spremiUnosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.spremiUnosToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.spremiUnosToolStripMenuItem.Text = "Spremi unos ";
            // 
            // izmjeniUnosToolStripMenuItem
            // 
            this.izmjeniUnosToolStripMenuItem.Name = "izmjeniUnosToolStripMenuItem";
            this.izmjeniUnosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.izmjeniUnosToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.izmjeniUnosToolStripMenuItem.Text = "Izmjeni unos";
            // 
            // Odjeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 621);
            this.Controls.Add(this.menuOstaleForme);
            this.Controls.Add(this.txt_pretrazivanje);
            this.Controls.Add(this.lbl_pretrazivanje);
            this.Controls.Add(this.txt_odjel);
            this.Controls.Add(this.lbl_trenutniKorisnik);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_izmjeni);
            this.Controls.Add(this.btn_spremi);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbl_djelatnik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Odjeli";
            this.Text = "Odjeli";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuOstaleForme.ResumeLayout(false);
            this.menuOstaleForme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_odjel;
        private System.Windows.Forms.Label lbl_trenutniKorisnik;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_izmjeni;
        private System.Windows.Forms.Button btn_spremi;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbl_djelatnik;
        private System.Windows.Forms.TextBox txt_pretrazivanje;
        private System.Windows.Forms.Label lbl_pretrazivanje;
        private System.Windows.Forms.MenuStrip menuOstaleForme;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmjeniUnosToolStripMenuItem;
    }
}