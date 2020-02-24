namespace ZIRO
{
    partial class form_ZiRO
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
            this.karticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGLforma.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGLforma
            // 
            this.menuGLforma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGLforma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.karticeToolStripMenuItem,
            this.pomoćToolStripMenuItem,
            this.pomoćToolStripMenuItem1});
            this.menuGLforma.Location = new System.Drawing.Point(0, 0);
            this.menuGLforma.Name = "menuGLforma";
            this.menuGLforma.Size = new System.Drawing.Size(934, 25);
            this.menuGLforma.TabIndex = 0;
            this.menuGLforma.Text = "menuGLforma";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // karticeToolStripMenuItem
            // 
            this.karticeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.karticeToolStripMenuItem.Name = "karticeToolStripMenuItem";
            this.karticeToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.karticeToolStripMenuItem.Text = "Uredi";
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
            this.pomoćToolStripMenuItem.Text = "Baza podataka";
            // 
            // pomoćToolStripMenuItem1
            // 
            this.pomoćToolStripMenuItem1.Name = "pomoćToolStripMenuItem1";
            this.pomoćToolStripMenuItem1.Size = new System.Drawing.Size(60, 21);
            this.pomoćToolStripMenuItem1.Text = "Pomoć";
            // 
            // form_ZiRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 691);
            this.Controls.Add(this.menuGLforma);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuGLforma;
            this.Name = "form_ZiRO";
            this.Text = "ZiRO";
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
    }
}

