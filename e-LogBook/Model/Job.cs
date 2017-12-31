using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_LogBook.Model
{
    class Job
    {
        public Job() { }

        private uint j_kmrodado;
        private double j_dano;
        private double j_pontuacao;
        private string j_carga;
        private string j_cityinicio;
        private string j_citydestino;
        private string j_datafinalfrete;
        private int j_idMotorista;
        private int j_EmpresaID;
        private string j_Enviado;

        public Job(uint kmrodado, double dano, double pontuacao, string carga, string cityinicio, string citydestino, string datafinalfrete, int idMotorista, int EmpresaID, string enviado)
        {
            this.j_kmrodado = kmrodado;
            this.j_dano = dano;
            this.j_pontuacao = pontuacao;
            this.j_carga = carga;
            this.j_cityinicio = cityinicio;
            this.j_citydestino = citydestino;
            this.j_datafinalfrete = datafinalfrete;
            this.j_idMotorista = idMotorista;
            this.j_EmpresaID = EmpresaID;
            this.j_Enviado = enviado;
        }

        public int ID
        {
            get { return j_idMotorista; }
            set { j_idMotorista = value; }
        }

        public int IDEmpresa
        {
            get { return j_EmpresaID; }
            set { j_EmpresaID = value; }
        }

        public uint Kmrodado
        {
            get { return j_kmrodado; }
            set { j_kmrodado = value; }
        }

        public double Dano
        {
            get { return j_dano; }
            set { j_dano = value; }
        }

        public double Pontuacao
        {
            get { return j_pontuacao; }
            set { j_pontuacao = value; }
        }

        public string Carga
        {
            get { return j_carga; }
            set { j_carga = value; }
        }

        public string Cityinicio
        {
            get { return j_cityinicio; }
            set { j_cityinicio = value; }
        }

        public string Citydestino
        {
            get { return j_citydestino; }
            set { j_citydestino = value; }
        }

        public string Datafinalfrete
        {
            get { return j_datafinalfrete; }
            set { j_datafinalfrete = value; }
        }

        public string Enviado
        {
            get { return j_Enviado; }
            set { j_Enviado = value; }
        }

        public List<Job> ListJobs = new List<Job>();

        public void AddNewJob(Job n_Job)
        {
            ListJobs.Add(n_Job);
        }

        public List<Job> getJobs()
        {
            return ListJobs;
        }
    }
}
