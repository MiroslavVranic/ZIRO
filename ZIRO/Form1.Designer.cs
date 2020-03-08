namespace ZIRO
{
    partial class Form_ZiRO
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
            this.menuGLforma = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriZiRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izađiIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.karticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDleatnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajOdjelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajInventarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventurnaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaZaRashodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGLforma.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGLforma
            // 
            this.menuGLforma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGLforma.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuGLforma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.karticeToolStripMenuItem,
            this.pomoćToolStripMenuItem,
            this.pomoćToolStripMenuItem1});
            this.menuGLforma.Location = new System.Drawing.Point(0, 0);
            this.menuGLforma.Name = "menuGLforma";
            this.menuGLforma.Size = new System.Drawing.Size(1245, 31);
            this.menuGLforma.TabIndex = 0;
            this.menuGLforma.Text = "menuGLforma";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otvoriZiRToolStripMenuItem,
            this.toolStripSeparator1,
            this.zatvoriToolStripMenuItem,
            this.izađiIzAplikacijeToolStripMenuItem,
            this.toolStripSeparator2});
            this.datotekaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // otvoriZiRToolStripMenuItem
            // 
            this.otvoriZiRToolStripMenuItem.Name = "otvoriZiRToolStripMenuItem";
            this.otvoriZiRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.otvoriZiRToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.otvoriZiRToolStripMenuItem.Text = "Otvori ZiR";
            this.otvoriZiRToolStripMenuItem.Click += new System.EventHandler(this.OtvoriZiRToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(278, 6);
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.ZatvoriToolStripMenuItem_Click);
            // 
            // izađiIzAplikacijeToolStripMenuItem
            // 
            this.izađiIzAplikacijeToolStripMenuItem.Name = "izađiIzAplikacijeToolStripMenuItem";
            this.izađiIzAplikacijeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.izađiIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(281, 28);
            this.izađiIzAplikacijeToolStripMenuItem.Text = "Izađi iz aplikacije";
            this.izađiIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.IzađiIzAplikacijeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(278, 6);
            // 
            // karticeToolStripMenuItem
            // 
            this.karticeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajDleatnikaToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem,
            this.dodajOdjelToolStripMenuItem,
            this.dodajInventarToolStripMenuItem});
            this.karticeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.karticeToolStripMenuItem.Name = "karticeToolStripMenuItem";
            this.karticeToolStripMenuItem.Size = new System.Drawing.Size(65, 27);
            this.karticeToolStripMenuItem.Text = "Uredi";
            // 
            // dodajDleatnikaToolStripMenuItem
            // 
            this.dodajDleatnikaToolStripMenuItem.Name = "dodajDleatnikaToolStripMenuItem";
            this.dodajDleatnikaToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.dodajDleatnikaToolStripMenuItem.Text = "Dodaj djelatnika";
            this.dodajDleatnikaToolStripMenuItem.Click += new System.EventHandler(this.DodajDjelatnikaToolStripMenuItem_Click);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.DodajKorisnikaToolStripMenuItem_Click);
            // 
            // dodajOdjelToolStripMenuItem
            // 
            this.dodajOdjelToolStripMenuItem.Name = "dodajOdjelToolStripMenuItem";
            this.dodajOdjelToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.dodajOdjelToolStripMenuItem.Text = "Dodaj odjel";
            this.dodajOdjelToolStripMenuItem.Click += new System.EventHandler(this.DodajOdjelToolStripMenuItem_Click);
            // 
            // dodajInventarToolStripMenuItem
            // 
            this.dodajInventarToolStripMenuItem.Name = "dodajInventarToolStripMenuItem";
            this.dodajInventarToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.dodajInventarToolStripMenuItem.Text = "Dodaj inventar";
            this.dodajInventarToolStripMenuItem.Click += new System.EventHandler(this.DodajInventarToolStripMenuItem_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventurnaListaToolStripMenuItem,
            this.listaZaRashodToolStripMenuItem});
            this.pomoćToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(136, 27);
            this.pomoćToolStripMenuItem.Text = "Baza podataka";
            // 
            // inventurnaListaToolStripMenuItem
            // 
            this.inventurnaListaToolStripMenuItem.Name = "inventurnaListaToolStripMenuItem";
            this.inventurnaListaToolStripMenuItem.Size = new System.Drawing.Size(212, 28);
            this.inventurnaListaToolStripMenuItem.Text = "Inventurna lista";
            // 
            // listaZaRashodToolStripMenuItem
            // 
            this.listaZaRashodToolStripMenuItem.Name = "listaZaRashodToolStripMenuItem";
            this.listaZaRashodToolStripMenuItem.Size = new System.Drawing.Size(212, 28);
            this.listaZaRashodToolStripMenuItem.Text = "Lista za rashod";
            // 
            // pomoćToolStripMenuItem1
            // 
            this.pomoćToolStripMenuItem1.Name = "pomoćToolStripMenuItem1";
            this.pomoćToolStripMenuItem1.Size = new System.Drawing.Size(76, 27);
            this.pomoćToolStripMenuItem1.Text = "Pomoć";
            // 
            // Form_ZiRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 850);
            this.Controls.Add(this.menuGLforma);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuGLforma;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_ZiRO";
            this.Text = "ZiRO";
            this.Load += new System.EventHandler(this.Form_ZiRO_Load);
            this.menuGLforma.ResumeLayout(false);
            this.menuGLforma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGLforma;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem otvoriZiRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izađiIzAplikacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajDleatnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajOdjelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajInventarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventurnaListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaZaRashodToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

