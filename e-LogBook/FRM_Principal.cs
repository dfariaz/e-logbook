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
        private string nomeUsuario, dataUsuario, horaUsuario, NomeTabela;
        Thread TS3;

        Optional opt = new Optional();
        Defaults drv = new Defaults();
        LoginController dft = new LoginController();

        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            if (versao != "BETA")
                lblVERSAOBETA.Visible = false;
            else
            {
                lblVERSAOBETA.Text = "VERSÃO BETA: " + Application.ProductVersion;
                lblVERSAOBETA.Visible = true;
            }

            if (!this.public_login.Equals(""))
                getInformation(public_login);
            if (admin == 1)
            {
                lblAdmin.Visible = true;
            }
            else
            {
                btnControle.Visible = false;
                btnConfiguracoes.Visible = false;
                lblAdmin.Visible = false;
            }
            //Salva as cores no settings
            opt.saveSettingsColors(empresa_id);
            changeColors();

            TS3 = new Thread(new ThreadStart(TSOpen));
            TS3.Start();
            criaTabelaTemporaria();
        }

        private void criaTabelaTemporaria()
        {
            dataUsuario = DateTime.Now.Day.ToString()+DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            horaUsuario = DateTime.Now.Hour.ToString()+ DateTime.Now.Minute.ToString();
            NomeTabela = "" + nomeUsuario + "" + dataUsuario + "" + horaUsuario+"TEMPORARY";
            Settings.Default.tabelaTemporary = NomeTabela;
            Settings.Default.Save();
            string _result = drv.createTable(NomeTabela);
        }

        private void deletaTabelaTemporaria()
        {
            string _result = drv.deleteTable(NomeTabela);
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
            deletaTabelaTemporaria();
            TS3.Abort();
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FRM_DriverAccount drv = new FRM_DriverAccount();
            drv.public_login = usuario_id;
            drv.Show();
        }

        private void btnLogBook_Click(object sender, EventArgs e)
        {
            FRM_LogBook log = new FRM_LogBook();
            log.LMotorista = usuario_id;
            log.LEmpresa = empresa_id;
            if(log.ShowDialog() == DialogResult.Cancel)
            {
                string comandos = "" + NomeTabela + " ORDER BY ID DESC";
                DataTable _dt = drv.select("*", comandos);
                var _bs = new BindingSource();
                _bs.DataSource = _dt;
                dgvLogBook.DataSource = _bs;
            }
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            FRM_Company com = new FRM_Company();
            com.Show();
        }

        private void btnControle_Click(object sender, EventArgs e)
        {
            FRM_DriverControl drv = new FRM_DriverControl();
            drv.public_empresa = empresa_id;
            drv.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Settings stt = new FRM_Settings();
            stt.public_setting = "";
            stt.public_login = public_login;
            stt.ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            string id = "menu_settings";
            FRM_Settings stt = new FRM_Settings();
            stt.public_setting = id;
            stt.public_login = public_login;
            stt.ShowDialog();
        }

        private void getInformation(string login)
        {
            DataTable _dt = dft.getInformation(login);
            foreach (DataRow dr in _dt.Rows)
            {
                empresa_id = Convert.ToInt32(dr["IDEmpresa"]);
                usuario_id = Convert.ToInt32(dr["ID"]);
                nomeUsuario = dr["Login"].ToString();
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
            panelMenu.BackColor = (Color)nome.ConvertFromString(Settings.Default.colorTitulo);
        }

        #endregion
    }
}
