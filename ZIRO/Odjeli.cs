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
        //readonly DataBase DBC = new DataBase();
        //readonly Upiti Upit = new Upiti();
        String strConnection = Properties.Settings.Default.DatabaseConnectionString;

        public Odjeli()
        {
            InitializeComponent();
            DGVfill();
            
            
        }

        private void Btn_spremi_Click(object sender, EventArgs e)
        {
            if (txt_odjel.Text == "")
            {
                txt_odjel.BackColor = Color.LightPink;
                MessageBox.Show($"Čelija ne smije biti prazna!");
            }
            else
            {
                txt_odjel.BackColor = Color.White;

                string unos = $"INSERT INTO odjeli(Id,nazivOdjela) VALUES(@Id,@Naziv)";
                //var Conn = DBC.Conn;
                //var Cmd = new OleDbCommand(Unos, Conn);            

                try
                {
                    // create sql connection object.
                    var conn = new SqlConnection(strConnection);
                    // create command object with SQL query and link to connection object
                    var cmd = new SqlCommand(unos, conn);
                    cmd.Parameters.AddWithValue("@Naziv", txt_odjel.Text.Trim());
                    cmd.Parameters.AddWithValue("@Id",txt_id.Text);

                    // open sql connection
                    conn.Open();

                    // execute the query and return number of rows affected, should be one
                    int RowsAffected = cmd.ExecuteNonQuery();

                    // close connection when done
                    conn.Close();

                    if (RowsAffected == 1)
                    {
                        DGVfill();
                        txt_odjel.Clear();
                        txt_odjel.Focus();

                    }
                    else
                        MessageBox.Show($"Unos nove stavke nije uspješan!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Izmjena nije uspjela\n {ex.ToString()}");
                }
            }
        }

        // Punjenje DGV forme
        private void DGVfill()
        {
            //string DBS = $"SELECT * FROM odjeli;";
            //dgv.DataSource = DBC.DGVselect(DBS);
            try
            {
                var select = "SELECT * FROM odjeli";
                var c = new SqlConnection(strConnection); // Your Connection String here
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);

                //dataGridView1.ReadOnly = true;
                //dataGridView1.DataSource = ds.Tables[0];
                dgv.ReadOnly = true;
                dgv.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }


            // Izmjena postojećih unosa
       /*     private void btn_izmjeni_Click(object sender, EventArgs e)
            {
            if (txt_odjel.Text == "")
            {
                txt_odjel.BackColor = Color.LightPink;
                MessageBox.Show($"Čelija ne smije biti prazna!");
            }
            else
            {
                txt_odjel.BackColor = Color.White;

                string Uredi = $"UPDATE odjeli SET ID=@ID, Naziv=@Naziv WHERE ID=@ID;";
                var Conn = DBC.Conn;
                var Cmd = new OleDbCommand(Uredi, Conn);
                Cmd.Parameters.AddWithValue("@ID", int.Parse(txt_id.Text.Trim()));
                Cmd.Parameters.AddWithValue("@Naziv", txt_odjel.Text.Trim());

                bool success = Upit.BoolIzmjena(Conn, Cmd);

                if (success == true)
                {
                    DGVfill();
                    txt_id.Clear();
                    txt_odjel.Clear();
                    txt_odjel.Focus();
                }
                else
                {
                    MessageBox.Show($"Izmjena nije uspjela!");
                }
            }
        }
        */
        // PRetraživanje učitanih polja tablice

        private void txt_pretrazivanje_TextChanged_1(object sender, EventArgs e)
        {
            (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("nazivOdjela LIKE '%{0}%'", txt_pretrazivanje.Text.Trim());
            if (dgv.Rows[0].Cells[0].Value == null) { return; }
        }

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txt_id.Text = dgv.Rows[RowIndex].Cells[0].Value.ToString();
            txt_odjel.Text = dgv.Rows[RowIndex].Cells[1].Value.ToString();

        }
    }
}
