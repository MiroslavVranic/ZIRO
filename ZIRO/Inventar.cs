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
    public partial class Inventar : Form
    {
        readonly DataBase dbc = new DataBase();
        readonly UpitiDB Upit = new UpitiDB();
        readonly Pomocna pomocna = new Pomocna();
        public Inventar()
        {
            InitializeComponent();
            DGVfill();

            //dodati po potrebni
            cmbVrstaOpreme.Items.Add("Mobitel");
            cmbVrstaOpreme.Items.Add("Laptop");
            cmbVrstaOpreme.Items.Add("Računalo");
            cmbVrstaOpreme.Items.Add("Razno");
        }

        private void Btn_spremi_Click(object sender, EventArgs e)
        {
            if(cmbVrstaOpreme.SelectedItem is null || String.IsNullOrWhiteSpace(txtNazivOpreme.Text) || 
                String.IsNullOrWhiteSpace(txtSerijskiBroj.Text))
                PrazneCelije();
            else
            { 
                string Unos = $"INSERT INTO uredaji(nazivUredaja, datKupovine, vrstaOpreme, serijskiBroj) " +
                    $"VALUES(@naziv, @datumKupovine, @vrstaOpreme, @serBroj)";
                var Conn = new SqlConnection(dbc.strConnection);
                var Cmd = new SqlCommand(Unos, Conn);
                Cmd.Parameters.AddWithValue("@naziv", txtNazivOpreme.Text);
                Cmd.Parameters.AddWithValue("@datumKupovine", DateTime.Parse(dtpKupljeno.Text));
                Cmd.Parameters.AddWithValue("@vrstaOpreme", cmbVrstaOpreme.SelectedItem.ToString());
                Cmd.Parameters.AddWithValue("@serBroj", txtSerijskiBroj.Text);
                try
                {
                    bool success = Upit.BoolUnos(Cmd, Conn);
                    if (success == true)
                    {
                        UspjesanUnos();
                    }
                    else
                        MessageBox.Show(pomocna.MsgPorukaInsertError, pomocna.MsgNazivGreska);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(pomocna.MsgPorukaInsertError + ex, pomocna.MsgNazivGreska);
                }

            }
        }

        private void Btn_izmjeni_Click(object sender, EventArgs e)
        {
            if (txtInvBroj is null)
                MessageBox.Show("Za uređivanje je potrebno odabrati redak iz tablice");
            if (cmbVrstaOpreme.SelectedItem is null || String.IsNullOrWhiteSpace(txtNazivOpreme.Text) ||
                String.IsNullOrWhiteSpace(txtSerijskiBroj.Text))
                PrazneCelije();
            else
            {
                string Unos = $"UPDATE uredaji SET[nazivUredaja]=@naziv, [datKupovine]=@datumKupovine, [vrstaOpreme]=@vrstaOpreme, " +
                    $"[serijskiBroj]=@serBroj WHERE [invBroj]=@id";
                var Conn = new SqlConnection(dbc.strConnection);
                var Cmd = new SqlCommand(Unos, Conn);
                Cmd.Parameters.AddWithValue("@naziv", txtNazivOpreme.Text.Trim());
                Cmd.Parameters.AddWithValue("@datumKupovine", DateTime.Parse(dtpKupljeno.Text));
                Cmd.Parameters.AddWithValue("@vrstaOpreme", cmbVrstaOpreme.SelectedItem.ToString());
                Cmd.Parameters.AddWithValue("@serBroj", txtSerijskiBroj.Text.Trim());
                Cmd.Parameters.AddWithValue("@id", txtInvBroj.Text.Trim());
                try
                {
                    bool success = Upit.BoolIzmjena(Cmd, Conn);
                    if (success == true)
                        UspjesanUnos();
                    else
                        MessageBox.Show(pomocna.MsgPorukaEditError, pomocna.MsgNazivGreska);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(pomocna.MsgPorukaEditError + ex.ToString(), pomocna.MsgNazivGreska);
                }
            }
        }

        private void BtnRashod_Click(object sender, EventArgs e)
        {
            if (txtInvBroj is null)
                MessageBox.Show("Za uređivanje je potrebno odabrati redak iz tablice");
            else
            {
                string Unos = $"UPDATE uredaji SET [datRashoda]=@datRashoda WHERE [invBroj]=@id";
                var Conn = new SqlConnection(dbc.strConnection);
                var Cmd = new SqlCommand(Unos, Conn);
                Cmd.Parameters.AddWithValue("@datRashoda", DateTime.Parse(dtpRashodovano.Text));
                Cmd.Parameters.AddWithValue("@id", txtInvBroj.Text.Trim());
                try
                {
                    bool success = Upit.BoolIzmjena(Cmd, Conn);
                    if (success == true)
                        UspjesanUnos();
                    else
                        MessageBox.Show(pomocna.MsgPorukaEditError, pomocna.MsgNazivGreska);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(pomocna.MsgPorukaEditError + ex.ToString(), pomocna.MsgNazivGreska);
                }
            }
        }

        private void BtnBrisanjeRashoda_Click(object sender, EventArgs e)
        {
            if (txtInvBroj is null)
                MessageBox.Show("Za uređivanje je potrebno odabrati redak iz tablice");
            else
            {
                string Unos = $"UPDATE uredaji SET [datRashoda]=NULL WHERE [invBroj]=@id";
                var Conn = new SqlConnection(dbc.strConnection);
                var Cmd = new SqlCommand(Unos, Conn);
                Cmd.Parameters.AddWithValue("@id", txtInvBroj.Text.Trim());
                try
                {
                    bool success = Upit.BoolIzmjena(Cmd, Conn);
                    if (success == true)
                        UspjesanUnos();
                    else
                        MessageBox.Show(pomocna.MsgPorukaEditError, pomocna.MsgNazivGreska);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(pomocna.MsgPorukaEditError + ex.ToString(), pomocna.MsgNazivGreska);
                }
            }
        }

        private void DGVfill()
        {
            string DBS = $"SELECT * FROM uredaji;";
            dgv.DataSource = dbc.DGVselect(DBS);
        }

        private void UspjesanUnos()
        {
            DGVfill();
            Clear();
        }

        private void Clear()
        {
            cmbVrstaOpreme.SelectedItem = null;
            txtNazivOpreme.Clear();
            txtSerijskiBroj.Clear();
            txtInvBroj.Clear();
            txtNazivOpreme.Focus();
        }

        private void PrazneCelije()
        {
            if (String.IsNullOrWhiteSpace(txtNazivOpreme.Text))
                pomocna.PraznaCelija(txtNazivOpreme);
            else
                pomocna.OkCelija(txtNazivOpreme);
            if (String.IsNullOrWhiteSpace(txtSerijskiBroj.Text))
                pomocna.PraznaCelija(txtSerijskiBroj);
            else
                pomocna.OkCelija(txtSerijskiBroj);
            if (cmbVrstaOpreme.SelectedItem is null)
                cmbVrstaOpreme.BackColor = Color.LightPink;
            else
                cmbVrstaOpreme.BackColor = Color.White;
            MessageBox.Show(pomocna.MsgPorukaPraznaCelija, pomocna.MsgNazivPozor);
        }

        private void Dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtInvBroj.Text = dgv.Rows[RowIndex].Cells[0].Value.ToString();
            txtNazivOpreme.Text = dgv.Rows[RowIndex].Cells[1].Value.ToString();
            cmbVrstaOpreme.SelectedIndex = cmbVrstaOpreme.Items.IndexOf(dgv.Rows[RowIndex].Cells[4].Value.ToString());
            txtSerijskiBroj.Text = dgv.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void SpremiUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_spremi.PerformClick();
        }

        private void IzmjeniUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_izmjeni.PerformClick();
        }
    }
}
