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

/*
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

        //Privadas
        private string cidadeInicial, cidadeDestino, carga, data;
        private String idCarreta = String.Empty;
        private float VelocidadeAtual = 0;
        private double v_OdometroInicial, dano, pontuacao;
        private int IDMotorista, IDEmpresa, ControleVelocidade = 0;
        private uint kmRodado;
        private bool infoIniciais = false, infoFinais = false, cargaAcoplada = false;
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
            Settings.Default.LogBook = false;
            Settings.Default.Save();
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

        private void FRM_LogBook_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            this.Left = Ponto.X + MousePosition.X;
            this.Top = Ponto.Y + MousePosition.Y;
        }

        CancellationTokenSource source = new CancellationTokenSource();
        CancellationToken token;

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            token = source.Token;
            await Iniciar(token);
            //LOGBOOKthread = new Task(new Action (readData));
            //LOGBOOKthread.Start();
        }

        public async Task Iniciar(CancellationToken token)
        {
            LOGBOOKthread = Task.Run(() =>
            {
                readData();
            }, token);
        }

        private void btnParar_Click(object sender, EventArgs e)
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
            lblTitulo.ForeColor = (Color)nome.ConvertFromString(Settings.Default.colorFonte);
            lblSysTitulo.ForeColor = (Color)nome.ConvertFromString(Settings.Default.colorFonte);
        }

        #endregion

        #region ICONES EMPRESA 

        private void SetarIconeDasEmpresas(string p_EmpresaPartida, string p_EmpresaDestino)
        {
            var CaminhoDasImagens = String.Format(@"{0}\Empresas", Application.StartupPath);
            var CaminhoImgPartida = String.Format(@"{0}\{1}.png", CaminhoDasImagens, p_EmpresaPartida.Trim().ToLower());
            var CaminhoImgDestino = String.Format(@"{0}\{1}.png", CaminhoDasImagens, p_EmpresaDestino.Trim().ToLower());

            if (File.Exists(CaminhoImgPartida))
            {
                img_EmpresaPartida.ImageLocation = CaminhoImgPartida;
            }

            if (File.Exists(CaminhoImgDestino))
            {
                img_EmpresaDestino.ImageLocation = CaminhoImgDestino;
            }
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

            Thread.Sleep(1000);

            ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Velocidade);

            Thread.Sleep(1000);
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
                string _resultado = drv.saveFreight(kmRodado, dano, pontuacao, carga, cidadeInicial, cidadeDestino, data, IDMotorista, IDEmpresa);
                if (_resultado == "true")
                {
                    ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Entregue);
                }
                else if (_resultado == "rankingFalse")
                    MessageBox.Show("Ocorreu um erro ao tentar atualizar o ranking!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            lblDestino.Text = "";
            lblPartida.Text = "";
            pontuacao = 0;
            dano = 0;
            VelocidadeAtual = 0;
            ControleVelocidade = 0;
            infoIniciais = false;
            infoFinais = false;
            img_EmpresaDestino.Image = null;
            img_EmpresaPartida.Image = null;
        }

        private async void readData()
        {
            try
            {
                bool gStatus = this.gameStatus();
                bool flag = false;
                IEts2TelemetryData ets2TelemetryData = Ets2TelemetryDataReader.Instance.Read();
                if (ets2TelemetryData.Game.Connected)
                {
                    VelocidadeAtual = ets2TelemetryData.Truck.Speed;

                    if (!string.IsNullOrWhiteSpace(ets2TelemetryData.Job.DestinationCity))
                    {
                        if (ets2TelemetryData.Navigation.EstimatedDistance != 0 && ets2TelemetryData.Trailer.Attached)
                        {
                            flag = true;
                            if (!infoIniciais)
                            {
                                v_OdometroInicial = ets2TelemetryData.Truck.Odometer;
                                idCarreta = ets2TelemetryData.Trailer.Id;
                                cidadeInicial = ets2TelemetryData.Job.SourceCity;
                                cidadeDestino = ets2TelemetryData.Job.DestinationCity;
                                carga = String.Format("{0} {1}t", ets2TelemetryData.Trailer.Name.ToString(), (ets2TelemetryData.Trailer.Mass / 1000f).ToString());
                                lblDestino.Text = cidadeDestino;
                                lblPartida.Text = cidadeInicial;
                                cargaAcoplada = true;

                                SetarIconeDasEmpresas(ets2TelemetryData.Job.SourceCompany, ets2TelemetryData.Job.DestinationCompany);
                                PicCarga.Image = Properties.Resources.Carregado;
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

                        if (ets2TelemetryData.Navigation.EstimatedDistance == 0 && !ets2TelemetryData.Trailer.Attached)
                        {
                            infoFinais = true;
                            if (infoFinais && flag)
                            {
                                kmRodado = Convert.ToUInt32(ets2TelemetryData.Truck.Odometer - v_OdometroInicial);

                                double danoTruck = ets2TelemetryData.Truck.WearCabin + ets2TelemetryData.Truck.WearChassis;
                                danoTruck = danoTruck + ets2TelemetryData.Truck.WearEngine + ets2TelemetryData.Truck.WearTransmission;
                                danoTruck = danoTruck + ets2TelemetryData.Truck.WearWheels;
                                double danoTrailer = ets2TelemetryData.Trailer.Wear;

                                pontuacao = opt.CalcularPontuacao(danoTrailer, opt.ObterNumeroDeMultas(), kmRodado);
                                dano = danoTrailer * 100;
                                pontuacao = Math.Round(pontuacao, 1);
                                PicCarga.Image = Properties.Resources.Descarregado;
                                cargaAcoplada = false;
                                FinalizarFrete();
                            }
                        }

                        //lblVelDis.Text = String.Format("Velocidade {0}", VelocidadeAtual.ToString("0"));
                    }
                }
                await Task.Delay(1000);
                await Iniciar(token);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message.ToString(), "e-LogBook");
            }
        }
    }
}