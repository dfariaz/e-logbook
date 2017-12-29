using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_LogBook.Model
{
    public class Company
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Responsavel { get; set; }
        public DateTime DataCriacao { get; set; }
        public int Motoristas { get; set; }
        public int KM { get; set; }
    }
}
