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
            string DBS = $"SELECT * FROM djelatnici;";
            DataTable dt = DBC.DGVselect(DBS);
            dgv.DataSource = dt;
        }
    }
}
