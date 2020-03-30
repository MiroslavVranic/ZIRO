using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIRO
{
    class DataBase
    {
        public string strConnection = Properties.Settings.Default.DatabaseConnectionString;

        // public string ConnString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\inventar.accdb; Persist Security Info = false";
        readonly Pomocna pomocna = new Pomocna();

        public int StraniKljuc { get; private set; }
        public static string Username { get; set; }
        public static string TrenutniKorisnik { get; set; }
        public static string UlogaKorisnika { get; set; }

        // DATAGRIDVIEW select 
        public DataTable DGVselect(string DBS)
        {
            var Conn = new SqlConnection(strConnection);
            var Cmd = new SqlCommand(DBS, Conn);
            var DataT = new DataTable();
            var Adapt = new SqlDataAdapter(Cmd);
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
        public DataTable DGVselect(SqlCommand Cmd, SqlConnection Conn)
        {
            var DataT = new DataTable();
            var Adapt = new SqlDataAdapter(Cmd);
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
            var Conn = new SqlConnection(strConnection);
            var Cmd = new SqlCommand(DBS, Conn);
            Conn.Open();
            try
            {
                SqlDataReader myReader = Cmd.ExecuteReader();
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
            var Conn = new SqlConnection(strConnection);
            var Cmd = new SqlCommand(DBS, Conn);
            Conn.Open();
            try
            {
                SqlDataReader myReader = Cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string prviString = myReader[PrviUvjet].ToString();
                    string drugiString = myReader[DrugiUvjet].ToString();
                    kolekcija.Add($"{prviString} {drugiString}");
                }
            }
            catch (Exception ex){ MessageBox.Show( ex.Message, pomocna.MsgNazivGreska); }
            finally
            {
                Conn.Close();
            }
            return kolekcija;
        }

        public int ForKey(string StoTrazim, string IzTablice, string IzKolone)
        {
            string Trazi = $"SELECT id FROM { IzTablice } WHERE { IzKolone } = '{ StoTrazim }';";
            var Conn = new SqlConnection(strConnection);
            var Cmd = new SqlCommand(Trazi, Conn);
            try
            {
                Conn.Open();
                return StraniKljuc = (int)Cmd.ExecuteScalar();
            }
            catch (Exception ex) { MessageBox.Show($"Strani ključ nije nađen\n{ ex }"); }
            finally
            {
                Conn.Close();
            }
            return StraniKljuc;
        }
        public string KriptirajLozinku(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public void KorsinikAplikacije(string korisnickoIme)
        {            
            string Trazi = $"SELECT djelatnici.ime, djelatnici.prezime, korisnici.uloga FROM djelatnici LEFT JOIN korisnici " +
                $"ON djelatnici.oib = korisnici.djelatniciOib WHERE username=@username;";
            var Conn = new SqlConnection(strConnection);
            var Cmd = new SqlCommand(Trazi, Conn);
            Cmd.Parameters.AddWithValue("@username", korisnickoIme);
            try
            {
                Conn.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    var ime = reader[0].ToString();
                    var prezime = reader[1].ToString();
                    var uloga = reader[2].ToString();
                    TrenutniKorisnik = $"{ime} {prezime}";
                    UlogaKorisnika = $"{uloga}";
                }
            }
            catch (Exception ex) { MessageBox.Show($"Korisničko ime nije nađeno u bazi!\n{ ex.Message }", pomocna.MsgNazivGreska); }
            finally
            {
                Conn.Close();
            }
        }
    }
}
