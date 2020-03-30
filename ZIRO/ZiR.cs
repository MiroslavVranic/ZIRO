using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZIRO
{
    public partial class ZiR : Form
    {
        #region PROPERTIES
        readonly DataBase dbc = new DataBase();
        readonly Pomocna pomocna = new Pomocna();
        readonly UpitiDB upiti = new UpitiDB();
        readonly IzvozWord izvozWord = new IzvozWord();

        public static Dictionary<string, string> Djelatnici = new Dictionary<string, string>();
        public static Dictionary<string, string> Uredaji = new Dictionary<string, string>();
        #endregion

        public ZiR()
        {
            InitializeComponent();
            if (Djelatnici.Count != 0)
                Djelatnici.Clear();
            ListaDijelatnika();
            if (Uredaji.Count != 0)
                Uredaji.Clear();
            ListaInventara();
            KolekcijaInventar();
            KolekcijaDjelatnici();
            cmbStatus.SelectedIndex = 0;
            var checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "",
                Width = 30,
                Name = "checkBoxColumn"
            };
            dgv.Columns.Insert(0, checkBoxColumn);
        }

        #region METHODS
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
            var dbs = "SELECT invBroj, nazivUredaja FROM uredaji WHERE datRashoda IS NULL;";
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
            var dbAc = "SELECT nazivUredaja, invBroj FROM uredaji WHERE datRashoda IS NULL;";
            var acLista = dbc.Kolekcija(dbAc, uredaj, invBroj);
            txtInventar.AutoCompleteCustomSource = acLista;
        }

        private void Btn_pretrazi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDjelatnik.Text))
            {
                pomocna.PraznaCelija(txtDjelatnik);
                MessageBox.Show("Unesi ime i prezime djelatnika!", pomocna.MsgNazivPozor);
            }
            else
            {
                pomocna.OkCelija(txtDjelatnik);
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
        }

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
                bool provjera = upiti.ProvjeraZaduzenja(Djelatnik, Uredaj);
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
                bool provjera = upiti.ProvjeraZaduzenja(Uredaj);
                if (provjera == true)
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
                    MessageBox.Show($"Uređaj je zadužen i nemože biti dva puta izdan!", "Pažnja");
            }
        }
        #endregion

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

        private void BtnRevers_Click(object sender, EventArgs e)
        {
            int provjera = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                bool isCellChecked = Convert.ToBoolean(dgv.Rows[i].Cells[0].Value);
                if (isCellChecked == true)
                    provjera += 1;
            }
            if (provjera == 0)
            {
                MessageBox.Show("Mora biti odabran bar jedan unos!", pomocna.MsgNazivPozor);
                if (String.IsNullOrWhiteSpace(txtDjelatnik.Text))
                    pomocna.PraznaCelija(txtDjelatnik);
            }
            else
            {
                pomocna.OkCelija(txtDjelatnik);
                string ListaZaduzenja = string.Empty;
                foreach (DataGridViewRow row in dgv.Rows)
                {                    
                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                    if (isSelected)
                    {
                        ListaZaduzenja += row.Cells["invBroj"].Value.ToString();
                        ListaZaduzenja += "\t";
                        ListaZaduzenja += row.Cells["nazivUredaja"].Value.ToString();
                        ListaZaduzenja += "\t";
                        ListaZaduzenja += row.Cells["datZaduzenja"].Value.ToString();
                        ListaZaduzenja += Environment.NewLine;
                    }                   
                }
                izvozWord.NaslovDokumenta = "REVERS";
                izvozWord.Datum = DateTime.Parse(dtpZaduzen.Text);
                izvozWord.ImePrezime = txtDjelatnik.Text;
                izvozWord.IzdanoOd = dbc.TrenutniKorisnik;
                izvozWord.Zaduzen = txtDjelatnik.Text;
                izvozWord.ListaZaduzenja = ListaZaduzenja;
                izvozWord.Revers();
            }
        }

        private void BtnPovratReversa_Click(object sender, EventArgs e)
        {
            int provjera = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                bool isCellChecked = Convert.ToBoolean(dgv.Rows[i].Cells[0].Value);
                if (isCellChecked == true)
                    provjera += 1;
            }
            if (provjera == 0)
            {
                MessageBox.Show("Mora biti odabran bar jedan unos!", pomocna.MsgNazivPozor);
                if (String.IsNullOrWhiteSpace(txtDjelatnik.Text))
                    pomocna.PraznaCelija(txtDjelatnik);
            }
            else                
            {
                pomocna.OkCelija(txtDjelatnik);
                string ListaZaduzenja = string.Empty;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                    if (isSelected)
                    {
                        ListaZaduzenja += row.Cells["invBroj"].Value.ToString().Trim();
                        ListaZaduzenja += "\t";
                        ListaZaduzenja += row.Cells["nazivUredaja"].Value.ToString().Trim();
                        ListaZaduzenja += "\t";
                        ListaZaduzenja += DateTime.Parse(row.Cells["datRazduzenja"].Value.ToString()).ToShortDateString().Trim();
                        ListaZaduzenja += Environment.NewLine;
                    }
                }
                izvozWord.NaslovDokumenta = "POVRAT REVERSA";
                izvozWord.Datum = DateTime.Parse(dtpRazduzen.Text);
                izvozWord.ImePrezime = txtDjelatnik.Text;
                izvozWord.IzdanoOd = dbc.TrenutniKorisnik;
                izvozWord.Zaduzen = txtDjelatnik.Text;
                izvozWord.ListaZaduzenja = ListaZaduzenja;
                izvozWord.Povrat();
            }
        }
    }
}
