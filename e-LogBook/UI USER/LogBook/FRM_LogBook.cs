using e_LogBook.Controller;
using e_LogBook.Model;
using e_LogBook.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using e_LogBook.Data;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Diagnostics;

/*
 * Parametros LOGBOOK
 * POne = 1 -> Definição de % de KM a mais que o motorista pode fazer. Codigo P0001
 * 
 */

namespace e_LogBook.UI_USER.LogBook
{
    public partial class FRM_LogBook : Form
    {
        Point Ponto = new Point();
        Optional opt = new Optional();
        DriverController drv = new DriverController();
        /****** Refazer a partir daqui *********/

        public FRM_LogBook()
        {
            InitializeComponent();
        }

        //Variaveis de Controle
        //Publicas
        public int LMotorista { get; set; }
        public int LEmpresa { get; set; }
        public string server { get; set; }
        public string port { get; set; }

        //Privadas
        private string cidadeInicial, cidadeDestino, carga, data, enviado, nomeParametroEmpresa;
        private String idCarreta = String.Empty;
        private float VelocidadeAtual = 0;
        private double v_OdometroInicial, dano, pontuacao, kmaMais, kmfinal;
        private int IDMotorista, IDEmpresa, ControleVelocidade = 0, JogoFechado = 0;
        private uint kmRodado, kmFinal; 
        private bool infoIniciais = false, infoFinais = false, cargaAcoplada = false, flag = false;
        private bool whileTS = false;

        // Variaveis Parametros 
        private int parametroEstimado;


        Task LOGBOOKthread;

        private void FRM_LogBook_Load(object sender, EventArgs e)
        {
            if (!this.LMotorista.Equals(""))
                IDMotorista = LMotorista;
            if (!this.LEmpresa.Equals(""))
                IDEmpresa = LEmpresa;
            changeColors();
        }

        #region BOTÕES

        private void button1_Click(object sender, EventArgs e)
        {
            PararLogBook();
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region MOVE FORM

        private void FRM_LogBook_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            Ponto.X = this.Left - MousePosition.X;
            Ponto.Y = this.Top - MousePosition.Y;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = false;
            IniciarLogBook();
        }

        private void FRM_LogBook_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            this.Left = Ponto.X + MousePosition.X;
            this.Top = Ponto.Y + MousePosition.Y;
        }

        CancellationTokenSource source = new CancellationTokenSource();
        CancellationToken token;

        private async void IniciarLogBook()
        {
            token = source.Token;
            await Iniciar(token);
        }

        public async Task Iniciar(CancellationToken token)
        {
            if(JogoFechado == 0)
                LOGBOOKthread = Task.Run(() => { readData(); }, token);
        }

        private void PararLogBook()
        {
            if (source != null)
            {
                source.Cancel();
            }
        }

        #endregion

        #region CORES

        private void changeColors()
        {
            ColorConverter nome = new ColorConverter();
            // Pinta o padrão do formulário
            panelSysTitulo.BackColor = (Color)nome.ConvertFromString(Settings.Default.colorEBook);
            panelTitulo.BackColor = (Color)nome.ConvertFromString(Settings.Default.colorTitulo);
            lblSysTitulo.ForeColor = (Color)nome.ConvertFromString(Settings.Default.colorFonte);
        }

        #endregion

        #region VELOCIDADE E MULTA

        private void TimerAvisoSonoro_Tick(object sender, EventArgs e)
        {
            if (cargaAcoplada == true)
            {
                if (VelocidadeAtual > 100)
                {
                    ControleVelocidade++;
                    ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Bip);
                }
                else
                    ControleVelocidade = 0;

                if (ControleVelocidade >= 5)
                {
                    ControleVelocidade = 0;
                    Multar();
                }
            }
        }

        private void Multar()
        {
            var VelocidadeTemp = 0;
            var multaBase = new Multa();
            VelocidadeTemp = Convert.ToInt32(Math.Round(VelocidadeAtual, 1));
            multaBase.IDMotorista = IDMotorista;
            multaBase.DataDaMulta = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            multaBase.Velocidade = VelocidadeTemp;
            opt.AdicionarNovaMulta(multaBase);
            ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Velocidade);
        }

        #endregion

        private bool gameStatus()
        {
            return Ets2TelemetryDataReader.Instance.Read().Game.Connected;
        }

        private void FinalizarFrete()
        {
            if (!cargaAcoplada)
            {
                data = DateTime.Now.ToString("yyyy-MM-dd");
                string _resultado = drv.saveFreight(kmFinal, dano, pontuacao, carga, cidadeInicial, cidadeDestino, data, IDMotorista, IDEmpresa);
                if (_resultado == "true")
                {
                    enviado = "Enviado";
                    ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Entregue);
                }
                else if (_resultado == "rankingFalse")
                    MessageBox.Show("Ocorreu um erro ao tentar atualizar o ranking!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (_resultado == "connectionoff")
                {
                    MessageBox.Show("Conexão Offline! /n O sistema salvará sua viagem quando houver conexão com a internet!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpaDados();
                    PararLogBook();
                    //this.Close();
                }
                else
                    MessageBox.Show("Ocorreu um erro ao tentar salvar sua carga!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpaDados();
        }

        private void limpaDados()
        {
            v_OdometroInicial = 0;
            idCarreta = "";
            cidadeInicial = "";
            cidadeDestino = "";
            carga = "";
            data = "";
            enviado = "";
            pontuacao = 0;
            dano = 0;
            VelocidadeAtual = 0;
            ControleVelocidade = 0;
            kmRodado = 0;
            infoIniciais = false;
            infoFinais = false;
            kmaMais = 0;
            kmfinal = 0;
            cargaAcoplada = false;
            flag = false;
        }

        private async void readData()
        {
            try
            {
                bool gStatus = this.gameStatus();
                IEts2TelemetryData ets2TelemetryData = Ets2TelemetryDataReader.Instance.Read();
                if (ets2TelemetryData.Game.Connected)
                {
                    JogoFechado = 0;
                    VelocidadeAtual = ets2TelemetryData.Truck.Speed;

                    if (!string.IsNullOrWhiteSpace(ets2TelemetryData.Job.DestinationCity))
                    {
                        if (ets2TelemetryData.Navigation.EstimatedDistance != 0 && ets2TelemetryData.Trailer.Attached)
                        {
                            flag = true;
                            if (!infoIniciais)
                            {
                                parametroEstimado = ets2TelemetryData.Navigation.EstimatedDistance;
                                v_OdometroInicial = ets2TelemetryData.Truck.Odometer;
                                idCarreta = ets2TelemetryData.Trailer.Id;
                                cidadeInicial = ets2TelemetryData.Job.SourceCity;
                                cidadeDestino = ets2TelemetryData.Job.DestinationCity;
                                carga = String.Format("{0} {1}t", ets2TelemetryData.Trailer.Name.ToString(), (ets2TelemetryData.Trailer.Mass / 1000f).ToString());
                                cargaAcoplada = true;
                                // Ignora informações iniciais ao iniciar a carga.

                                if (Tools.VerificarETS2MP() == false)
                                {
                                    ControllerAudio.ExecutarAudio(ControllerAudio.Audios.MP);
                                    Application.Exit();
                                }
                                else
                                {
                                    ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Conectada);
                                    opt.LimparListaDeMultas();
                                    infoIniciais = true;
                                }
                            }
                        }
                    }

                    if (ets2TelemetryData.Navigation.EstimatedDistance == 0 && !ets2TelemetryData.Trailer.Attached)
                    {
                        infoFinais = true;
                        if (infoFinais && flag)
                        {
                            kmRodado = Convert.ToUInt32(ets2TelemetryData.Truck.Odometer - v_OdometroInicial);

                            // Checka o parametro da empresa
                            // Parametrização
                            if (checkParametros(IDEmpresa, "POne"))
                            {
                                // Conversão de Metros para KM
                                double mTOkm = parametroEstimado / (double)1000;
                                if(nomeEmpresa(IDEmpresa) == "Zero Hora")
                                {
                                    //Parametrização GACC
                                    // 100 km a mais 
                                    // kmaMais = mTOkm + 0.1;
                                    kmaMais = mTOkm + mTOkm * 0.5;
                                    if (kmRodado > kmaMais)
                                        kmfinal = kmaMais;
                                    else
                                        kmfinal = kmRodado;
                                }
                                else
                                {
                                    kmfinal = kmRodado;
                                }
                            }
                            else
                                kmfinal = kmRodado;

                            double danoTruck = Math.Floor((double)ets2TelemetryData.Truck.WearCabin * 100.0) 
                                + Math.Floor((double)ets2TelemetryData.Truck.WearChassis * 100.0);
                            danoTruck += Math.Floor((double)ets2TelemetryData.Truck.WearEngine * 100.0)
                                + Math.Floor((double)ets2TelemetryData.Truck.WearTransmission * 100.0);
                            danoTruck += Math.Floor((double)ets2TelemetryData.Truck.WearWheels * 100.0);

                            double danoTrailer = Math.Floor((double)ets2TelemetryData.Trailer.Wear * 100.0);

                            dano = danoTrailer + danoTruck;

                            pontuacao = opt.CalcularPontuacao(dano, opt.ObterNumeroDeMultas(), kmfinal);
                            pontuacao = Math.Round(pontuacao, 1);

                            cargaAcoplada = false;
                            kmFinal = Convert.ToUInt32(kmfinal);

                            FinalizarFrete();
                            //Preenche DataTable 
                        }
                    }
                }
                else
                {
                    //JogoFechado = 1;
                    //PararLogBook();
                }
                whileTS = false;
                TSOpen();
                await Task.Delay(1000);
                await Iniciar(token);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message.ToString(), "e-LogBook");
            }
        }

        private string nomeEmpresa(int idEmpresa)
        {
            DataTable _dt = opt.getSpecificEmpresa(idEmpresa);
            foreach(DataRow dr in _dt.Rows)
            {
                nomeParametroEmpresa = dr["Nome"].ToString();
            }
            return nomeParametroEmpresa;
        }

        private bool checkParametros(int idEmpresa, string campo)
        {
            DataTable _dt = opt.getParametros(idEmpresa, campo);
            if (_dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private bool checkTS(int ts3)
        {
            if (ts3 != 1)
            {
                if (Tools.checkConnection())
                {
                    if (LEmpresa == 1)
                    {
                        if (server != "192.168.0.1")
                        {
                            Process.Start("ts3server://" + server);
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                    {
                        if (server != "192.168.0.1" && port != "2555")
                        {
                            Process.Start("ts3server://" + server + "?port=" + port + "");
                            return true;
                        }
                        else
                            return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }

        private int _result = 2;
        private void TSOpen()
        {
            while (!whileTS)
            {
                foreach (Process myProc in Process.GetProcesses())
                {
                    if (myProc.ProcessName == "ts3client_win64")
                    {
                        _result = 1;
                        break;
                    }
                }

                if (_result == 2)
                {
                    whileTS = checkTS(0);
                    //Thread.Sleep(TimeSpan.FromMinutes(10));
                }
                else
                {
                    whileTS = true;
                }
                //else
                //Thread.Sleep(TimeSpan.FromMinutes(10));
            }
        }
    }
}