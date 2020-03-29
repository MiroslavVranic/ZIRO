using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

    public partial class Odjeli : Form
    {
        readonly Pomocna pomocna = new Pomocna();
        readonly DataBase dbc = new DataBase();
        readonly UpitiDB Upit = new UpitiDB();

        public Odjeli()
        {
            InitializeComponent();
            DGVfill();            
        }

        private void Clear()
        {
            txtId.Clear();
            txtNaziv.Clear();
            txtNaziv.Focus();
        }

        #region UNOS I IZMJENA PODATAKA
        private void Btn_spremi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                pomocna.PraznaCelija(txtNaziv);
                MessageBox.Show(pomocna.MsgPorukaPraznaCelija, pomocna.MsgNazivPozor);
            }            
            else
            {
                pomocna.OkCelija(txtNaziv);

                string unos = $"INSERT INTO odjeli(nazivOdjela) VALUES(@Naziv)";
                
                try
                {
                    var Conn = new SqlConnection(dbc.strConnection);
                    var Cmd = new SqlCommand(unos, Conn);
                    Cmd.Parameters.AddWithValue("@Naziv",txtNaziv.Text);

                    if (Upit.BoolIzmjena(Cmd, Conn))
                    {
                        DGVfill();
                        Clear();
                    }
                    else
                        MessageBox.Show(pomocna.MsgPorukaInsertError, pomocna.MsgNazivGreska);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(pomocna.MsgPorukaInsertError + ex.ToString(), pomocna.MsgNazivGreska);
                }
            }
        }

        private void btn_izmjeni_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                pomocna.PraznaCelija(txtNaziv);
                MessageBox.Show(pomocna.MsgPorukaPraznaCelija, pomocna.MsgNazivPozor);
            }
            else
            {
                pomocna.OkCelija(txtNaziv);

                string Uredi = $"UPDATE odjeli SET nazivOdjela=@Naziv WHERE Id=@ID";

                var Conn = new SqlConnection(dbc.strConnection);
                var Cmd = new SqlCommand(Uredi, Conn);
                Cmd.Parameters.AddWithValue("@Naziv", txtNaziv.Text.Trim());
                Cmd.Parameters.AddWithValue("@ID", int.Parse(txtId.Text));
                try
                {
                    bool success = Upit.BoolIzmjena(Cmd, Conn);

                    if (success == true)
                    {
                        DGVfill();
                        Clear();
                    }
                    else
                        MessageBox.Show(pomocna.MsgPorukaEditError, pomocna.MsgNazivGreska);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(pomocna.MsgPorukaEditError + ex.ToString(), pomocna.MsgNazivGreska);
                }
            }
        }
        #endregion


        // Punjenje DGV forme
        private void DGVfill()
        {
            try
            {
                string dbs = "SELECT * FROM odjeli";
                dgv.DataSource = dbc.DGVselect(dbs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), pomocna.MsgNazivGreska);
            }
        }        
       
        // PRetraživanje učitanih polja tablice

        private void Txt_pretrazivanje_TextChanged_1(object sender, EventArgs e)
        {
            (dgv.DataSource as DataTable).DefaultView.RowFilter = 
                string.Format("nazivOdjela LIKE '%{0}%'", txt_pretrazivanje.Text.Trim());
            if (dgv.Rows[0].Cells[0].Value == null) { return; }
        }

        // Odabir reda iz tablice za izmjene
        private void Dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtId.Text = dgv.Rows[RowIndex].Cells[0].Value.ToString();
            txtNaziv.Text = dgv.Rows[RowIndex].Cells[1].Value.ToString();
        }

        private void SpremiUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_spremi.PerformClick();
        }

        private void IzmjeniUnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_izmjeni.PerformClick();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNaziv.Text = row.Cells["nazivOdjela"].Value.ToString();                
            }
        }
    }
}
