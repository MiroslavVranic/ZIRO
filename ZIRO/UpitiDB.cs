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
        String strConnection = Properties.Settings.Default.DatabaseConnectionString;

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
    }
}
