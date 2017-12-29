using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data;
using e_LogBook.Properties;
using e_LogBook.Model;

namespace e_LogBook.Controller
{
    public class Optional
    {
        Defaults dft = new Defaults();
        CompanyController cll = new CompanyController();

        // Força da Senha
        public int geraPontosSenha(string senha)
        {
            if (senha == null) return 0;
            int pontosPorTamanho = GetPontoPorTamanho(senha);
            int pontosPorMinusculas = GetPontoPorMinusculas(senha);
            int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
            int pontosPorDigitos = GetPontoPorDigitos(senha);
            int pontosPorSimbolos = GetPontoPorSimbolos(senha);
            int pontosPorRepeticao = GetPontoPorRepeticao(senha);
            return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
        }

        private int GetPontoPorTamanho(string senha)
        {
            return Math.Min(10, senha.Length) * 6;
        }

        private int GetPontoPorMinusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorMaiusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorDigitos(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorSimbolos(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorRepeticao(string senha)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
            bool repete = regex.IsMatch(senha);
            if (repete)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }

        /* 
         * Classificação da Senha
         * 0 Inaceitavel
         * 1 Fraca
         * 2 Aceitavel
         * 3 Forte
         * 4 Segura
        */

        public int GetForcaDaSenha(string senha)
        {
            int placar = geraPontosSenha(senha);

            if (placar < 50)
                return 0;
            else if (placar < 60)
                return 1;
            else if (placar < 80)
                return 2;
            else if (placar < 100)
                return 3;
            else
                return 4;
        }

        #region CORES

        public string saveColors(string ecolor, string tcolor, string fcolor, int idempresa)
        {
            string _tabela = "Cores";
            string _comandos = "VALUES (null, '" + ecolor + "', '" + tcolor + "', '" + fcolor + "', "+idempresa+")";
            return dft.Insert(_tabela, _comandos);
        }

        public string updateColors(string ecolor, string tcolor, string fcolor, int idempresa)
        {
            string _tabela = "Cores";
            string _comandos = "CorELog = '" + ecolor + "', CorTitulo = '" + tcolor + "', CorFonte = '" + fcolor + "'";
            string _condicao = "IdEmpresa = " + idempresa;
            string _result =  dft.Update(_tabela, _comandos, _condicao);
            if(_result == "true")
            {
                saveSettingsColors(idempresa);
                return _result;
            }
            else
            {
                return _result;
            }
        }

        public bool getColors(int idempresa)
        {
            string _campos = "*";
            string _comandos = "Cores WHERE IdEmpresa = "+idempresa;
            return dft.selectBool(_campos, _comandos);
        }

        public DataTable getColorsTable(int idempresa)
        {
            string _campos = "*";
            string _comandos = "Cores WHERE IdEmpresa = " + idempresa;
            return dft.select(_campos, _comandos);
        }

        private void ColorsSettings(string ecolor, string tcolor, string fcolor)
        {
            Settings.Default.colorEBook = ecolor;
            Settings.Default.colorTitulo = tcolor;
            Settings.Default.colorFonte = fcolor;
            Settings.Default.Save();
        }

        private string elogbook_color, titulo_color, fontes_color;

        public void saveSettingsColors(int idempresa)
        {             
            bool existsColors;
            existsColors = getColors(idempresa);
            colors(existsColors, idempresa);
            ColorsSettings(elogbook_color, titulo_color, fontes_color);
        }

        private void colors(bool exists, int idempresa)
        {
            //Configura as cores padrão
            if (!exists)
            {
                elogbook_color = "CornflowerBlue";
                titulo_color = "SteelBlue";
                fontes_color = "ControlLightLight";
            }
            else
            {
                DataTable _dt = getColorsTable(idempresa);
                foreach (DataRow dr in _dt.Rows)
                {
                    elogbook_color = dr["CorELog"].ToString();
                    titulo_color = dr["CorTitulo"].ToString();
                    fontes_color = dr["CorFonte"].ToString();
                }
            }
        }

        #endregion

        #region Ranking 

        public string zerarRanking(string opcao)
        {
            string _tabela = "Ranking";
            string _comandos;
            string Mes = DateTime.Now.Month.ToString();
            string Ano = DateTime.Now.Year.ToString();
            string _condicao;
            if (opcao == "Mês")
            {
                _comandos = "KMMes = 0, PontosMes = 0";
                _condicao = "Mes = '" + Mes + "' AND Ano = '" + Ano + "'";
                return dft.Update(_tabela, _comandos, _condicao);
            }
            else
            {
                _comandos = "KMAno = 0, PontosAno = 0";
                _condicao = "Ano = '" + Ano + "'";
                return dft.Update(_tabela, _comandos, _condicao);
            }
        }

        private double ranking_KMMES, ranking_KMANO, ranking_POINTMES, ranking_POINTANO;

        public string saveRanking(int idMotorista, double pontuacao, uint km, int idEmpresa)
        {
            /*
             * Tipos:
             * 1 - Mensal
             * 2 - Anual
             */
            int Mes = Convert.ToInt32(DateTime.Now.Month.ToString());
            int Ano = Convert.ToInt32(DateTime.Now.Year.ToString());
            string _tabela = "Ranking";
            // Primeiro o Mês
            ranking_POINTMES = 0.0;
            ranking_POINTANO = 0.0;
            ranking_KMMES = 0.0;
            ranking_KMANO = 0.0;

            getRankingOld(1, idMotorista);
            double pontuacaoMes = pontuacao + ranking_POINTMES;
            var kmMes = km + ranking_KMMES;

            getRankingOld(2, idMotorista);
            double pontuacaoAno = pontuacao + ranking_POINTANO;
            var kmAno = km + ranking_KMANO;

            string _condicao = "IdMotorista = " + idMotorista;
            string updateRanking;
            if (ranking_POINTMES == 0 && ranking_POINTANO == 0 && ranking_KMMES == 0 && ranking_KMANO == 0)
                updateRanking = dft.InsertRanking(_tabela, kmMes, kmAno, pontuacaoMes, pontuacaoAno, Mes, Ano, idEmpresa, idMotorista);
            else
                updateRanking = dft.UpdateRanking(_tabela, kmMes, kmAno, pontuacaoMes, pontuacaoAno, idEmpresa, _condicao);

            if (updateRanking != "true")
                return "false";
            else
                return "true";
        }

        private void getRankingOld(int tipo, int id)
        {
            int Ano = Convert.ToInt32(DateTime.Now.Year.ToString());
            int Mes = Convert.ToInt32(DateTime.Now.Month.ToString());
            if(tipo == 1)
            {
                DataTable _dtMes = cll.KMMotoristaMes(id, Mes);
                foreach(DataRow dr in _dtMes.Rows)
                {
                    ranking_KMMES = Convert.ToDouble(dr["KMMes"].ToString());
                    ranking_POINTMES = Convert.ToDouble(dr["PontosMes"].ToString());
                }
            }
            else
            {
                DataTable _dtAno = cll.KMMotoristaAno(id, Ano);
                foreach (DataRow dr in _dtAno.Rows)
                {
                    ranking_KMANO = Convert.ToDouble(dr["KMAno"].ToString());
                    ranking_POINTANO = Convert.ToDouble(dr["PontosAno"].ToString());
                }
            } 
        }

        #endregion

        #region Multas

        private List<Multa> ListaDeMultas = new List<Multa>();

        public void AdicionarNovaMulta(Multa p_Multa)
        {
            ListaDeMultas.Add(p_Multa);
        }

        public void LimparListaDeMultas()
        {
            ListaDeMultas.Clear();
        }

        public List<Multa> ObterListaDeMultas()
        {
            return ListaDeMultas;
        }

        public int ObterNumeroDeMultas()
        {
            return ListaDeMultas.Count;
        }

        #endregion

        public double CalcularPontuacao(double Dano, int NumeroDeMultas, double kmRodado)
        {
            double saida;
            double KmPerdido = 0;

            KmPerdido += NumeroDeMultas;
            KmPerdido += Dano;

            var KmFinal = kmRodado - KmPerdido;
            saida = (KmFinal * 0.005);

            if (NumeroDeMultas == 0 && Dano < 3)
            {
                KmFinal += (KmFinal * 5) / 100;
            }

            return saida;
        }

        public DataTable getTS(int idEmpresa)
        {
            string _campos = "*";
            string _comandos = "TS_Server WHERE IdEmpresa = "+idEmpresa;
            return dft.select(_campos, _comandos);
        }

        public string saveTS(int idEmpresa, string server, string port)
        {
            string _tabela = "TS_Server";
            string _comandos = "Servidor = '" + server + "', Porta '" + port + "'";
            string _condicao = "IdEmpresa = " + idEmpresa;
            return dft.Update(_tabela, _comandos, _condicao);
        }
    }
}
