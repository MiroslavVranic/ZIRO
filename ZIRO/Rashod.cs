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
    public partial class Rashod : Form
    {
        readonly private DataBase dbc = new DataBase();
        readonly private IzvozExcel Ixls = new IzvozExcel();

        public Rashod()
        {
            InitializeComponent();
            DGVfill();
        }

        private void DGVfill()
        {
            string dbs = $"SELECT invBroj, nazivUredaja, datKupovine, datRashoda FROM uredaji WHERE datRashoda IS NOT NULL;";
            dgv.DataSource = dbc.DGVselect(dbs);
        }

        private void BtnIzvozListe_Click(object sender, EventArgs e)
        {
            dgv.RowHeadersVisible = false;
            this.dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgv.SelectAll();
            DataObject PodatciZaExport = dgv.GetClipboardContent();
            if (PodatciZaExport != null)
            {
                Clipboard.SetDataObject(PodatciZaExport);
                Ixls.IzradaExcel(PodatciZaExport);
            }
            dgv.RowHeadersVisible = true;
            dgv.ClearSelection();
        }
    }
}
