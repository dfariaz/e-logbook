using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_LogBook.Model;
using e_LogBook.DAO;
using System.Data;
using e_LogBook.Properties;

namespace e_LogBook.Controller
{
    public class DriverController
    {
        Defaults dft = new Defaults();
        Optional opt = new Optional();
        Job jobs = new Job();

        public DataTable getInformation(int id)
        {
            string _campos = "*";
            string _comandos = "Motorista WHERE ID = " + id + "";
            return dft.select(_campos, _comandos);
        }

        public DataTable getInformationSpecific(int id)
        {
            string _campos = "Nome, IdEmpresa, IF(Status = 1, 'Ativo', 'Inativo') as Status, NumeroCaminhao";
            string _comandos = "Motorista WHERE ID = " + id + "";
            return dft.select(_campos, _comandos);
        }

        public DataTable getInformationMotoristas(int EmpresaID)
        {
            string _campos = "ID, Nome, DATE_FORMAT(DataCadastro, '%d/%m/%Y') as DataCadastro, IF(Status = 1, 'Ativo', 'Inativo') as Status";
            string _comandos = "Motorista WHERE IdEmpresa = "+EmpresaID;
            return dft.select(_campos, _comandos);
        }

        public string setADM(int id, int up)
        {
            string _tabela = "Motorista";
            string _comandos;
            if (up == 0)
                _comandos = "Grupo = 1";
            else
                _comandos = "Grupo = 2";
            string _condicao = "ID = " + id;
            return dft.Update(_tabela, _comandos, _condicao);
        }

        public DataTable getAllMotoristas()
        {
            string _campos = "ID, Nome";
            string _comandos = "Motorista";
            return dft.select(_campos, _comandos);
        }

        public DataTable getFreightsCount(int id, int mes, int ano)
        {
            string _campos = "Count(f.id) as CFretes, r.PontosMes as PontosMes, r.PontosAno as PontosAno";
            string _comandos = "Frete f INNER JOIN Ranking r ON(r.IdMotorista = f.IDMotorista) WHERE f.IdMotorista = " + id + " AND r.Mes = '"+mes+"' AND r.Ano = '"+ano+"'";
            return dft.select(_campos, _comandos);
        }

        public DataTable getFreights(int id, int registros)
        {
            string _campos = "ID,CidadeInicial, CidadeDestino, KmRodado, Carga, ROUND(Dano, 2) as Dano, DataFinalFrete, Pontuacao";
            string _comandos;
            if (registros != 0)
                _comandos = "Frete WHERE IdMotorista = " + id + " ORDER BY ID DESC Limit " + registros + "";
            else
                _comandos = "Frete WHERE IdMotorista = " + id + " ORDER BY ID DESC";
            return dft.select(_campos, _comandos);
        }

        

        public string saveFreight(uint kmrodado, double dano, double pontuacao, string carga, string cityinicio, string citydestino, string datafinalfrete, int idM, int EmpresaID)
        {
            string _tabela = "Frete";
            if (Tools.checkConnection())
            {
                string _result = dft.InsertFrete(_tabela, kmrodado, dano, pontuacao, carga, cityinicio, citydestino, datafinalfrete, idM);
                if (_result == "true")
                {
                    /*** List
                    */
                    string Enviado = "Enviado";
                    saveLocal(kmrodado, dano, pontuacao, carga, cityinicio, citydestino, datafinalfrete, idM, EmpresaID, Enviado);
                    if (opt.saveRanking(idM, pontuacao, kmrodado, EmpresaID) == "true")
                        _result = "true";
                    else
                        _result = "rankingFalse";
                }
                else
                    _result = "false";
                return _result;
            }
            else
            {
                string Enviado = "Não Enviado";
                saveLocal(kmrodado, dano, pontuacao, carga, cityinicio, citydestino, datafinalfrete, idM, EmpresaID, Enviado);
                return "connectionoff";
            }
        }

        public void saveLocal(uint kmrodado, double dano, double pontuacao, string carga, string cityinicio, string citydestino, string datafinalfrete, int idM, int EmpresaID, string Enviado)
        {
            string _tabela = "dadosLocais";
            string _result = dft.InsertLite(_tabela, kmrodado, dano, pontuacao, carga, cityinicio, citydestino, datafinalfrete, Enviado, idM, EmpresaID);
        }


        public string updateDados(string nome, string senha, int id)
        {
            string _comandos;
            string _tabela = "Motorista";

            if (!senha.Equals("Sem"))
                _comandos = "Nome = '" + nome + "', Senha = '" + senha + "'";
            else
                _comandos = "Nome = '" + nome + "'";

            string _condicao = "ID = "+id;
            return dft.Update(_tabela, _comandos, _condicao);
        }

        public string saveDriverDetails(int status, int empresa, int id)
        {
            string _tabela = "Motorista";
            string _comandos = "Status = " + status + ", IdEmpresa = " + empresa;
            string _condicao = "ID = "+id;
            return dft.Update(_tabela, _comandos, _condicao);
        }

        public string saveNumber(int number, int id)
        {
            string _tabela = "Motorista";
            string _comandos = "NumeroCaminhao = " + number;
            string _condicao = "ID = " + id;
            return dft.Update(_tabela, _comandos, _condicao);
        }

        public string resetPassDefault(string pass, int id)
        {
            string _tabela = "Motorista";
            string _comandos = "Senha = '" + pass + "'";
            string _condicao = "ID = " + id;
            return dft.Update(_tabela, _comandos, _condicao);
        }
    }
}
