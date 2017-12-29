using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_LogBook.Controller;

namespace e_LogBook.Model
{
    public class Driver
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Status { get; set; }
        public string Grupo { get; set; }
        public int NumeroCaminhao { get; set; }
        public int IDEmpresa { get; set; }      
    }
}
