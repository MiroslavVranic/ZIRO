using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIRO
{
    public partial class Login : Form
    {
        private readonly DataBase dbc = new DataBase(); 
        private readonly Pomocna pomocna = new Pomocna(); 
        private readonly UpitiDB upiti = new UpitiDB(); 
        public Login()
        {
            InitializeComponent();
        }

        #region POSTAVLJANJE PLACEHOLDERA U POLJA
        private void SetPlaceholder(TextBox textBox, string placeH)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.UseSystemPasswordChar = false;
                textBox.Text = placeH;
                textBox.ForeColor = Color.Silver;
            }
        }
        private void BlankPlaceholder(TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == txtPromjena || textBox == txtLozinka)
                    textBox.UseSystemPasswordChar = true;
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void TxtPromjena_Enter(object sender, EventArgs e)
        {
            BlankPlaceholder(txtPromjena);
        }

        private void TxtPromjena_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txtPromjena, "Ponovi lozinku");
        }

        private void TxtKorIme_Enter(object sender, EventArgs e)
        {
            BlankPlaceholder(txtKorIme);
        }

        private void TxtKorIme_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txtKorIme, "Unesi korisničko ime");
        }

        private void TxtLozinka_Enter(object sender, EventArgs e)
        {
            BlankPlaceholder(txtLozinka);
        }

        private void TxtLozinka_Leave(object sender, EventArgs e)
        {
            if(txtPromjena.Visible == true)
                SetPlaceholder(txtLozinka, "Unesi novu lozinku");
            else
                SetPlaceholder(txtLozinka, "Unesi lozinku");
        }
        #endregion

        #region METODA PRIJAVE KORISNIKA
        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            string dalPostojis = $"SELECT * FROM korisnici WHERE username=@username AND password=@password";
            var Conn = new SqlConnection(dbc.strConnection);
            var Cmd = new SqlCommand(dalPostojis, Conn);
            Cmd.Parameters.AddWithValue("@username", txtKorIme.Text.Trim());
            Cmd.Parameters.AddWithValue("@password", dbc.KriptirajLozinku(txtLozinka.Text.Trim()));
            try
            {
                Conn.Open();
                SqlDataReader korisnik = Cmd.ExecuteReader();
                if (korisnik.HasRows)
                {
                    dbc.Username = txtKorIme.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show($"Korisničko ime ili lozinka nisu točni\nPokušaj ponovno!\n", "Pažnja");
            }
            catch (Exception ex) { MessageBox.Show($"Korisničko ime ili lozinka nisu točni\nPokušaj ponovno!\n{ex.Message}", "Pažnja"); }
            finally
            {
                Conn.Close();
            }
        }
        #endregion

        private void BtnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region PROMJENA LOZINKE
        private void BtnPromjena_Click(object sender, EventArgs e)
        {
            string dalPostojis = $"SELECT * FROM korisnici WHERE username=@username AND password=@password";
            var Conn = new SqlConnection(dbc.strConnection);
            var Cmd = new SqlCommand(dalPostojis, Conn);
            Cmd.Parameters.AddWithValue("@username", txtKorIme.Text.Trim());
            Cmd.Parameters.AddWithValue("@password", dbc.KriptirajLozinku(txtLozinka.Text.Trim()));
            try
            {
                Conn.Open();
                SqlDataReader korisnik = Cmd.ExecuteReader();
                if (korisnik.HasRows)
                {
                    txtPromjena.Visible = true;
                    btnOdustani.Visible = true;
                    btnSpremiLozinku.Visible = true;
                    txtLozinka.UseSystemPasswordChar = false;
                    txtLozinka.ForeColor = Color.Silver;
                    txtLozinka.Text = "Unesi novu lozinku";
                }
                else
                    MessageBox.Show($"Za promjenu lozinke unesite svoje korisničko ime i trenutnu lozinku", "Pažnja");
            }
            catch (Exception ex) { MessageBox.Show($"Korisničko ime ili lozinka nisu točni\nPokušaj ponovno!\n{ex.Message}", "Pažnja"); }
            finally
            {
                Conn.Close();
            }
        }
        private void BtnSpremiLozinku_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLozinka.Text) || String.IsNullOrWhiteSpace(txtPromjena.Text))
                MessageBox.Show($"Lozinka mora imati znakove!", "Pažnja");
            else
            {
                if (txtLozinka.Text != txtPromjena.Text)
                    MessageBox.Show($"Lozinke se ne podudaraju", "Pažnja");
                else
                {
                    string Unos = $"UPDATE korisnici SET password=@password WHERE username=@username;";
                    var Conn = new SqlConnection(dbc.strConnection);
                    var Cmd = new SqlCommand(Unos, Conn);
                    Cmd.Parameters.AddWithValue("@password", dbc.KriptirajLozinku(txtLozinka.Text.Trim())); 
                    Cmd.Parameters.AddWithValue("@username", txtKorIme.Text.Trim());
                    try
                    {
                        string password = dbc.KriptirajLozinku(txtLozinka.Text);
                        bool success = upiti.BoolIzmjena(Cmd, Conn);
                        if (success == true)
                        {
                            MessageBox.Show($"Lozinka je uspješno promjenjena.\n" +
                                $"Prijavite se s novom lozinkom\n{password}", "Obavijest");
                            txtLozinka.UseSystemPasswordChar = false;
                            txtPromjena.UseSystemPasswordChar = false;
                            txtLozinka.ForeColor = Color.Silver;
                            txtPromjena.ForeColor = Color.Silver;
                            btnOdustani.PerformClick();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show($"{pomocna.MsgPorukaInsertError}\n{ ex.Message}", pomocna.MsgNazivGreska); }
                }
            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            txtPromjena.Visible = false;
            btnOdustani.Visible = false;
            btnSpremiLozinku.Visible = false;
            txtLozinka.Text = "Unesi lozinku";
            txtPromjena.Text = "Ponovi lozinku";
        }

        #endregion

        private void TxtKorIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnPrijava.PerformClick();
            }
        }

        private void TxtLozinka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnPrijava.PerformClick();
            }
        }
    }
}
