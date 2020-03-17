using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIRO
{
    public partial class Djelatnici : Form
    {
        readonly DataBase dbc = new DataBase();
        readonly UpitiDB upiti = new UpitiDB();
        readonly Pomocna pomocna = new Pomocna();

        public Djelatnici()
        {
            InitializeComponent();
            DGVfill();
            KolekcijaOdjeli();
        }

        // Punjenje DGV forme
        private void DGVfill()
        {
            string dbs = $"SELECT djelatnici.oib, djelatnici.ime, djelatnici.prezime, djelatnici.datZaposlenja, " +
                $"djelatnici.datOtkaza, odjeli.nazivOdjela FROM djelatnici LEFT JOIN odjeli ON odjeli.id = djelatnici.odjelID;";
            try
            { 
                dgv.DataSource = dbc.DGVselect(dbs);
            }
            catch(Exception ex) { MessageBox.Show($"Greška pri dohvačanju djelatnika\n{ex.Message}", pomocna.MsgNazivGreska); }
        }

        // Autocomplete lista za odjele
        private void KolekcijaOdjeli()
        {
            string odjel = "nazivOdjela";
            string dbAc = "SELECT nazivOdjela FROM odjeli";
            var acLista = dbc.Kolekcija(dbAc, odjel);
            txtOdjel.AutoCompleteCustomSource = acLista;
        }

        private void ProvjeraCelija()
        {
            if (String.IsNullOrWhiteSpace(txtIme.Text))
                pomocna.PraznaCelija(txtIme);
            else
                pomocna.OkCelija(txtIme);
            if (String.IsNullOrWhiteSpace(txtPrezime.Text))
                pomocna.PraznaCelija(txtPrezime);
            else
                pomocna.OkCelija(txtPrezime);
            if (String.IsNullOrWhiteSpace(txtOib.Text))
                pomocna.PraznaCelija(txtOib);
            else
                pomocna.OkCelija(txtOib);
            if (String.IsNullOrWhiteSpace(txtOdjel.Text))
                pomocna.PraznaCelija(txtOdjel);
            else
                pomocna.OkCelija(txtOdjel);
            MessageBox.Show(pomocna.MsgPorukaPraznaCelija, pomocna.MsgNazivPozor);
        }

        private void UspjesanUnos()
        {
            DGVfill();
            txtOib.Clear();
            txtIme.Clear();
            txtPrezime.Clear();
            txtOdjel.Clear();
            txtIme.Focus();
        }

        // Unos/Insert Djelatnika
        private void Btn_spremi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIme.Text) || String.IsNullOrWhiteSpace(txtPrezime.Text) 
                || String.IsNullOrWhiteSpace(txtOib.Text) || String.IsNullOrWhiteSpace(txtOdjel.Text))
            {
                ProvjeraCelija();
            }
            else
            {
                dbc.ForKey(txtOdjel.Text.Trim(), "odjeli", "nazivOdjela");
                if (dbc.StraniKljuc < 1)
                    MessageBox.Show($"Unešeni odjel ne postji u odjelima!");
                else
                {
                    string Unos = $"INSERT INTO djelatnici(oib, Ime, Prezime, datZaposlenja, odjelID) " +
                        $"VALUES(@oib, @Ime, @Prezime, @datZaposlenja, @odjelID)";
                    var Conn = new SqlConnection(dbc.strConnection);
                    var Cmd = new SqlCommand(Unos, Conn);
                    Cmd.Parameters.AddWithValue("@oib", txtOib.Text.Trim());
                    Cmd.Parameters.AddWithValue("@Ime", txtIme.Text.Trim());
                    Cmd.Parameters.AddWithValue("@Prezime", txtPrezime.Text.Trim());
                    Cmd.Parameters.AddWithValue("@datZaposlenja", DateTime.Parse(dtp_zaposlen.Text));
                    Cmd.Parameters.AddWithValue("@odjelID", dbc.StraniKljuc);
                    try
                    {
                        bool success = upiti.BoolUnos(Cmd, Conn);
                        if (success == true)
                        {
                            UspjesanUnos();
                        }
                        else
                            MessageBox.Show(pomocna.MsgPorukaInsertError, pomocna.MsgNazivGreska);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(pomocna.MsgPorukaInsertError + ex.Message, pomocna.MsgNazivGreska);
                    }
                }
            }
        }

        // Izmjena/Edit Djelatnika
        private void Btn_izmjeni_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIme.Text) || String.IsNullOrWhiteSpace(txtPrezime.Text)
                || String.IsNullOrWhiteSpace(txtOib.Text) || String.IsNullOrWhiteSpace(txtOdjel.Text))
            {
                ProvjeraCelija();            
            }
            else
            {
                dbc.ForKey(txtOdjel.Text.Trim(), "odjeli", "naziv");
                if (dbc.StraniKljuc < 1)
                    MessageBox.Show($"Nepostojeći odjel u tablici odjela!");
                else
                {
                    string Uredi = $"UPDATE djelatnici SET [Ime]=?, [Prezime]=?, [datZaposlenja]=?, [idOdjeli]=? WHERE [Oib] =?";
                    var Conn = new SqlConnection(dbc.strConnection);
                    var Cmd = new SqlCommand(Uredi, Conn);
                    Cmd.Parameters.AddWithValue("@Ime", txtIme.Text.Trim());
                    Cmd.Parameters.AddWithValue("@Prezime", txtPrezime.Text.Trim());
                    Cmd.Parameters.AddWithValue("@datZaposlenja", DateTime.Parse(dtp_zaposlen.Text));
                    Cmd.Parameters.AddWithValue("@idOdjel", dbc.StraniKljuc);
                    Cmd.Parameters.AddWithValue("@oib", txtOib.Text.Trim());

                    try
                    {
                        bool success = upiti.BoolUnos(Cmd, Conn);
                        if (success == true)
                        {
                            UspjesanUnos();
                        }
                        else
                            MessageBox.Show(pomocna.MsgPorukaInsertError, pomocna.MsgNazivGreska);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(pomocna.MsgPorukaInsertError + ex.Message, pomocna.MsgNazivGreska);
                    }
                }
            }
        }

        // Odabir reda iz tablice za izmjene
        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtOib.Text = dgv.Rows[RowIndex].Cells[0].Value.ToString();
            txtIme.Text = dgv.Rows[RowIndex].Cells[1].Value.ToString();
            txtPrezime.Text = dgv.Rows[RowIndex].Cells[2].Value.ToString();
            dtp_zaposlen.Text = dgv.Rows[RowIndex].Cells[3].Value.ToString();
            txtOdjel.Text = dgv.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void TxtPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            (dgv.DataSource as DataTable).DefaultView.RowFilter = 
                string.Format($"Ime LIKE '%{ txtPretrazivanje.Text.Trim() }%' OR Prezime LIKE '%{ txtPretrazivanje.Text.Trim() }%' " +
                $"OR oib LIKE '%{ txtPretrazivanje.Text.Trim() }%' OR naziv LIKE '%{ txtPretrazivanje.Text.Trim() }%'");
            if (dgv.Rows[0].Cells[0].Value == null) { return; }
        }

        private void SpremiUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_spremi.PerformClick();
        }

        private void IzmjeniUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_izmjeni.PerformClick();
        }

        private void BtnKorisnik_Click(object sender, EventArgs e)
        {
            Korisnici korisnici = new Korisnici();
            korisnici.Show();
            korisnici.MdiParent = this.MdiParent;
            korisnici.WindowState = FormWindowState.Maximized;
            this.Close();
        }
    }
}
