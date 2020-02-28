using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIRO
{
    class DataBase
    {
        public string MasterConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\inventar.accdb; Persist Security Info = false";

        OleDbConnection CONN { get; set; }
        OleDbCommand CMD { get; set; }
        DataTable DT { get; set; }
        OleDbDataAdapter ADPT { get; set; }

        // DATAGRIDVIEW select 

        public DataTable DGVselect(string DBS)
        {
            CONN = new OleDbConnection(MasterConnString);
            CMD = new OleDbCommand(DBS, CONN);
            DT = new DataTable();
            ADPT = new OleDbDataAdapter(CMD);

            CONN.Open();
            ADPT.Fill(DT);

            return DT;
        }
    }
}
