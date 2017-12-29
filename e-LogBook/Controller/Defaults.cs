using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using e_LogBook.DAO;

namespace e_LogBook.Controller
{
    public class Defaults
    {
        BDConnection bdc = new BDConnection();

        private MySqlDataAdapter _mDA;
        private MySqlCommand _mCMD;
        private DataTable _dt;
        private string _sql, rtrInsert, rtrUpdate, rtrDelete;

        /* Comandos padrões de manipulação do banco de dados.
        * Os metodos que retornam strings precisam ser tratados nas controllers.
        */

        //Retorna um datatable
        #region SELECT
        public DataTable select(string campos, string comandos)
        {
            bdc.closeConnection();
            try
            {
                _sql = "SELECT " + campos + " FROM " + comandos + "";
                _mDA = new MySqlDataAdapter(_sql, bdc.openConnection());
                _dt = new DataTable();
                _mDA.Fill(_dt);
                return _dt;
            }
            catch(MySqlException e_mysql)
            {
                return _dt;
            }
            catch(Exception e)
            {
                return _dt;
            }
        }
        #endregion

        //Retorna um bool
        #region SELECT BOOL
        public bool selectBool(string campos, string comandos)
        {
            bdc.closeConnection();
            try
            {
                _sql = "SELECT " + campos + " FROM " + comandos + "";
                _mDA = new MySqlDataAdapter(_sql, bdc.openConnection());
                _dt = new DataTable();
                _mDA.Fill(_dt);
                if (_dt.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException e_mysql)
            {
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion

        //Retorna uma string
        #region INSERT
        public string Insert(string tabela, string comandos)
        {
            bdc.closeConnection();
            try
            {
                _sql = "INSERT INTO " + tabela + " " + comandos;
                _mCMD = new MySqlCommand(_sql, bdc.openConnection());
                int _vCMD = _mCMD.ExecuteNonQuery();
                if (_vCMD >= 1)
                {
                    rtrInsert = "true";
                    return rtrInsert;
                }
                else
                {
                    rtrInsert = "false";
                    return rtrInsert;
                }
            }
            catch (MySqlException mysql)
            {
                rtrInsert = mysql.Number.ToString();
                return rtrInsert;
            }
            catch (Exception ex)
            {
                rtrInsert = ex.HResult.ToString();
                return rtrInsert;
            }
        }

        public string InsertFrete(string tabela, uint kmrodado, double dano, double pontuacao, string carga, string cityinicio, string citydestino, string datafinalfrete, int id)
        {
            bdc.closeConnection();
            try
            {
                _sql = "INSERT INTO " + tabela + " (KmRodado, Dano, Pontuacao, Carga, CidadeInicial, CidadeDestino, DataFinalFrete, IdMotorista) VALUES ("+kmrodado+", @dano, @pontuacao, '"+carga+"', '"+cityinicio+"', '"+citydestino+"', '"+datafinalfrete+"', "+id+")";
                _mCMD = new MySqlCommand(_sql, bdc.openConnection());
                _mCMD.Parameters.Add("@dano", MySqlDbType.Double).Value = dano;
                _mCMD.Parameters.Add("@pontuacao", MySqlDbType.Double).Value = pontuacao;
                int _vCMD = _mCMD.ExecuteNonQuery();
                if (_vCMD >= 1)
                {
                    rtrInsert = "true";
                    return rtrInsert;
                }
                else
                {
                    rtrInsert = "false";
                    return rtrInsert;
                }
            }
            catch (MySqlException mysql)
            {
                rtrInsert = mysql.Number.ToString();
                return rtrInsert;
            }
            catch (Exception ex)
            {
                rtrInsert = ex.HResult.ToString();
                return rtrInsert;
            }
        }
        #endregion

        //Retorna uma string
        #region UPDATE
        public string Update(string tabela, string colunasvalores, string condicao)
        {
            bdc.closeConnection();
            try
            {
                if(condicao != "")
                    _sql = "UPDATE " + tabela + " SET " + colunasvalores + " WHERE " + condicao + "";
                else
                    _sql = "UPDATE " + tabela + " SET " + colunasvalores;
                _mCMD = new MySqlCommand(_sql, bdc.openConnection());
                int _vCMD = _mCMD.ExecuteNonQuery();
                if (_vCMD == 1)
                {
                    rtrUpdate = "true";
                    return rtrUpdate;
                }
                else
                {
                    rtrUpdate = "false";
                    return rtrUpdate;
                }
            }
            catch (MySqlException mysql)
            {
                rtrUpdate = mysql.Number.ToString();
                return rtrUpdate;
            }
            catch (Exception ex)
            {
                rtrUpdate = ex.HResult.ToString();
                return rtrUpdate;
            }
        }

        public string InsertRanking(string tabela, double kmMes, double kmAno, double pontuacaoMes, double pontuacaoAno, int Mes, int Ano, int Empresa, int Motorista)
        {
            bdc.closeConnection();
            try
            {
                _sql = "INSERT INTO " + tabela + " VALUES (null, @kmMes, @kmAno, @pontuacaoMes, @pontuacaoAno, @Mes, @Ano, @idMotorista, @idEmpresa)";
                _mCMD = new MySqlCommand(_sql, bdc.openConnection());
                _mCMD.Parameters.Add("@kmMes", MySqlDbType.Double).Value = kmMes;
                _mCMD.Parameters.Add("@kmAno", MySqlDbType.Double).Value = kmAno;
                _mCMD.Parameters.Add("@pontuacaoMes", MySqlDbType.Double).Value = pontuacaoMes;
                _mCMD.Parameters.Add("@pontuacaoAno", MySqlDbType.Double).Value = pontuacaoAno;
                _mCMD.Parameters.Add("@Mes", MySqlDbType.Int32).Value = Mes;
                _mCMD.Parameters.Add("@Ano", MySqlDbType.Int32).Value = Ano;
                _mCMD.Parameters.Add("@idMotorista", MySqlDbType.Int32).Value = Motorista;
                _mCMD.Parameters.Add("@idEmpresa", MySqlDbType.Int32).Value = Empresa;
                int _vCMD = _mCMD.ExecuteNonQuery();
                if (_vCMD == 1)
                {
                    rtrInsert = "true";
                    return rtrInsert;
                }
                else
                {
                    rtrInsert = "false";
                    return rtrInsert;
                }
            }
            catch (MySqlException mysql)
            {
                rtrInsert = mysql.Number.ToString();
                return rtrInsert;
            }
            catch (Exception ex)
            {
                rtrInsert = ex.HResult.ToString();
                return rtrInsert;
            }
        }

        public string UpdateRanking(string tabela, double kmMes, double kmAno, double pontuacaoMes, double pontuacaoAno, int Empresa, string condicao)
        {
            bdc.closeConnection();
            try
            {
                _sql = "UPDATE " + tabela + " SET KMMes = @kmMes, KMAno = @kmAno, PontosMes = @pontuacaoMes, PontosAno = @pontuacaoAno, IdEmpresa = @idEmpresa WHERE " + condicao + "";
                _mCMD = new MySqlCommand(_sql, bdc.openConnection());
                _mCMD.Parameters.Add("@kmMes", MySqlDbType.Double).Value = kmMes;
                _mCMD.Parameters.Add("@kmAno", MySqlDbType.Double).Value = kmAno;
                _mCMD.Parameters.Add("@pontuacaoMes", MySqlDbType.Double).Value = pontuacaoMes;
                _mCMD.Parameters.Add("@pontuacaoAno", MySqlDbType.Double).Value = pontuacaoAno;
                _mCMD.Parameters.Add("@idEmpresa", MySqlDbType.Int32).Value = Empresa;
                int _vCMD = _mCMD.ExecuteNonQuery();
                if (_vCMD == 1)
                {
                    rtrUpdate = "true";
                    return rtrUpdate;
                }
                else
                {
                    rtrUpdate = "false";
                    return rtrUpdate;
                }
            }
            catch (MySqlException mysql)
            {
                rtrUpdate = mysql.Number.ToString();
                return rtrUpdate;
            }
            catch (Exception ex)
            {
                rtrUpdate = ex.HResult.ToString();
                return rtrUpdate;
            }
        }

        #endregion

        //Retorna uma string
        #region DELETE
        public string Delete(string tabela, string condicao)
        {
            bdc.closeConnection();
            try
            {
                _sql = "DELETE FROM " + tabela + " WHERE " + condicao + "";
                _mCMD = new MySqlCommand(_sql, bdc.openConnection());
                int _vCMD = _mCMD.ExecuteNonQuery();
                if (_vCMD >= 1)
                {
                    rtrDelete = "true";
                    return rtrDelete;
                }
                else
                {
                    rtrDelete = "false";
                    return rtrDelete;
                }
            }
            catch (MySqlException mysql)
            {
                rtrDelete = mysql.Number.ToString();
                return rtrDelete;
            }
            catch (Exception ex)
            {
                rtrDelete = ex.HResult.ToString();
                return rtrDelete;
            }
        }
        #endregion
    }
}
