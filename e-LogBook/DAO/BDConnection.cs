using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using eLogBook.Data;

namespace e_LogBook.DAO
{
    public class BDConnection
    {
        /* 
         * Projeto e-LogBook
         * Dev: Deivid Farias | Data: 13/12/2017
         * Class BDConnection
         * 
         * Classe de conexão com o banco de dados
         * zeroh537_master | @Logbook
         * zeroh537_LogBook_Teste
         */

        private string connectionString = string.Empty;
        MySqlConnection con;
        Class cls = new Class();

        public void createStringConnection()
        {
            connectionString = cls.cString();
        }

        public MySqlConnection openConnection()
        {
            createStringConnection();
            con = new MySqlConnection(connectionString);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                return con;
            }
            else
                return con;
        }

        public MySqlConnection closeConnection()
        {
            createStringConnection();
            con = new MySqlConnection(connectionString);
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Open();
                return con;
            }
            else
                return con;
        }
    }
}
