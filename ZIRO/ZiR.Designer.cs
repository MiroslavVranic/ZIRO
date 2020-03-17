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
            this.txtDjelatnik = new System.Windows.Forms.TextBox();
            this.lbl_djelatnik = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtInventar = new System.Windows.Forms.TextBox();
            this.btn_zaduzi = new System.Windows.Forms.Button();
            this.btn_razduzi = new System.Windows.Forms.Button();
            this.btn_pretrazi = new System.Windows.Forms.Button();
            this.lbl_inventar = new System.Windows.Forms.Label();
            this.lbl_trenutniKorisnik = new System.Windows.Forms.Label();
            this.dtpZaduzen = new System.Windows.Forms.DateTimePicker();
            this.menuOstaleForme = new System.Windows.Forms.MenuStrip();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpRazduzen = new System.Windows.Forms.DateTimePicker();
            this.btnRevers = new System.Windows.Forms.Button();
            this.btnPovrat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDjelatnik
            // 
            this.txtDjelatnik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDjelatnik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDjelatnik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDjelatnik.Location = new System.Drawing.Point(75, 52);
            this.txtDjelatnik.Name = "txtDjelatnik";
            this.txtDjelatnik.Size = new System.Drawing.Size(160, 29);
            this.txtDjelatnik.TabIndex = 1;
            // 
            // lbl_djelatnik
            // 
            this.lbl_djelatnik.AutoSize = true;
            this.lbl_djelatnik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_djelatnik.Location = new System.Drawing.Point(10, 56);
            this.lbl_djelatnik.Name = "lbl_djelatnik";
            this.lbl_djelatnik.Size = new System.Drawing.Size(80, 23);
            this.lbl_djelatnik.TabIndex = 2;
            this.lbl_djelatnik.Text = "Djelatnik:";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(10, 227);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(752, 420);
            this.dgv.TabIndex = 3;
            // 
            // txtInventar
            // 
            this.txtInventar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtInventar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtInventar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventar.Location = new System.Drawing.Point(442, 52);
            this.txtInventar.Name = "txtInventar";
            this.txtInventar.Size = new System.Drawing.Size(215, 29);
            this.txtInventar.TabIndex = 7;
            // 
            // btn_zaduzi
            // 
            this.btn_zaduzi.Location = new System.Drawing.Point(548, 91);
            this.btn_zaduzi.Name = "btn_zaduzi";
            this.btn_zaduzi.Size = new System.Drawing.Size(109, 25);
            this.btn_zaduzi.TabIndex = 10;
            this.btn_zaduzi.Text = "Zaduži";
            this.btn_zaduzi.UseVisualStyleBackColor = true;
            this.btn_zaduzi.Click += new System.EventHandler(this.Btn_zaduzi_Click);
            // 
            // btn_razduzi
            // 
            this.btn_razduzi.Location = new System.Drawing.Point(548, 122);
            this.btn_razduzi.Name = "btn_razduzi";
            this.btn_razduzi.Size = new System.Drawing.Size(109, 25);
            this.btn_razduzi.TabIndex = 11;
            this.btn_razduzi.Text = "Razduži";
            this.btn_razduzi.UseVisualStyleBackColor = true;
            this.btn_razduzi.Click += new System.EventHandler(this.Btn_razduzi_Click);
            // 
            // btn_pretrazi
            // 
            this.btn_pretrazi.Location = new System.Drawing.Point(241, 52);
            this.btn_pretrazi.Name = "btn_pretrazi";
            this.btn_pretrazi.Size = new System.Drawing.Size(77, 95);
            this.btn_pretrazi.TabIndex = 12;
            this.btn_pretrazi.Text = "Pretraži";
            this.btn_pretrazi.UseVisualStyleBackColor = true;
            this.btn_pretrazi.Click += new System.EventHandler(this.Btn_pretrazi_Click);
            // 
            // lbl_inventar
            // 
            this.lbl_inventar.AutoSize = true;
            this.lbl_inventar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventar.Location = new System.Drawing.Point(372, 56);
            this.lbl_inventar.Name = "lbl_inventar";
            this.lbl_inventar.Size = new System.Drawing.Size(77, 23);
            this.lbl_inventar.TabIndex = 14;
            this.lbl_inventar.Text = "Inventar:";
            // 
            // lbl_trenutniKorisnik
            // 
            this.lbl_trenutniKorisnik.AutoSize = true;
            this.lbl_trenutniKorisnik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trenutniKorisnik.Location = new System.Drawing.Point(10, 10);
            this.lbl_trenutniKorisnik.Name = "lbl_trenutniKorisnik";
            this.lbl_trenutniKorisnik.Size = new System.Drawing.Size(0, 23);
            this.lbl_trenutniKorisnik.TabIndex = 15;
            // 
            // dtpZaduzen
            // 
            this.dtpZaduzen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpZaduzen.Location = new System.Drawing.Point(442, 91);
            this.dtpZaduzen.Name = "dtpZaduzen";
            this.dtpZaduzen.Size = new System.Drawing.Size(100, 29);
            this.dtpZaduzen.TabIndex = 16;
            // 
            // menuOstaleForme
            // 
            this.menuOstaleForme.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOstaleForme.Location = new System.Drawing.Point(0, 0);
            this.menuOstaleForme.Name = "menuOstaleForme";
            this.menuOstaleForme.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuOstaleForme.Size = new System.Drawing.Size(774, 26);
            this.menuOstaleForme.TabIndex = 18;
            this.menuOstaleForme.Text = "menuOstaleForme";
            this.menuOstaleForme.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Zaduženo",
            "Razduženo"});
            this.cmbStatus.Location = new System.Drawing.Point(75, 122);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(160, 29);
            this.cmbStatus.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(24, 126);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 23);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Status:";
            // 
            // dtpRazduzen
            // 
            this.dtpRazduzen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRazduzen.Location = new System.Drawing.Point(442, 122);
            this.dtpRazduzen.Name = "dtpRazduzen";
            this.dtpRazduzen.Size = new System.Drawing.Size(100, 29);
            this.dtpRazduzen.TabIndex = 21;
            // 
            // btnRevers
            // 
            this.btnRevers.Location = new System.Drawing.Point(291, 165);
            this.btnRevers.Name = "btnRevers";
            this.btnRevers.Size = new System.Drawing.Size(178, 25);
            this.btnRevers.TabIndex = 35;
            this.btnRevers.Text = "Izrada reversa";
            this.btnRevers.UseVisualStyleBackColor = true;
            this.btnRevers.Click += new System.EventHandler(this.BtnRevers_Click);
            // 
            // btnPovrat
            // 
            this.btnPovrat.Location = new System.Drawing.Point(479, 165);
            this.btnPovrat.Name = "btnPovrat";
            this.btnPovrat.Size = new System.Drawing.Size(178, 25);
            this.btnPovrat.TabIndex = 36;
            this.btnPovrat.Text = "Izrada povrata";
            this.btnPovrat.UseVisualStyleBackColor = true;
            // 
            // ZiR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 660);
            this.Controls.Add(this.btnPovrat);
            this.Controls.Add(this.btnRevers);
            this.Controls.Add(this.dtpRazduzen);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpZaduzen);
            this.Controls.Add(this.lbl_trenutniKorisnik);
            this.Controls.Add(this.lbl_inventar);
            this.Controls.Add(this.btn_pretrazi);
            this.Controls.Add(this.btn_razduzi);
            this.Controls.Add(this.btn_zaduzi);
            this.Controls.Add(this.txtInventar);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbl_djelatnik);
            this.Controls.Add(this.txtDjelatnik);
            this.Controls.Add(this.menuOstaleForme);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuOstaleForme;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZiR";
            this.Text = "ZiR";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDjelatnik;
        private System.Windows.Forms.Label lbl_djelatnik;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtInventar;
        private System.Windows.Forms.Button btn_zaduzi;
        private System.Windows.Forms.Button btn_razduzi;
        private System.Windows.Forms.Button btn_pretrazi;
        private System.Windows.Forms.Label lbl_inventar;
        private System.Windows.Forms.Label lbl_trenutniKorisnik;
        private System.Windows.Forms.DateTimePicker dtpZaduzen;
        private System.Windows.Forms.MenuStrip menuOstaleForme;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtpRazduzen;
        private System.Windows.Forms.Button btnRevers;
        private System.Windows.Forms.Button btnPovrat;
    }
}