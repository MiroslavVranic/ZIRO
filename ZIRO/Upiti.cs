using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIRO
{
    class Upiti
    {
        /// <summary>
        /// Sve metode za unos podataka iz formi u bazu podataka
        /// </summary>

        // Unos
        public bool BoolUnos(OleDbConnection Conn, OleDbCommand Cmd)
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


        // Izmjena

        public bool BoolIzmjena(OleDbConnection Conn, OleDbCommand Cmd)
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
