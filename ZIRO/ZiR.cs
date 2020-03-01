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
        readonly DataBase DBC = new DataBase();
        public ZiR()
        {
            InitializeComponent();
            DGVfill();
        }

        private void btn_pretrazi_Click(object sender, EventArgs e)
        {

        }

        private void DGVfill()
        {
            string DBS = $"SELECT inventar.id, inventar.invBroj, inventar.naziv, zaduzenja.datZaduzenja FROM ([inventar]" +
                $" LEFT JOIN zaduzenja ON [inventar].[ID] = [zaduzenja].[idInventar]);";

            try 
            {
                dgv.DataSource = DBC.DGVselect(DBS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
