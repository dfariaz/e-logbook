using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_LogBook.Model
{
    public class Freights
    {
        public int ID { get; private set; }
        public int IDMotorista { get; set; }
        public string CidadeInicial { get; set; }
        public string CidadeDestino { get; set; }
        public uint KMRodado { get; set; }
        public string Carga { get; set; }
        public double Dano { get; set; }
        public DateTime DataFinalFrete { get; private set; }
        public double Pontuacao { get; set; }
    }
}
