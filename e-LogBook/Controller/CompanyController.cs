using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_LogBook.Model;
using e_LogBook.DAO;
using System.Data;

namespace e_LogBook.Controller
{
    public class CompanyController
    {
        Defaults dft = new Defaults();

        public DataTable infoEmpresa(int id)
        {
            string _campos, _comandos;
            if (id == 0)
            {
                _campos = "*";
                _comandos = "Empresa";
            }
            else
            {
                _campos = "Count(m.ID) as Motoristas, e.Nome, e.ID";
                _comandos = "Empresa e INNER JOIN Motorista m ON e.ID = m.IDEmpresa WHERE e.ID = " + id;
            }
            return dft.select(_campos, _comandos);
        }

        public DataTable KMMotoristaMes(int id, int mes)
        {
            string _campos = "r.KMMes as KMMes, r.PontosMes as PontosMes";
            string _comandos = "Motorista m inner JOIN Ranking r on r.IDMotorista = m.ID WHERE m.IDEmpresa = " + id + " AND r.Mes = '" + mes + "'";
            return dft.select(_campos, _comandos);
        }

        public DataTable KMMotoristaAno(int id, int ano)
        {
            string _campos = "r.KMAno as KMAno, r.PontosAno as PontosAno";
            string _comandos = "Motorista m inner JOIN Ranking r on r.IDMotorista = m.ID WHERE m.IDEmpresa = " + id + " AND r.Ano = '" + ano + "'";
            return dft.select(_campos, _comandos);
        }

        public DataTable KMEmpresaMes(int id, int mes)
        {
            string _campos = "r.KMMes as KMMes";
            string _comandos = "Empresa e inner JOIN Ranking r on r.IDEmpresa = e.ID WHERE e.ID = " + id + " AND r.Mes = '" + mes + "'";
            return dft.select(_campos, _comandos);
        }

        public DataTable KMEmpresaAno(int id, int ano)
        {
            string _campos = "r.KMAno as KMAno";
            string _comandos = "Empresa e inner JOIN Ranking r on r.IDEmpresa = e.ID WHERE e.ID = " + id + " AND r.Ano = '" + ano + "'";
            return dft.select(_campos, _comandos);
        }

        public string saveCompany(string nome, string responsavel)
        {
            string _tabela = "Empresa";
            string _comandos = "VALUES (null, '" + nome + "', '" + responsavel + "', CURDATE())";
            return dft.Insert(_tabela, _comandos);
        }
    }
}
