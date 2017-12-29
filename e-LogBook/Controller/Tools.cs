using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_LogBook.Controller
{
    public class Tools
    {
        public static string getMD5Hash(string input)
        {
            var md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            var sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static string checkUpdate()
        {
            String Saida;

            try
            {
                string versao, Link;

                var request =
                (HttpWebRequest)WebRequest.Create(@"http://cristianoprogramador.com/ZeroHoraVersao.csv");

                var response = request.GetResponse();

                using (Stream stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream, Encoding.UTF8);
                    var temp = (reader.ReadToEnd()).Split(',');

                    versao = temp[0];
                    Link = temp[1];
                }

                if (versao != Application.ProductVersion)
                {
                    Saida = Link;
                }
                else
                {
                    Saida = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Saida = string.Format("Erro ao tentar fazer a requisição: {0}", ex.Message);
            }

            return Saida;
        }

        public static string DiretorioPadraoETS = @"C:\Program Files (x86)\Steam\steamapps\Common\Euro Truck Simulator 2";

        public static bool VerificarPastaETS()
        {
            var diretorio = new DirectoryInfo(DiretorioPadraoETS);

            if (diretorio.Exists)
            {
                return true;
            }

            return false;
        }

        public static bool VerificarETS2MP()
        {
            var saida = false;

            var processes = Process.GetProcesses();

            foreach (var item in processes)
            {
                if (item.MainWindowTitle.Contains("Euro Truck Simulator 2 Multiplayer"))
                {
                    return true;
                }
            }
            return saida;
        }

        public static bool VerificarTeamSpeak()
        {
            var processes = Process.GetProcesses();

            foreach (var item in processes)
            {
                if (item.ProcessName.Contains("ts3client"))
                {
                    return true;
                }
            }
            return false;
        }

        public static void Copiar(string strSource, string strDestination)
        {
            if (!Directory.Exists(strDestination))
            {
                Directory.CreateDirectory(strDestination);
            }

            DirectoryInfo dirInfo = new DirectoryInfo(strSource);
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo tempfile in files)
            {
                tempfile.CopyTo(Path.Combine(strDestination, tempfile.Name), true);
            }

            DirectoryInfo[] directories = dirInfo.GetDirectories();
            foreach (DirectoryInfo tempdir in directories)
            {
                Copiar(Path.Combine(strSource, tempdir.Name), Path.Combine(strDestination, tempdir.Name));
            }

        }
    }
}
