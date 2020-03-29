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
           

            if(cmbVrstaOpreme.SelectedItem is null || txtNazivOpreme.Text is null || txtSerijskiBroj.Text is null)
            {
                MessageBox.Show(pomocna.MsgPorukaPraznaCelija, pomocna.MsgNazivPozor);
            }
            else
            { 
                //dodati provjeru ako ne postoji dan rashoda !!!

                string Unos = $"INSERT INTO uredaji(nazivUredaja,datKupovine, datRashoda, vrstaOpreme, serijskiBroj) VALUES(@naziv, @datumKupovine, @datumRashoda, @vrstaOpreme, @serBroj)";
                var Conn = new SqlConnection(dbc.strConnection);
                var Cmd = new SqlCommand(Unos, Conn);
                Cmd.Parameters.AddWithValue("@naziv", txtNazivOpreme.Text);
                Cmd.Parameters.AddWithValue("@datumKupovine", DateTime.Parse(dtpKupljeno.Text));
                Cmd.Parameters.AddWithValue("@datumRashoda", DateTime.Parse(dtpRashodovano.Text));
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

        private void DGVfill()
        {
            string DBS = $"SELECT * FROM uredaji;";
            dgv.DataSource = dbc.DGVselect(DBS);
        }

        private void UspjesanUnos()
        {
            DGVfill();
            cmbVrstaOpreme.SelectedItem = null;
            txtNazivOpreme.Clear();
            txtSerijskiBroj.Clear();
            txtInvBroj.Clear();
        }

        private void Dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtInvBroj.Text = dgv.Rows[RowIndex].Cells[0].Value.ToString();
            txtNazivOpreme.Text = dgv.Rows[RowIndex].Cells[1].Value.ToString();
            cmbVrstaOpreme.SelectedIndex = cmbVrstaOpreme.Items.IndexOf(dgv.Rows[RowIndex].Cells[4].Value.ToString());
            txtSerijskiBroj.Text = dgv.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void Btn_izmjeni_Click(object sender, EventArgs e)
        {
            
            if (cmbVrstaOpreme.SelectedItem is null || txtNazivOpreme.Text is null || txtSerijskiBroj.Text is null || txtID is null)
            {
                if(txtID is null)
                {
                    MessageBox.Show("Za uređivanje je potrebno odabrati redak iz tablice");
                }
                else
                {
                    MessageBox.Show(pomocna.MsgPorukaPraznaCelija, pomocna.MsgNazivPozor);
                }
                
            }
            else
            {
                string Unos = $"UPDATE uredaji SET[nazivUredaja]=@naziv, [datKupovine]=@datumKupovine, [datRashoda]=@datumRashoda, [vrstaOpreme]=@vrstaOpreme,[serijskiBroj]=@serBroj WHERE [invBroj]=@id";
                var Conn = new SqlConnection(dbc.strConnection);
                var Cmd = new SqlCommand(Unos, Conn);
                Cmd.Parameters.AddWithValue("@naziv", txtNazivOpreme.Text.Trim());
                Cmd.Parameters.AddWithValue("@datumKupovine", DateTime.Parse(dtpKupljeno.Text));
                Cmd.Parameters.AddWithValue("@datumRashoda", DateTime.Parse(dtpRashodovano.Text));
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

        private void BtnBrisanjeRashoda_Click(object sender, EventArgs e)
        {
            if (cmbVrstaOpreme.SelectedItem is null || txtNazivOpreme.Text is null || txtSerijskiBroj.Text is null || txtID is null)
            {
                if (txtID is null)
                    MessageBox.Show("Za uređivanje je potrebno odabrati redak iz tablice");
                else
                    MessageBox.Show(pomocna.MsgPorukaPraznaCelija, pomocna.MsgNazivPozor);
            }
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
    }
}
