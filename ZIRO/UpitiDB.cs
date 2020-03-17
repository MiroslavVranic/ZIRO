using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIRO
{
    class UpitiDB
    {
        public string strConnection = Properties.Settings.Default.DatabaseConnectionString;

        /// <summary>
        /// Sve metode za unos podataka iz formi u bazu podataka
        /// </summary>

        // Unos/Insert
        public bool BoolUnos(SqlCommand Cmd, SqlConnection Conn)
        {
            
            bool isSuccess = false;
            try
            {
                Conn.Open();
                int rows = Cmd.ExecuteNonQuery();
                if (rows > 0)
                    isSuccess = true;
                else
                    isSuccess = false;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                Conn.Close();
            }
            return isSuccess;
        }

        // Izmjena/Update
        public bool BoolIzmjena(SqlCommand Cmd, SqlConnection Conn)
        {          
            bool isSuccess = false;
            try
            {
                Conn.Open();
                int rows = Cmd.ExecuteNonQuery();
                if (rows > 0)
                    isSuccess = true;
                else
                    isSuccess = false;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                Conn.Close();
            }
            return isSuccess;
        }

        #region Provjera zaduženja 
        public bool ProvjeraZaduzenja(string invBroj)
        {
            bool success = false;
            string dalPostojis = $"SELECT * FROM zaduzenja WHERE " +
                $"uredajInvBroj=@uredajInvBroj AND datRazduzenja IS NULL";
            var Conn = new SqlConnection(strConnection);
            var Cmd = new SqlCommand(dalPostojis, Conn);
            Cmd.Parameters.AddWithValue("@uredajInvBroj", invBroj);
            try
            {
                Conn.Open();
                SqlDataReader korisnik = Cmd.ExecuteReader();
                if (korisnik.HasRows)
                    success = false;
                else
                    success = true;
            }
            catch (Exception ex) { MessageBox.Show($"Dgodila se greška prilikom pretrage zaduženja!\n{ex.Message}", "Pažnja"); }
            finally
            {
                Conn.Close();
            }
            return success;
        }
        public bool ProvjeraZaduzenja(string djelatnik, string invBroj)
        {
            bool success = false;
            string dalPostojis = $"SELECT * FROM zaduzenja WHERE " +
                $"djelatnikOib=@djelatnikOib AND uredajInvBroj=@uredajInvBroj AND datRazduzenja IS NULL";
            var Conn = new SqlConnection(strConnection);
            var Cmd = new SqlCommand(dalPostojis, Conn);
            Cmd.Parameters.AddWithValue("@djelatnikOib", djelatnik);
            Cmd.Parameters.AddWithValue("@uredajInvBroj", invBroj);
            try
            {
                Conn.Open();
                SqlDataReader korisnik = Cmd.ExecuteReader();
                if (korisnik.HasRows)
                    success = true;
                else
                    success = false;
            }
            catch (Exception ex) { MessageBox.Show($"Dgodila se greška prilikom pretrage zaduženja!\n{ex.Message}", "Pažnja"); }
            finally
            {
                Conn.Close();
            }
            return success;
        }

        #endregion
    }
}
