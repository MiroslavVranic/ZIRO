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
        String strConnection = Properties.Settings.Default.DatabaseConnectionString;
        readonly UpitiDB Upit = new UpitiDB();
        readonly Pomocna pomocna = new Pomocna();
        public Inventar()
        {
            InitializeComponent();
            DGVfill();

            //dodati po potrebni
            cmb_vrstaOpreme.Items.Add("Mobitel");
            cmb_vrstaOpreme.Items.Add("Laptop");
            cmb_vrstaOpreme.Items.Add("Računalo");
            cmb_vrstaOpreme.Items.Add("Razno");
        }

        private void Btn_spremi_Click(object sender, EventArgs e)
        {


            if (cmb_vrstaOpreme.SelectedItem is null || txt_nazivOprme.Text is null || txt_serijskiBroj.Text is null)
            {
                MessageBox.Show(pomocna.MsgPorukaPraznaCelija, pomocna.MsgNazivPozor);
            }
            else
            {
                //dodati provjeru ako ne postoji dan rashoda !!!

                string selectedItem = cmb_vrstaOpreme.Items[cmb_vrstaOpreme.SelectedIndex].ToString();
                string naziv = txt_nazivOprme.Text.ToString();
                string serBroj = txt_serijskiBroj.Text.ToString();
                DateTime datumKupovine = dtp_datum.Value;
                DateTime datumRashoda = dateTimePicker1.Value;

                string Unos = $"INSERT INTO uredaji(invBroj, nazivUredaja, datKupovine, datRashoda, vrstaOpreme) " +
                    $"VALUES(@invBroj, @nazivUredaja, @datumKupovine, @datumRashoda, @vrstaOpreme)";
                var Conn = new SqlConnection(strConnection);
                var Cmd = new SqlCommand(Unos, Conn);
                Cmd.Parameters.AddWithValue("@invBroj", txt_invBroj.Text);
                Cmd.Parameters.AddWithValue("@nazivUredaja", naziv);
                Cmd.Parameters.AddWithValue("@datumKupovine", datumKupovine);
                Cmd.Parameters.AddWithValue("@datumRashoda", datumRashoda);
                Cmd.Parameters.AddWithValue("@vrstaOpreme", selectedItem);

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
                    MessageBox.Show(pomocna.MsgPorukaInsertError + ex.Message, pomocna.MsgNazivGreska);
                }

            }
        }

        private void DGVfill()
        {
            string DBS = $"SELECT * FROM uredaji;";
            dgv.DataSource = dbc.DGVselect(DBS);
        }

        private void buttonNULLdate_Click(object sender, EventArgs e)
        {
            //dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Enabled = false;
        }

        private void UspjesanUnos()
        {
            DGVfill();
            cmb_vrstaOpreme.SelectedItem = null;
            txt_nazivOprme.Text = "";
            txt_serijskiBroj.Text = "";
        }

        private void dgv_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_invBroj.Text = dgv.Rows[RowIndex].Cells[0].Value.ToString();
            txt_nazivOprme.Text = dgv.Rows[RowIndex].Cells[1].Value.ToString();
            cmb_vrstaOpreme.SelectedIndex = cmb_vrstaOpreme.Items.IndexOf(dgv.Rows[RowIndex].Cells[4].Value.ToString());
            //txt_serijskiBroj.Text = dgv.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void btn_izmjeni_Click_1(object sender, EventArgs e)
        {
            if (cmb_vrstaOpreme.SelectedItem is null || txt_nazivOprme.Text is null || txt_serijskiBroj.Text is null || txt_ID is null)
            {
                if (txt_ID is null)
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
                string selectedItem = cmb_vrstaOpreme.Items[cmb_vrstaOpreme.SelectedIndex].ToString();
                string naziv = txt_nazivOprme.Text.ToString();
                string serBroj = txt_serijskiBroj.Text.ToString();
                DateTime datumKupovine = dtp_datum.Value;
                DateTime datumRashoda = dateTimePicker1.Value;
                long id = long.Parse(txt_invBroj.Text);

                string Unos = $"UPDATE uredaji SET[nazivUredaja]=@naziv, [datKupovine]=@datumKupovine," +
                    $" [datRashoda]=@datumRashoda, [vrstaOpreme]=@vrstaOpreme WHERE [invBroj]=@id";
                var Conn = new SqlConnection(strConnection);
                var Cmd = new SqlCommand(Unos, Conn);
                Cmd.Parameters.AddWithValue("@naziv", naziv);
                Cmd.Parameters.AddWithValue("@datumKupovine", datumKupovine);
                Cmd.Parameters.AddWithValue("@datumRashoda", datumRashoda);
                Cmd.Parameters.AddWithValue("@vrstaOpreme", selectedItem);

                Cmd.Parameters.AddWithValue("@id", id);
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

        private void txt_pretrazi_TextChanged(object sender, EventArgs e)
        {
            (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("nazivUredaja LIKE '%{0}%'", txt_pretrazi.Text.Trim());
            if (dgv.Rows[0].Cells[0].Value == null) { return; }
        }
    }
}
