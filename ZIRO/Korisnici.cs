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
    public partial class Korisnici : Form
    {
        readonly DataBase dbc = new DataBase();
        readonly UpitiDB upiti = new UpitiDB();
        readonly Pomocna pomocna = new Pomocna();

        #region PROPERTIES
        public string DjelatniciOib { get; set; }

        public static Dictionary<string, string> Djelatnici = new Dictionary<string, string>();
        #endregion
        
        public Korisnici()
        {
            InitializeComponent();
            DGVfill();
            KolekcijaDjelatnici();
            if(Djelatnici != null)
                Djelatnici.Clear();
            ListaDijelatnika();
            cmbUloga.SelectedIndex = 0;
        }

        #region LISTE DJELATNIK ZA UNOS U BAZU
        public void ListaDijelatnika()
        {
            var dbs = "SELECT oib, ime, prezime FROM djelatnici WHERE datOtkaza IS NULL;";
            var Conn = new SqlConnection(dbc.strConnection);
            var Cmd = new SqlCommand(dbs, Conn);
            Conn.Open();
            try
            {
                SqlDataReader myReader = Cmd.ExecuteReader();
                while (myReader.Read())
                {
                    var oib = myReader["oib"].ToString();
                    var Ime = myReader["ime"].ToString();
                    var Prezime = myReader["prezime"].ToString();
                    var imePrezime = $"{Ime} {Prezime}";
                    Djelatnici.Add(oib, imePrezime);
                }
            }
            catch (Exception ex) { MessageBox.Show($"Greška kod učitavanja djelatnika\n{ ex.Message }", pomocna.MsgNazivGreska); }
            finally
            {
                Conn.Close();
            }
        }
        
        public void KolekcijaDjelatnici()
        {
            var ime = "ime";
            var prezime = "prezime";
            var dbAc = "SELECT ime, prezime FROM djelatnici WHERE datOtkaza IS NULL";
            var acLista = dbc.Kolekcija(dbAc, ime, prezime);
            txtDjelatnik.AutoCompleteCustomSource = acLista;
        }
        #endregion

        #region POLJA FOMRE PROVJERA I BRISANJE
        private void ProvjeraCelija()
        {
            if (String.IsNullOrWhiteSpace(txtDjelatnik.Text))
                pomocna.PraznaCelija(txtDjelatnik);
            else
                pomocna.OkCelija(txtDjelatnik);
            if (String.IsNullOrWhiteSpace(txtKorIme.Text))
                pomocna.PraznaCelija(txtKorIme);
            else
                pomocna.OkCelija(txtKorIme);
            if (String.IsNullOrWhiteSpace(txtLozinka.Text))
                pomocna.PraznaCelija(txtLozinka);
            else
                pomocna.OkCelija(txtLozinka);
            if (String.IsNullOrWhiteSpace(cmbUloga.Text))
                cmbUloga.BackColor = Color.LightPink;
            else
                cmbUloga.BackColor = Color.White;
            MessageBox.Show(pomocna.MsgPorukaPraznaCelija, pomocna.MsgNazivPozor);
        }

        private void OcistiCelije()
        {
            txtDjelatnik.Text = "";
            txtKorIme.Text = "";
            txtLozinka.Text = "";
            cmbUloga.SelectedIndex = 0;
            txtDjelatnik.Focus();
        }
        #endregion

        #region SPREMI NOVOG(INSERT) KORISNIKA
        private void Btn_spremi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDjelatnik.Text) || String.IsNullOrWhiteSpace(txtKorIme.Text)
                || String.IsNullOrWhiteSpace(txtLozinka.Text) || String.IsNullOrWhiteSpace(cmbUloga.Text))
            {
                ProvjeraCelija();
            }
            else
            {
                DjelatniciOib = Djelatnici.FirstOrDefault(d => d.Value == txtDjelatnik.Text).Key;
                if (DjelatniciOib == null)
                    MessageBox.Show($"Oib za djelatnika nije nađen", "Pažnja");
                else
                {
                    string Unos = $"INSERT INTO korisnici(username, password, uloga, djelatniciOib) " +
                        $"VALUES(@username, @password, @uloga, @djelatniciOib);";
                    var Conn = new SqlConnection(dbc.strConnection);
                    var Cmd = new SqlCommand(Unos, Conn);
                    Cmd.Parameters.AddWithValue("@username", txtKorIme.Text.Trim());
                    Cmd.Parameters.AddWithValue("@password", dbc.KriptirajLozinku(txtLozinka.Text.Trim()));
                    Cmd.Parameters.AddWithValue("@uloga", cmbUloga.SelectedItem.ToString());
                    Cmd.Parameters.AddWithValue("@djelatniciOib", DjelatniciOib.Trim());
                    try
                    {
                        bool success = upiti.BoolUnos(Cmd, Conn);
                        if (success == true)
                        {
                            OcistiCelije();
                            DGVfill();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show($"{pomocna.MsgPorukaInsertError}\n{ ex.Message}", pomocna.MsgNazivGreska); }
                }
            }
        }
        #endregion

        #region IZMJENI KORISNIKA (UPDATE)
        private void BtnIzmjeni_Click(object sender, EventArgs e)
        { 
            DjelatniciOib = Djelatnici.FirstOrDefault(d => d.Value == txtDjelatnik.Text).Key;
            if (DjelatniciOib == null)
                MessageBox.Show($"Oib za djelatnika nije nađen", "Pažnja");
            else
            {
                if (String.IsNullOrWhiteSpace(txtDjelatnik.Text) || String.IsNullOrWhiteSpace(txtKorIme.Text)
                || String.IsNullOrWhiteSpace(cmbUloga.Text))
                    ProvjeraCelija();
                if (!String.IsNullOrWhiteSpace(txtLozinka.Text))
                {
                    string Unos = $"UPDATE korisnici SET username=@username, password=@password, uloga=@uloga WHERE djelatniciOib=@djelatniciOib;";
                    var Conn = new SqlConnection(dbc.strConnection);
                    var Cmd = new SqlCommand(Unos, Conn);
                    Cmd.Parameters.AddWithValue("@username", txtKorIme.Text.Trim());
                    Cmd.Parameters.AddWithValue("@password", dbc.KriptirajLozinku(txtLozinka.Text.Trim()));
                    Cmd.Parameters.AddWithValue("@uloga", cmbUloga.SelectedItem.ToString());
                    Cmd.Parameters.AddWithValue("@djelatniciOib", DjelatniciOib.Trim());
                    try
                    {
                        bool success = upiti.BoolIzmjena(Cmd, Conn);
                        if (success == true)
                        {
                            OcistiCelije();
                            DGVfill();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show($"{pomocna.MsgPorukaInsertError}\n{ ex.Message}", pomocna.MsgNazivGreska); }
                }
                else
                {
                    string Unos = $"UPDATE korisnici SET username=@username, uloga=@uloga WHERE djelatniciOib=@djelatniciOib;";
                    var Conn = new SqlConnection(dbc.strConnection);
                    var Cmd = new SqlCommand(Unos, Conn);
                    Cmd.Parameters.AddWithValue("@username", txtKorIme.Text.Trim());
                    Cmd.Parameters.AddWithValue("@uloga", cmbUloga.SelectedItem.ToString());
                    Cmd.Parameters.AddWithValue("@djelatniciOib", DjelatniciOib.Trim());
                    try
                    {
                        bool success = upiti.BoolIzmjena(Cmd, Conn);
                        if (success == true)
                        {
                            OcistiCelije();
                            DGVfill();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show($"{pomocna.MsgPorukaInsertError}\n{ ex.Message}", pomocna.MsgNazivGreska); }
                }
            }
        }
        #endregion#

        #region METODE ZA RAD S FORMOM UČITAVANJA I PRETRAŽIVANJA
        private void DGVfill()
        {
            string DBS = $"SELECT * FROM korisnici;";
            dgv.DataSource = dbc.DGVselect(DBS);
        }

        private void Dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) 
        {
            int RowIndex = e.RowIndex;
            txtKorIme.Text = dgv.Rows[RowIndex].Cells[0].Value.ToString();
            cmbUloga.Text = dgv.Rows[RowIndex].Cells[2].Value.ToString();
            DjelatniciOib = dgv.Rows[RowIndex].Cells[3].Value.ToString();
            txtDjelatnik.Text = Djelatnici.FirstOrDefault(d => d.Key == DjelatniciOib).Value;
        }

        private void TxtPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            (dgv.DataSource as DataTable).DefaultView.RowFilter =
                string.Format($"username LIKE '%{ txtPretrazivanje.Text.Trim() }%' OR uloga LIKE '%{ txtPretrazivanje.Text.Trim() }%' " +
                $"OR djelatniciOib LIKE '%{ txtPretrazivanje.Text.Trim() }%'");
            if (dgv.Rows[0].Cells[0].Value == null) { return; }
        }
        #endregion

        #region OSTALO POMOĆNO NPR ENTER ZA PRIJAVU


        #endregion
    }
}
