using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_LogBook.Controller;
using e_LogBook.Properties;

namespace e_LogBook.UI_USER.Driver
{
    public partial class FRM_DriverAccount : Form
    {
        Optional opt = new Optional();
        DriverController dft = new DriverController();

        public int public_login { get; set; }
        string nome, senha, numero, _resultSalvar;
        int status, idusuario, validaSenhaAtual, validaSenhaNova;
        DateTime datacad;


        public FRM_DriverAccount()
        {
            InitializeComponent();
        }

        private void btnTabFretes_Click(object sender, EventArgs e)
        {
            tabControlDriver.SelectedTab = tabFretes;
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            tabControlDriver.SelectedTab = tabAccount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenhaNova_Leave(object sender, EventArgs e)
        {
            if (txtSenhaAtual.Text != "")
            {
                if (txtSenhaNova.Text == txtSenhaAtual.Text)
                {
                    lblErro.Text = "A nova senha não pode ser igual a atual!";
                    lblErro.Visible = true;
                    btnSalvar.Enabled = false;
                }
                else
                {
                    btnSalvar.Enabled = true;
                    lblErro.Visible = false;
                }
                progressNivel.Value = 0;
                int placar = opt.GetForcaDaSenha(txtSenhaNova.Text);
                switch (placar)
                {
                    case 0:
                        progressNivel.Value = 2;
                        break;
                    case 1:
                        progressNivel.Value = 10;
                        break;
                    case 2:
                        progressNivel.Value = 40;
                        break;
                    case 3:
                        progressNivel.Value = 70;
                        break;
                    case 4:
                        progressNivel.Value = 100;
                        break;
                }
                lblErro.Visible = false;
            }
            else
            {
                lblErro.Text = "A nova senha e confirmação não conferem!";
                lblErro.Visible = true;
            }
        }

        private void txtCSenhaNova_Leave(object sender, EventArgs e)
        {
            if (txtSenhaNova.Text != txtCSenhaNova.Text)
            {
                lblErro.Text = "A nova senha e confirmação não conferem!";
                lblErro.Visible = true;
                btnSalvar.Enabled = false;
                validaSenhaNova = 0;
            }
            else
            {
                btnSalvar.Enabled = true;
                lblErro.Visible = false;
                validaSenhaNova = 1;
            }
        }

        private void checkViewer_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkViewer.Checked)
            {
                txtSenhaAtual.UseSystemPasswordChar = true;
                txtCSenhaNova.UseSystemPasswordChar = true;
                txtSenhaNova.UseSystemPasswordChar = true;
            }
            else
            {
                txtSenhaAtual.UseSystemPasswordChar = false;
                txtCSenhaNova.UseSystemPasswordChar = false;
                txtSenhaNova.UseSystemPasswordChar = false;
            }
        }

        private void FRM_DriverAccount_Load(object sender, EventArgs e)
        {
            if (!this.public_login.Equals(""))
                getInformation(public_login);

            fillGrid(public_login, 15);
            getPoints(public_login);
            changeColors();
        }

        private void getInformation(int id)
        {
            DataTable _dt = dft.getInformation(id);
            foreach (DataRow dr in _dt.Rows)
            {
                nome = dr["Nome"].ToString();
                status = Convert.ToInt32(dr["Status"]);
                idusuario = Convert.ToInt32(dr["ID"]);
                senha = dr["Senha"].ToString();
                datacad = Convert.ToDateTime(dr["DataCadastro"]);
                numero = dr["NumeroCaminhao"].ToString();
            }
            //Mostra as Informações na Tela
            txtNome.Text = nome;
            lblShowData.Text = datacad.ToShortDateString().ToString();
            if (status == 1)
                lblShowStatus.Text = "Ativo";
            else
                lblShowStatus.Text = "Inativo";
            lblNumeroCaminhao.Text = numero;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            fillGrid(public_login, 0);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(validaSenhaAtual == 1)
            {
                if(txtCSenhaNova.Text != "" && txtSenhaNova.Text != "")
                {
                    if (validaSenhaNova == 1)
                    {
                        //Rotina de Salvamento Senha Nova
                        string senhafinal = Tools.getMD5Hash(txtCSenhaNova.Text);
                        _resultSalvar = dft.updateDados(txtNome.Text, senhafinal, idusuario);
                    }
                    else
                        _resultSalvar = "false";
                }
                else
                {
                    //Rotina de Salvamento de Outras Informações
                    string senhafinal = "Sem";
                    _resultSalvar = dft.updateDados(txtNome.Text, senhafinal, idusuario);
                }
                if (_resultSalvar != "true")
                    MessageBox.Show(null, "Os dados não foram atualizados com sucesso, contate o administrador!  \n Código do Erro: " + _resultSalvar, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    getInformation(idusuario);
                    MessageBox.Show(null, "Os dados foram atualizados com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(null, "Informe a Senha Atual para salvar os dados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            fillGrid(public_login, 15);
            getPoints(public_login);
        }

        private void txtSenhaAtual_Leave(object sender, EventArgs e)
        {
            string senhaAtual = Tools.getMD5Hash(txtSenhaAtual.Text);
            if (senhaAtual != senha)
            {
                lblErro.Text = "Senha atual não confere";
                lblErro.Visible = true;
                txtCSenhaNova.Enabled = false;
                txtSenhaNova.Enabled = false;
                btnSalvar.Enabled = false;
                validaSenhaAtual = 0;
            }
            else
            {
                lblErro.Visible = false;
                txtCSenhaNova.Enabled = true;
                txtSenhaNova.Enabled = true;
                btnSalvar.Enabled = true;
                validaSenhaAtual = 1;
            }
        }

        private void fillGrid(int id, int registros)
        {
            DataTable _dt = new DataTable();
            if (registros == 0)
                _dt = dft.getFreights(id, 0);
            else
                _dt = dft.getFreights(id, registros);
            var _bs = new BindingSource();
            _bs.DataSource = _dt;
            dgvFretes.DataSource = _bs;
        }

        private void getPoints(int id)
        {
            int mes = Convert.ToInt32(DateTime.Now.Month);
            int ano = Convert.ToInt32(DateTime.Now.Year);
            DataTable _dt = new DataTable();
            _dt = dft.getFreightsCount(id, mes, ano);
            foreach (DataRow dr in _dt.Rows)
            {
                lblCountFretes.Text = dr["CFretes"].ToString();
                lblPontosMes.Text = dr["PontosMes"].ToString();
                lblPontosAno.Text = dr["PontosAno"].ToString();
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
