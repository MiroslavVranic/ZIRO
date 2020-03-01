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
    public partial class Korisnici : Form
    {
        readonly DataBase DBC = new DataBase();
        public Korisnici()
        {
            InitializeComponent();
            DGVfill();
        }
        private void btn_spremi_Click(object sender, EventArgs e)
        {

        }
        private void DGVfill()
        {
            string DBS = $"SELECT * FROM korisnici;";
            dgv.DataSource = DBC.DGVselect(DBS);
        }
    }
}
