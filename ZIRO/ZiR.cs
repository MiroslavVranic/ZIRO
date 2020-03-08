using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIRO
{
    public partial class ZiR : Form
    {
        readonly DataBase dbc = new DataBase();
        readonly Pomocna pomocna = new Pomocna();
        public ZiR()
        {
            InitializeComponent();
            DGVfill();
        }

        private void Btn_pretrazi_Click(object sender, EventArgs e)
        {
            // treba učtati zaduženja za djelatnika
        }

        private void DGVfill()
        {
            string DBS = $"SELECT uredaji.invBroj, uredaji.nazivUredaja, zaduzenja.datZaduzenja FROM uredaji" +
                $" LEFT JOIN zaduzenja ON uredaji.invBroj = zaduzenja.uredajInvBroj WHERE zaduzenja.datRazduzenja IS NULL;";

            try 
            {
                dgv.DataSource = dbc.DGVselect(DBS);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri dohvačanju djelatnika\n{ex.Message}", pomocna.MsgNazivGreska);
            }
        }
    }
}
