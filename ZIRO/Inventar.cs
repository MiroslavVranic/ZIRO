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
    public partial class Inventar : Form
    {
        readonly DataBase DBC = new DataBase();
        public Inventar()
        {
            InitializeComponent();
            DGVfill();
        }

        private void btn_spremi_Click(object sender, EventArgs e)
        {

        }

        private void DGVfill()
        {
            string DBS = $"SELECT * FROM inventar;";
            DataTable dt = DBC.DGVselect(DBS);
            dgv.DataSource = dt;
        }
    }
}
