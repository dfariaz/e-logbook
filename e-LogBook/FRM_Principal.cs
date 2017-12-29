using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_LogBook.UI_ADM;
using e_LogBook.UI_ADM.Drivers;
using e_LogBook.UI_USER.Company;
using e_LogBook.UI_USER.Driver;
using e_LogBook.UI_USER.LogBook;
using e_LogBook.Controller;
using e_LogBook.Properties;
using System.Diagnostics;
using System.Threading;

namespace e_LogBook
{
    public partial class FRM_Principal : Form
    {
        public FRM_Principal()
        {
            InitializeComponent();
        }

        public string public_login { get; set; }
        private int empresa_id, usuario_id, admin, acmClick = 0;
        private string versao = "BETA";
        Thread TS3;

        Optional opt = new Optional();
        LoginController dft = new LoginController();

        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            if (versao != "BETA")
                lblVERSAOBETA.Visible = false;
            else
                lblVERSAOBETA.Visible = true;

            if (!this.public_login.Equals(""))
                getInformation(public_login);
            if (admin == 1)
            {
                btnAdm.Visible = true;
                lblAdmin.Visible = true;
            }
            else
                lblAdmin.Visible = false;
            //Salva as cores no settings
            opt.saveSettingsColors(empresa_id);
            changeColors();

            TS3 = new Thread(new ThreadStart(TSOpen));
            TS3.Start();
        }

        #region MOVE FORM
        Point Ponto = new Point();

        private void FRM_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            Ponto.X = this.Left - MousePosition.X;
            Ponto.Y = this.Top - MousePosition.Y;
        }

        private void FRM_Principal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            this.Left = Ponto.X + MousePosition.X;
            this.Top = Ponto.Y + MousePosition.Y;
        }

        #endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            TS3.Abort();
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            if (admin == 1)
            {
                if (acmClick == 0)
                {
                    listaDados.Visible = true;
                    acmClick = 1;
                }
                else
                {
                    listaDados.Visible = false;
                    acmClick = 0;
                }
            }
            else
                MessageBox.Show(null, "Somente administradores tem acesso a esta opção!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            string id = "menu_settings";
            FRM_Settings stt = new FRM_Settings();
            stt.public_setting = id;
            stt.public_login = public_login;
            stt.ShowDialog();
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            FRM_DriverAccount drv = new FRM_DriverAccount();
            drv.public_login = usuario_id;
            drv.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FRM_Company com = new FRM_Company();
            com.Show();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Settings.Default.cargaEntregue = false;
            Settings.Default.LogBook = true;
            Settings.Default.Save();
            //bool close = Settings.Default.LogBook;
            FRM_LogBook log = new FRM_LogBook();
            log.LMotorista = usuario_id;
            log.LEmpresa = empresa_id;
            log.ShowDialog();
            //close = Settings.Default.LogBook;
            //if (close)
            //{
            //    timerLogBook.Interval = 45000;
            //    timerLogBook.Start();
            //}
        }

        private void timerLogBook_Tick(object sender, EventArgs e)
        {
            Settings.Default.LogBook = true;
            timerLogBook.Stop();
            btnLog.PerformClick();
        }

        private void listaDados_Click(object sender, EventArgs e)
        {
            string listaSelec = listaDados.SelectedItem.ToString();
            if(listaSelec != "Configurações")
            {
                FRM_DriverControl drv = new FRM_DriverControl();
                drv.public_empresa = empresa_id;
                drv.ShowDialog();
            }
            else
            {
                FRM_Settings stt = new FRM_Settings();
                stt.public_setting = "";
                stt.public_login = public_login;
                stt.ShowDialog();
            }
        }

        private void getInformation(string login)
        {
            DataTable _dt = dft.getInformation(login);
            foreach (DataRow dr in _dt.Rows)
            {
                empresa_id = Convert.ToInt32(dr["IDEmpresa"]);
                usuario_id = Convert.ToInt32(dr["ID"]);
                admin = Convert.ToInt32(dr["Grupo"]);
                lblNomeMotorista.Text = dr["Nome"].ToString() + "!";
            }
        }

        private string server;
        private string port;
        private bool checkTS(int ts3)
        {
            if (ts3 != 1)
            {
                DataTable _dt = opt.getTS(empresa_id);

                foreach (DataRow _dr in _dt.Rows)
                {
                    server = _dr["Servidor"].ToString();
                    port = _dr["Porta"].ToString();
                }
                if (server != "192.168.0.1" && port != "2555")
                {
                    Process.Start("ts3server://" + server + "?port=" + port + "");
                    return true;
                }
                else                
                    return false;
            }
            else
                return false;
        }

        private int _result = 2;
        private void TSOpen()
        {
            while (true)
            {
                foreach (Process myProc in Process.GetProcesses())
                {
                    if (myProc.ProcessName == "ts3client_win64")
                    {
                        _result = 1;
                        break;
                    }
                }

                if(_result == 2)
                {
                    checkTS(0);
                    Thread.Sleep(TimeSpan.FromMinutes(10));
                }
                else
                    Thread.Sleep(TimeSpan.FromMinutes(10));
            }
        }


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
    }
}
