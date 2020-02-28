using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIRO
{
    public partial class form_ZiRO : Form
    {
        public form_ZiRO()
        {
            InitializeComponent();
        }

        #region Otvaranje i zatvaranje GUI formi

        Form Forma { get; set; }

        private void KreirajFormu(Form Forma)
        {
            Forma.Show();
            Forma.MdiParent = this;
            Forma.WindowState = FormWindowState.Maximized;
        }

        private void OtvoriFormu(Form Forma)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                KreirajFormu(Forma);
            }
            else
                KreirajFormu(Forma);
        }

        private void OtvoriZiRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma = new ZiR();
            OtvoriFormu(Forma);
        }

        private void DodajDjelatnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma = new Djelatnici();
            OtvoriFormu(Forma);
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma = new Korisnici();
            OtvoriFormu(Forma);
        }

        private void dodajOdjelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma = new Odjeli();
            OtvoriFormu(Forma);
        }

        private void dodajInventarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma = new Inventar();
            OtvoriFormu(Forma);
        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                this.Close();
            else
                ActiveMdiChild.Close();
        }

        private void izađiIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}
