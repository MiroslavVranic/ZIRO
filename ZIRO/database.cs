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
        public string ConnString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\inventar.accdb; Persist Security Info = false";
        readonly Pomocna pomocna = new Pomocna();

        public int StraniKljuc { get; private set; }


        // DATAGRIDVIEW select 
        public DataTable DGVselect(string DBS)
        {
            var Conn = new OleDbConnection(ConnString);
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
            var Conn = new OleDbConnection(ConnString);
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
                MessageBox.Show(ex.Message, pomocna.MsgNazivGreska);
            }
            finally
            {
                Conn.Close();
            }
            return kolekcija;
        }

        public AutoCompleteStringCollection Kolekcija(string DBS, string PrviUvjet, string DrugiUvjet)
        {
            var kolekcija = new AutoCompleteStringCollection();
            var Conn = new OleDbConnection(ConnString);
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
                MessageBox.Show( ex.Message, pomocna.MsgNazivGreska);
            }
            finally
            {
                Conn.Close();
            }
            return kolekcija;
        }
        public int ForKey(string StoTrazim, string IzTablice, string IzKolone)
        {
            string Trazi = $"SELECT id FROM { IzTablice } WHERE { IzKolone } = '{ StoTrazim }';";
            var Conn = new OleDbConnection(ConnString);
            var Cmd = new OleDbCommand(Trazi, Conn);
            try
            {
                Conn.Open();
                return StraniKljuc = (int)Cmd.ExecuteScalar();
            }
            catch (Exception ex) { MessageBox.Show($"Strani ključ nije nađen\n{ ex.Message }"); }
            finally
            {
                Conn.Close();
            }
            return StraniKljuc;
        }
    }
}
