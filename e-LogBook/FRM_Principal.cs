﻿using System;
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
using e_LogBook.Model;

namespace e_LogBook
{
    public partial class FRM_Principal : Form
    {
        public FRM_Principal()
        {
            InitializeComponent();
        }

        public string public_login { get; set; }
        private int empresa_id, usuario_id, admin, acmClick = 0, acm = 0;
        private string versao = "BETA";
        private string nomeUsuario, /*dataUsuario, horaUsuario, NomeTabela,*/ _resultado;
        private string serverP, portP;

        //Thread TS3;

        Optional opt = new Optional();
        Defaults drv = new Defaults();
        DriverController drvr = new DriverController();
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
                btnEventos.Visible = false;
            }
            //Salva as cores no settings
            opt.saveSettingsColors(empresa_id);
            changeColors();
            getServerTS();
            preencheDGV();
            //TS3 = new Thread(new ThreadStart(TSOpen));
            //TS3.Start();
            
            //criaTabelaTemporaria();
        }

        /** Antigo 
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
        */
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
            if (MessageBox.Show(null, "Deseja sair do eLogBook?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //deletaTabelaTemporaria();
                
                //TS3.Abort();
                Application.Exit();
            }
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
            log.server = serverP;
            log.port = portP;
            if(log.ShowDialog() == DialogResult.Cancel)
                preencheDGV();
        }

        private void preencheDGV()
        {
            string comandos = "dadosLocais ORDER BY ID DESC";
            DataTable _dt = drv.selectLite("ID, data, cidadeinicial, cidadedestino, carga, kmrodado, status", comandos);
            var _bs = new BindingSource();
            _bs.DataSource = _dt;
            dgvLogBook.DataSource = _bs;
        }

        private void deleteLocalRegistro(int idMotorista)
        {
            string condicao = "ID = " + idMotorista;
            drv.deleteLite("dadosLocais", condicao);
        }

        private void deleteLocalRegistroAll()
        {
            drv.deleteLiteAll("dadosLocais");
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            FRM_Company com = new FRM_Company();
            com.public_login = usuario_id;
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

        private void btnEventos_Click(object sender, EventArgs e)
        {
            if (empresa_id == 1)
            {
                FRM_Eventos even = new FRM_Eventos();
                even.public_login = public_login;
                even.Show();
            }
            else
                MessageBox.Show("Disponivel apenas para administradores da Zero Hora!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDoar_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://pag.ae/bftkbHS");
            Process.Start(sInfo);
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            acm = 0;
            if (MessageBox.Show("Deseja sincronizar os dados?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string comandos = "dadosLocais ORDER BY ID DESC";
                DataTable _dt = drv.selectLite("*", comandos);
                if (_dt.Rows.Count != 0)
                {
                    acmClick = _dt.Rows.Count;
                    foreach (DataRow dr in _dt.Rows)
                    {
                        if (dr["Status"].ToString() != "Enviado")
                        {
                            int idDados = Convert.ToInt32(dr["ID"].ToString());
                            uint kms = Convert.ToUInt32(dr["Kmrodado"].ToString());
                            double danos = Convert.ToDouble(dr["Dano"].ToString());
                            double pontos = Convert.ToDouble(dr["Pontuacao"].ToString());
                            int idMotoristas = Convert.ToInt32(dr["IdMotorista"].ToString());
                            int idEmpresas = Convert.ToInt32(dr["IdEmpresa"].ToString());
                            _resultado = drvr.saveFreight(kms, danos, pontos, dr["Carga"].ToString(), dr["Cidadeinicial"].ToString(), dr["Cidadedestino"].ToString(), dr["Data"].ToString(), idMotoristas, idEmpresas);
                            if (_resultado == "true")
                            {
                                acm = acm + 1;
                                deleteLocalRegistro(idDados);
                            }
                        }
                        else
                        {
                            _resultado = "Enviados";
                            acm = acm + 1;
                        }
                    }
                    if (_resultado == "Enviados")
                    {
                        if (acmClick == acm)
                        {
                            deleteLocalRegistroAll();
                            preencheDGV();
                            MessageBox.Show("Os dados já foram sincronizados!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (_resultado == "true")
                        {
                            preencheDGV();
                            MessageBox.Show("Dados sincronizados com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (_resultado == "rankingFalse")
                            MessageBox.Show("Ocorreu um erro ao tentar atualizar o ranking!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Ocorreu um erro ao tentar sincronizar seus dados!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não há dados para sincronizar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        private void getServerTS()
        {
            DataTable _dt = opt.getTS(empresa_id);

            foreach (DataRow _dr in _dt.Rows)
            {
                serverP = _dr["Servidor"].ToString();
                portP = _dr["Porta"].ToString();
            }
        }

        // Checagem antiga -- Desabilitada
        private bool checkTS(int ts3)
        {
            if (ts3 != 1)
            {
                DataTable _dt = opt.getTS(empresa_id);

                foreach (DataRow _dr in _dt.Rows)
                {
                    serverP = _dr["Servidor"].ToString();
                    portP = _dr["Porta"].ToString();
                }
                if (Tools.checkConnection())
                {
                    if (serverP != "192.168.0.1" && portP != "2555")
                    {
                        Process.Start("ts3server://" + serverP + "?port=" + portP + "");
                        return true;
                    }
                    else
                        return false;
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
