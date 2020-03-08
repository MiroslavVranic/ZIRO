namespace ZIRO
{
    partial class Login
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
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPromjena = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.txtPromjena = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremiLozinku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(343, 66);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(184, 72);
            this.btnPrijava.TabIndex = 0;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // txtKorIme
            // 
            this.txtKorIme.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorIme.ForeColor = System.Drawing.Color.Silver;
            this.txtKorIme.Location = new System.Drawing.Point(93, 66);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(184, 33);
            this.txtKorIme.TabIndex = 1;
            this.txtKorIme.Text = "Unesi korisničko ime";
            this.txtKorIme.Enter += new System.EventHandler(this.TxtKorIme_Enter);
            this.txtKorIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKorIme_KeyPress);
            this.txtKorIme.Leave += new System.EventHandler(this.TxtKorIme_Leave);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.ForeColor = System.Drawing.Color.Silver;
            this.txtLozinka.Location = new System.Drawing.Point(93, 105);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(184, 33);
            this.txtLozinka.TabIndex = 2;
            this.txtLozinka.Text = "Unesi lozinku";
            this.txtLozinka.Enter += new System.EventHandler(this.TxtLozinka_Enter);
            this.txtLozinka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLozinka_KeyPress);
            this.txtLozinka.Leave += new System.EventHandler(this.TxtLozinka_Leave);
            // 
            // btnPromjena
            // 
            this.btnPromjena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromjena.Location = new System.Drawing.Point(93, 206);
            this.btnPromjena.Name = "btnPromjena";
            this.btnPromjena.Size = new System.Drawing.Size(184, 33);
            this.btnPromjena.TabIndex = 5;
            this.btnPromjena.Text = "Promjeni lozinku";
            this.btnPromjena.UseVisualStyleBackColor = true;
            this.btnPromjena.Click += new System.EventHandler(this.BtnPromjena_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlaz.Location = new System.Drawing.Point(343, 206);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(184, 33);
            this.btnIzlaz.TabIndex = 4;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.BtnIzlaz_Click);
            // 
            // txtPromjena
            // 
            this.txtPromjena.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromjena.ForeColor = System.Drawing.Color.Silver;
            this.txtPromjena.Location = new System.Drawing.Point(93, 144);
            this.txtPromjena.Name = "txtPromjena";
            this.txtPromjena.Size = new System.Drawing.Size(184, 33);
            this.txtPromjena.TabIndex = 3;
            this.txtPromjena.Text = "Ponovi lozinku";
            this.txtPromjena.Visible = false;
            this.txtPromjena.Enter += new System.EventHandler(this.TxtPromjena_Enter);
            this.txtPromjena.Leave += new System.EventHandler(this.TxtPromjena_Leave);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(93, 206);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(184, 33);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Visible = false;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // btnSpremiLozinku
            // 
            this.btnSpremiLozinku.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiLozinku.Location = new System.Drawing.Point(343, 66);
            this.btnSpremiLozinku.Name = "btnSpremiLozinku";
            this.btnSpremiLozinku.Size = new System.Drawing.Size(184, 72);
            this.btnSpremiLozinku.TabIndex = 7;
            this.btnSpremiLozinku.Text = "Spremi novu lozinku";
            this.btnSpremiLozinku.UseVisualStyleBackColor = true;
            this.btnSpremiLozinku.Visible = false;
            this.btnSpremiLozinku.Click += new System.EventHandler(this.BtnSpremiLozinku_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 298);
            this.Controls.Add(this.btnSpremiLozinku);
            this.Controls.Add(this.txtPromjena);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPromjena);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Prijava korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPromjena;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.TextBox txtPromjena;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremiLozinku;
    }
}