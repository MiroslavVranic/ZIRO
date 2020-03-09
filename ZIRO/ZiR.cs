using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ZIRO
{
    public partial class ZiR : Form
    {
        readonly DataBase dbc = new DataBase();
        readonly Pomocna pomocna = new Pomocna();
        readonly UpitiDB upiti = new UpitiDB();

        public static Dictionary<string, string> Djelatnici = new Dictionary<string, string>();
        public static Dictionary<string, string> Uredaji = new Dictionary<string, string>();
        
        public ZiR()
        {
            InitializeComponent();
            if(Djelatnici != null)
                Djelatnici.Clear();
            ListaDijelatnika();
            if(Uredaji != null)
                Uredaji.Clear();
            ListaInventara();
            KolekcijaInventar();
            KolekcijaDjelatnici();
            cmbStatus.SelectedIndex = 0;
        }

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
        public void ListaInventara()
        {
            var dbs = "SELECT invBroj, nazivUredaja FROM uredaji;";
            var Conn = new SqlConnection(dbc.strConnection);
            var Cmd = new SqlCommand(dbs, Conn);
            Conn.Open();
            try
            {
                SqlDataReader myReader = Cmd.ExecuteReader();
                while (myReader.Read())
                {
                    var invBr = myReader["invBroj"].ToString();
                    var uredaj = myReader["nazivUredaja"].ToString();
                    var uredaji = $"{uredaj} {invBr}";
                    Uredaji.Add(invBr, uredaji);
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

        public void KolekcijaInventar()
        {
            var uredaj = "nazivUredaja";
            var invBroj = "invBroj";
            var dbAc = "SELECT nazivUredaja, invBroj FROM uredaji;";
            var acLista = dbc.Kolekcija(dbAc, uredaj, invBroj);
            txtInventar.AutoCompleteCustomSource = acLista;
        }

        private void Btn_pretrazi_Click(object sender, EventArgs e)
        {
            string dbs = null;
            string Djelatnik = Djelatnici.FirstOrDefault(d => d.Value == txtDjelatnik.Text.Trim()).Key;
            if (cmbStatus.Text == "Zaduženo")
                dbs = $"SELECT uredaji.invBroj, uredaji.nazivUredaja, zaduzenja.datZaduzenja, zaduzenja.datRazduzenja FROM uredaji " +
                    $"LEFT JOIN zaduzenja ON uredaji.invBroj = zaduzenja.uredajInvBroj " +
                    $"LEFT JOIN djelatnici ON djelatnici.oib = zaduzenja.djelatnikOib " +
                    $"WHERE zaduzenja.djelatnikOib = @djelatnik AND zaduzenja.datRazduzenja IS NULL;";
            else
                dbs = $"SELECT uredaji.invBroj, uredaji.nazivUredaja, zaduzenja.datZaduzenja, zaduzenja.datRazduzenja FROM uredaji " +
                  $"LEFT JOIN zaduzenja ON uredaji.invBroj = zaduzenja.uredajInvBroj " +
                  $"LEFT JOIN djelatnici ON djelatnici.oib = zaduzenja.djelatnikOib " +
                  $"WHERE zaduzenja.djelatnikOib = @djelatnik AND zaduzenja.datRazduzenja IS NOT NULL;";
            var Conn = new SqlConnection(dbc.strConnection);
            var Cmd = new SqlCommand(dbs, Conn);
            Cmd.Parameters.AddWithValue("@djelatnik", Djelatnik);
            try
            {
                dgv.DataSource = dbc.DGVselect(Cmd, Conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri dohvačanju djelatnika\n{ex.Message}", pomocna.MsgNazivGreska);
            }
        }

        private void Btn_zaduzi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDjelatnik.Text) || String.IsNullOrWhiteSpace(txtInventar.Text))
            {
                ProvjeraCelija();
            }
            else
            {
                string Uredaj = Uredaji.FirstOrDefault(u => u.Value == txtInventar.Text.Trim()).Key;
                string Djelatnik = Djelatnici.FirstOrDefault(d => d.Value == txtDjelatnik.Text).Key;
                bool provjera = ProvjeraZaduzenja(Uredaj);
                if(provjera == true) 
                {
                    if (Djelatnik == null || Uredaj == null)
                        MessageBox.Show($"Uređaj i/ili djelatnik ne postoje u bazi!", "Pažnja");
                    else
                    {
                        string Unos = $"INSERT INTO zaduzenja(djelatnikOib, uredajInvBroj, datZaduzenja) " +
                            $"VALUES(@djelatnikOib, @uredajInvBroj, @datZaduzenja);";
                        var Conn = new SqlConnection(dbc.strConnection);
                        var Cmd = new SqlCommand(Unos, Conn);
                        Cmd.Parameters.AddWithValue("@djelatnikOib", Djelatnik);
                        Cmd.Parameters.AddWithValue("@uredajInvBroj", Uredaj);
                        Cmd.Parameters.AddWithValue("@datZaduzenja", DateTime.Parse(dtpZaduzen.Text));
                        try
                        {
                            bool success = upiti.BoolUnos(Cmd, Conn);
                            if (success == true)
                                btn_pretrazi.PerformClick();
                        }
                        catch (Exception ex) { MessageBox.Show($"{pomocna.MsgPorukaInsertError}\n{ ex.Message}", pomocna.MsgNazivGreska); }
                    }
                }
                else
                    MessageBox.Show($"Uređaj je zadužen i nemeže biti dva puta izdan!", "Pažnja");
            }
        }

        public bool ProvjeraZaduzenja(string invBroj)
        {
            bool success = false;
            string dalPostojis = $"SELECT * FROM zaduzenja WHERE " +
                $"uredajInvBroj=@uredajInvBroj AND datRazduzenja IS NULL";
            var Conn = new SqlConnection(dbc.strConnection);
            var Cmd = new SqlCommand(dalPostojis, Conn);
            Cmd.Parameters.AddWithValue("@uredajInvBroj", invBroj);
            try
            {
                Conn.Open();
                SqlDataReader korisnik = Cmd.ExecuteReader();
                if (korisnik.HasRows)
                    success = false;
                else
                    success = true;
            }
            catch (Exception ex) { MessageBox.Show($"Dgodila se greška prilikom pretrage zaduženja!\n{ex.Message}", "Pažnja"); }
            finally
            {
                Conn.Close();
            }
            return success;
        } 
        public bool ProvjeraZaduzenja(string djelatnik, string invBroj)
        {
            bool success = false;
            string dalPostojis = $"SELECT * FROM zaduzenja WHERE " +
                $"djelatnikOib=@djelatnikOib AND uredajInvBroj=@uredajInvBroj AND datRazduzenja IS NULL";
            var Conn = new SqlConnection(dbc.strConnection);
            var Cmd = new SqlCommand(dalPostojis, Conn);
            Cmd.Parameters.AddWithValue("@djelatnikOib", djelatnik);
            Cmd.Parameters.AddWithValue("@uredajInvBroj", invBroj);
            try
            {
                Conn.Open();
                SqlDataReader korisnik = Cmd.ExecuteReader();
                if (korisnik.HasRows)
                    success = true;
                else
                    success = false;
            }
            catch (Exception ex) { MessageBox.Show($"Dgodila se greška prilikom pretrage zaduženja!\n{ex.Message}", "Pažnja"); }
            finally
            {
                Conn.Close();
            }
            return success;
        }
        #region POLJA FORME PROVJERA I BRISANJE
        private void ProvjeraCelija()
        {
            if (String.IsNullOrWhiteSpace(txtDjelatnik.Text))
                pomocna.PraznaCelija(txtDjelatnik);
            else
                pomocna.OkCelija(txtDjelatnik);
            if (String.IsNullOrWhiteSpace(txtInventar.Text))
                pomocna.PraznaCelija(txtInventar);
            else
                pomocna.OkCelija(txtInventar);
            MessageBox.Show(pomocna.MsgPorukaPraznaCelija, pomocna.MsgNazivPozor);
        }
        #endregion

        private void Btn_razduzi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDjelatnik.Text) || String.IsNullOrWhiteSpace(txtInventar.Text))
            {
                ProvjeraCelija();
            }
            else
            {
                string Uredaj = Uredaji.FirstOrDefault(u => u.Value == txtInventar.Text.Trim()).Key;
                string Djelatnik = Djelatnici.FirstOrDefault(d => d.Value == txtDjelatnik.Text).Key;
                bool provjera = ProvjeraZaduzenja(Djelatnik, Uredaj);
                if (provjera == false)
                    MessageBox.Show($"Povrat se ne može napraviti!", "Pažnja");
                if (Djelatnik == null || Uredaj == null)
                    MessageBox.Show($"Uređaj i/ili djelatnik ne postoje u bazi!", "Pažnja");
                else
                {
                    string Unos = $"UPDATE zaduzenja SET datRazduzenja=@datRazduzenja WHERE " +
                        $"djelatnikOib=@djelatnikOib AND uredajInvBroj=@uredajInvBroj";
                    var Conn = new SqlConnection(dbc.strConnection);
                    var Cmd = new SqlCommand(Unos, Conn);
                    Cmd.Parameters.AddWithValue("@djelatnikOib", Djelatnik);
                    Cmd.Parameters.AddWithValue("@uredajInvBroj", Uredaj);
                    Cmd.Parameters.AddWithValue("@datRazduzenja", DateTime.Parse(dtpZaduzen.Text));
                    try
                    {
                        bool success = upiti.BoolUnos(Cmd, Conn);
                        if (success == true)
                            btn_pretrazi.PerformClick();
                    }
                    catch (Exception ex) { MessageBox.Show($"{pomocna.MsgPorukaInsertError}\n{ ex.Message}", pomocna.MsgNazivGreska); }
                }
            }

        }
    }
}
