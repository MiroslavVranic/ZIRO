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

    public partial class Odjeli : Form
    {
        readonly DataBase dbc = new DataBase();
        readonly Upiti upiti = new Upiti();
        readonly Pomocna pomocna = new Pomocna();
        public Odjeli()
        {
            InitializeComponent();
            DGVfill();
        }

        // Punjenje DGV forme
        private void DGVfill()
        {
            string DBS = $"SELECT * FROM odjeli;";
            dgv.DataSource = dbc.DGVselect(DBS);
        }

        // Unos 
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

                string Unos = $"INSERT INTO odjeli(Naziv) VALUES(?)";
                var Conn = new OleDbConnection(dbc.ConnString);
                var Cmd = new OleDbCommand(Unos, Conn);
                Cmd.Parameters.AddWithValue("@Naziv", txtNaziv.Text.Trim());
                try
                {
                    bool success = upiti.BoolUnos(Conn, Cmd);
                    if (success == true)
                    {
                        DGVfill();
                        txtNaziv.Clear();
                        txtNaziv.Focus();
                    }
                    else
                        MessageBox.Show(pomocna.MsgPorukaInsertError, pomocna.MsgNazivGreska);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(pomocna.MsgPorukaInsertError + ex.ToString(), pomocna.MsgNazivGreska);
                }
            }
        }

        // Izmjena postojećih unosa
        private void Btn_izmjeni_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                txtNaziv.BackColor = Color.LightPink;
                MessageBox.Show(pomocna.MsgPorukaPraznaCelija, pomocna.MsgNazivPozor);
            }
            else
            {
                txtNaziv.BackColor = Color.White;

                string Uredi = $"UPDATE odjeli SET Naziv=? WHERE ID=?";
                var Conn = new OleDbConnection(dbc.ConnString);
                var Cmd = new OleDbCommand(Uredi, Conn);
                Cmd.Parameters.AddWithValue("@Naziv", txtNaziv.Text.Trim());
                Cmd.Parameters.AddWithValue("@ID", int.Parse(txtId.Text.Trim()));
                try
                {
                    bool success = upiti.BoolIzmjena(Conn, Cmd);

                    if (success == true)
                    {
                        DGVfill();
                        txtId.Clear();
                        txtNaziv.Clear();
                        txtNaziv.Focus();
                    }
                    else
                    {
                        MessageBox.Show(pomocna.MsgPorukaEditError, pomocna.MsgNazivGreska);
                    }
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show(pomocna.MsgPorukaEditError + ex.ToString(), pomocna.MsgNazivGreska); 
                }
            }
        }

        // Pretraživanje učitanih polja tablice
        private void Txt_pretrazivanje_TextChanged_1(object sender, EventArgs e)
        {
            (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format($"naziv LIKE '%{ txt_pretrazivanje.Text.Trim() }%'");
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
    }
}
