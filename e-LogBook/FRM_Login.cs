using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_LogBook.Controller;
using e_LogBook.Properties;
using AutoUpdaterDotNET;
using System.Threading;

namespace e_LogBook
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
            // Verifica Atualizações
            checkUpdates();
        }

        Optional opt = new Optional();
        LoginController lgn = new LoginController();
        string checkState;

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            if (!getSettings())
                txtLogin.Focus();
            else
                txtSenha.Focus();
            // Pega a versão
            lblVersao.Text = "" + Application.ProductVersion + " BETA";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void randomIMG()
        {
            var randon = new Random();
            var img = randon.Next(1, 5);
            switch (img)
            {
                case 1:
                    panelLogin.BackgroundImage = Properties.Resources._1;
                    break;
                case 2:
                    panelLogin.BackgroundImage = Properties.Resources._2;
                    break;
                case 3:
                    panelLogin.BackgroundImage = Properties.Resources._3;
                    break;
                case 4:
                    panelLogin.BackgroundImage = Properties.Resources._4;
                    break;
                case 5:
                    panelLogin.BackgroundImage = Properties.Resources._5;
                    break;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        public void LogIn()
        {
            if (!String.IsNullOrWhiteSpace(txtLogin.Text) && !String.IsNullOrWhiteSpace(txtSenha.Text))
            {
                if (checkLembrar.Checked)
                    checkState = "1";
                else
                    checkState = "0";
                int resultado = lgn.loginValidate(txtLogin.Text, txtSenha.Text, checkState);
                switch (resultado)
                {
                    case 0:
                        MessageBox.Show("Sua conta foi desativada por inatividade! Entre em contato com um Administrador", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        callFRM_Principal(txtLogin.Text);
                        break;
                    case 2:
                        MessageBox.Show("Login ou senha inválidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            else
                MessageBox.Show("Insira seu login e senha!", "Alterta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void callFRM_Principal(string login)
        {
            FRM_Principal fp = new FRM_Principal();
            fp.public_login = login;
            fp.Show();
            this.Hide();
        }

        private void checkUpdates()
        {
            try
            {
                AutoUpdater.ShowSkipButton = false;
                AutoUpdater.ShowRemindLaterButton = false;
                AutoUpdater.Start("http://zerohoravirtual.com/updates/autoupdate.xml");
                AutoUpdater.ApplicationExitEvent += AutoUpdater_ApplicationExitEvent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HResult.ToString(), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutoUpdater_ApplicationExitEvent()
        {
            Text = @"Closing application...";
            Thread.Sleep(5000);
            Application.Exit();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                LogIn();
        }

        private bool getSettings()
        {
            string ulogin = Settings.Default.uLogin;
            string usenha = Settings.Default.uPass;
            string uCheck = Settings.Default.uCheck;
            if (uCheck != "0")
                checkLembrar.Checked = true;
            if (ulogin != "0" && usenha != "0")
            {
                txtLogin.Text = ulogin;
                txtSenha.Text = usenha;
                return true;
            }
            else
                return false;
        }
    }
}


/*
 * Código para minimizar algo
 * private const int SW_HIDE = 0;
        private const int SW_RESTORE = 9;
        private int hWnd;
        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        String ts3 = "0";
 * 
 * 
 * foreach (Process myProc in Process.GetProcesses())
            {
                if (myProc.ProcessName == "ts3client_win64")
                {
                    ts3 = "1";
                    break;
                }
            }
            if(ts3 == "1")
                MinimizeWindow();
            else
            {
                System.Diagnostics.Process.Start("ts3server://"+server+"?port="+port+"");
                MinimizeWindow();
            }
            ts3 = "0";
 * 
 * public void MinimizeWindow()
        {
            Process[] p = Process.GetProcessesByName("excel");
            hWnd = (int)p[0].MainWindowHandle;
            ShowWindow(hWnd, SW_RESTORE);
        }
 * 
 */
