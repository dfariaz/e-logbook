using e_LogBook.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace e_LogBook.Controller
{
    public class LoginController
    {
        Defaults dft = new Defaults();
        private int _result;
        public int loginValidate(string login, string senha, string check)
        {
            if (!statusValidate(login))
                _result = 0;
            else
            {
                string nSenha = Tools.getMD5Hash(senha);
                string _campos = "Login, Senha";
                string _comandos = "Motorista WHERE Login = '" + login + "' && Senha = '" + nSenha + "'";
                if (dft.selectBool(_campos, _comandos))
                {
                    _result = 1;
                    if (check == "1" && _result == 1)
                        rememberLogin(login, senha, check);
                    else
                        deleteremember();
                }
                else
                    _result = 2;
            }
            return _result;
        }

        public bool statusValidate(string login)
        {
            string _campos = "*";
            string _comandos = "Motorista WHERE Login = '" + login + "' && Status = 1";
            bool _result = dft.selectBool(_campos, _comandos);
            return _result;
        }

        private void rememberLogin(string login, string senha, string check)
        {
            Settings.Default.uLogin = login;
            Settings.Default.uPass = senha;
            Settings.Default.uCheck = check;
            Settings.Default.Save();
        }

        private void deleteremember()
        {
            Settings.Default.uLogin = "0";
            Settings.Default.uPass = "0";
            Settings.Default.uCheck = "0";
            Settings.Default.Save();
        }

        public DataTable getInformation(string login)
        {
            string _campos = "*";
            string _comandos = "Motorista WHERE Login = '" + login + "'";
            return dft.select(_campos, _comandos);
        }
    }
}
