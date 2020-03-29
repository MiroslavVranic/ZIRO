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
    public partial class Form_ZiRO : Form
    {
        private void Form_ZiRO_Load(object sender, EventArgs e)
        {
            using (Login login = new Login())
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
                else
                {
                    Forma = new ZiR();
                    OtvoriFormu(Forma);
                    //string _korime = EditClass.KorisnickoIme;
                    //string IzTablice = "korisnici";
                    //string GdjeTrazim = "korisnickoIme";
                    //string Uloga = Uredi.UlogaUlogiranogKor(_korime, IzTablice, GdjeTrazim);
                    //if (Uloga == "Administrator")
                    //{
                    //    dodajKorisnikaToolStripMenuItem.Visible = true;
                    //    FormaKPP();
                    //}
                    //else
                    //    FormaKPP();
                }
            }
        }
        public Form_ZiRO()
        {
            InitializeComponent();
        }

        #region Otvaranje i zatvaranje GUI formi

        Form Forma { get; set; }
        public string Oib { get; set; }

        private void KreirajFormu(Form Forma)
        {
            Forma.Show();
            Forma.MdiParent = this;
            Forma.WindowState = FormWindowState.Maximized;
        }

        public void OtvoriFormu(Form Forma)
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

        private void DodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma = new Korisnici();
            OtvoriFormu(Forma);
        }

        private void DodajOdjelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma = new Odjeli();
            OtvoriFormu(Forma);
        }

        private void DodajInventarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma = new Inventar();
            OtvoriFormu(Forma);
        }

        private void InventurnaListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma = new Inventura();
            OtvoriFormu(Forma);
        }

        private void ListaZaRashodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forma = new Rashod();
            OtvoriFormu(Forma);
        }

        private void ZatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                this.Close();
            else
                ActiveMdiChild.Close();
        }

        private void IzađiIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion
    }
}
