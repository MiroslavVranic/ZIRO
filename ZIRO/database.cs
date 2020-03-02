using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIRO
{
    class DataBase
    {
        public OleDbConnection Conn = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\inventar.accdb; Persist Security Info = false");

        // DATAGRIDVIEW select 
        public DataTable DGVselect(string DBS)
        {
            var Cmd = new OleDbCommand(DBS, Conn);
            var DataT = new DataTable();
            var Adapt = new OleDbDataAdapter(Cmd);
            try
            {
                Conn.Open();
                Adapt.Fill(DataT);
            }
            catch(Exception ex) { throw ex; }
            finally
            {
                Conn.Close();
            }

            return DataT;
        }
        // Autocomplete lista za fomre
        public AutoCompleteStringCollection Kolekcija(string DBS, string PrviUvjet)
        {
            var kolekcija = new AutoCompleteStringCollection();
            var Cmd = new OleDbCommand(DBS, Conn);
            Conn.Open();
            try
            {
                OleDbDataReader myReader = Cmd.ExecuteReader();
                int jedan = myReader.GetOrdinal(PrviUvjet);
                while (myReader.Read())
                {
                    string prviString = myReader.GetString(jedan);
                    kolekcija.Add(prviString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
            return kolekcija;
        }

        public AutoCompleteStringCollection AutoComplete(string DBS, string PrviUvjet, string DrugiUvjet)
        {
            var kolekcija = new AutoCompleteStringCollection();
            var Cmd = new OleDbCommand(DBS, Conn);
            Conn.Open();
            try
            {
                OleDbDataReader myReader = Cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string prviString = myReader[PrviUvjet].ToString();
                    string drugiString = myReader[DrugiUvjet].ToString();
                    kolekcija.Add($"{prviString} {drugiString}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
            finally
            {
                Conn.Close();
            }
            return kolekcija;
        }
    }

}
