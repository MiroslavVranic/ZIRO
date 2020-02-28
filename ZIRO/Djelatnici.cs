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
    public partial class Djelatnici : Form
    {
        readonly DataBase DBC = new DataBase();
        public Djelatnici()
        {
            InitializeComponent();
            DGVfill();
        }

        private void btn_spremi_Click(object sender, EventArgs e)
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
