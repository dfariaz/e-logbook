using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace e_LogBook.DAO
{
    public class BDConnectionSqlite
    {
        private string connectionString = string.Empty;

        #region SQLite  
        public void createStringConnection()
        {
            string strconn = @"DataSource=C:\eLogBook\BD\Local.sqlite";
            connectionString = strconn;
        }

        SQLiteConnection con;

        public SQLiteConnection abreConexao()
        {
            createStringConnection();
            con = new SQLiteConnection(connectionString);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                return con;
            }
            else
                return con;
        }

        public SQLiteConnection fechaConexao()
        {
            createStringConnection();
            con = new SQLiteConnection(connectionString);
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Open();
                return con;
            }
            else
                return con;
        }

        #endregion 
    }
}
