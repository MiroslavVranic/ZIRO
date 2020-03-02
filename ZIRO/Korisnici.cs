using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        readonly Upiti upiti = new Upiti();
        readonly Pomocna pomocna = new Pomocna();

        public string StraniKljuc { get; private set; }

        public Korisnici()
        {
            InitializeComponent();
            DGVfill();
            KolekcijaDjelatnici();
        }

        private void KolekcijaDjelatnici()
        {
            string ime = "ime";
            string prezime = "prezime";
            string dbAc = "SELECT ime, prezime FROM djelatnici";
            var acLista = dbc.Kolekcija(dbAc, ime, prezime);
            txtDjelatnik.AutoCompleteCustomSource = acLista;
        }

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
        private void Btn_spremi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDjelatnik.Text) || String.IsNullOrWhiteSpace(txtKorIme.Text)
                || String.IsNullOrWhiteSpace(txtLozinka.Text) || String.IsNullOrWhiteSpace(cmbUloga.Text))
            {
                ProvjeraCelija();
            }
            else
            {
                ForKey();
                if (dbc.StraniKljuc < 1)
                    MessageBox.Show($"Unešeni djelatnik ne postoji!");
                else
                {
                    string Unos = $"INSERT INTO korisnici(oibDjelatnici, username, password, uloga) VALUES(?, ?, ?, ?)";
                    var Conn = new OleDbConnection(dbc.ConnString);
                    var Cmd = new OleDbCommand(Unos, Conn);
                    Cmd.Parameters.AddWithValue("@oibDjelatnici", txtDjelatnik.Text.Trim());
                    Cmd.Parameters.AddWithValue("@username", txtKorIme.Text.Trim());
                    Cmd.Parameters.AddWithValue("@password", txtKorIme.Text.Trim());
                    Cmd.Parameters.AddWithValue("@uloga", cmbUloga.ToString());
                    try
                    {
                        bool success = upiti.BoolUnos(Conn, Cmd);
                        if (success == true)
                        {
                            //UspjesanUnos();
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

        public string ForKey()
        {
            string tablica = "'ime'" + " " + "'prezime'";
            string Select = $"SELECT oib FROM djelatnici WHERE ime = 'Miro'";
            var Conn = new OleDbConnection(dbc.ConnString);
            var Cmd = new OleDbCommand(Select, Conn);
            try
            {
                Conn.Open();
                return StraniKljuc = (string)Cmd.ExecuteScalar();
            }
            catch (Exception ex) { MessageBox.Show($"Strani ključ nije nađen\n{ ex.Message }"); }
            finally
            {
                Conn.Close();
            }
            return StraniKljuc;

        }
        private void DGVfill()
        {
            string DBS = $"SELECT * FROM korisnici;";
            dgv.DataSource = dbc.DGVselect(DBS);
        }
    }
}
