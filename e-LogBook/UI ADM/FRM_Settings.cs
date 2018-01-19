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
using System.IO;

namespace e_LogBook.UI_ADM
{
    public partial class FRM_Settings : Form
    {
        /* 
         * Projeto e-LogBook
         * Dev: Deivid Farias | Data: 13/12/2017
         * Form FRM_Settings
         * 
         * Formulário de Configurações
         */

        Optional opt = new Optional();
        LoginController dft = new LoginController();
        CompanyController cll = new CompanyController();
        DriverController drv = new DriverController();
        Defaults dfts = new Defaults();

        public FRM_Settings()
        {
            InitializeComponent();
        }

        /*
         * Cores padrões
         * e-LogBook = CornflowerBlue
         * Titulo = SteelBlue
         * Menu = SteelBlue
         * Fontes = ControlLightLight
         */
        public string public_login { get; set; }
        public string public_setting { get; set; }
        private string setting_Id, login, result;
        private int empresa_id, usuario_id;

        private void FRM_Settings_Load(object sender, EventArgs e)
        {
            //Seleciona a tabEmpty
            tabControlConfig.SelectedTab = tabEmpty;

            if (!this.public_setting.Equals(""))
                setting_Id = this.public_setting;

            if (!this.public_login.Equals(""))
                login = this.public_login;

            if (setting_Id == "menu_settings")
            {
                tabControlConfig.SelectedTab = tabManutencao;
                btnCores.Visible = false;
                btnEditar.Visible = false;
                btnEmpresa.Visible = false;
            }
            getInformation(login);
            existsColors = opt.getColors(empresa_id);
            colors(existsColors, empresa_id);
            changeColors(elogbook_color, titulo_color, fontes_color);
        }

        private void getInformation(string login)
        {
            DataTable _dt = dft.getInformation(login);
            foreach (DataRow dr in _dt.Rows)
            {
                empresa_id = Convert.ToInt32(dr["IDEmpresa"]);
                usuario_id = Convert.ToInt32(dr["ID"]);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region tab color
        private string elogbook_color, titulo_color, fontes_color;
        private bool existsColors;

        private void colors(bool exists, int idempresa)
        {
            //Configura as cores padrão
            if (!exists)
            {
                elogbook_color = "CornflowerBlue";
                titulo_color = "SteelBlue";
                fontes_color = "ControlLightLight";
            }
            else
            {
                DataTable _dt = opt.getColorsTable(idempresa);
                foreach (DataRow dr in _dt.Rows)
                {
                    elogbook_color = dr["CorELog"].ToString();
                    titulo_color = dr["CorTitulo"].ToString();
                    fontes_color = dr["CorFonte"].ToString();
                }
            }
        }

        private void changeColors(string ecolor, string tcolor, string fcolor)
        {
            ColorConverter nome = new ColorConverter();
            // Pinta o padrão do formulário
            panelSysTitulo.BackColor = (Color)nome.ConvertFromString(ecolor);
            panelTitulo.BackColor = (Color)nome.ConvertFromString(tcolor);
            panelMenu.BackColor = (Color)nome.ConvertFromString(tcolor);
            lblTitulo.ForeColor = (Color)nome.ConvertFromString(fcolor);
            lblSysTitulo.ForeColor = (Color)nome.ConvertFromString(fcolor);

            // Pinta os quadrados de escolha
            paneleLog.BackColor = (Color)nome.ConvertFromString(ecolor);
            panelTituloC.BackColor = (Color)nome.ConvertFromString(tcolor);
            panelFonte.BackColor = (Color)nome.ConvertFromString(fcolor);
        }

        private void paneleLog_Click(object sender, EventArgs e)
        {
            ColorDialog cor = new ColorDialog();
            cor.ShowHelp = true;
            cor.Color = paneleLog.BackColor;
            if (cor.ShowDialog() == DialogResult.OK)
            {
                paneleLog.BackColor = cor.Color;
                panelSysTitulo.BackColor = cor.Color;
                elogbook_color = ColorTranslator.ToHtml(cor.Color);
            }
        }

        private void panelTituloC_Click(object sender, EventArgs e)
        {
            ColorDialog cor = new ColorDialog();
            cor.ShowHelp = true;
            cor.Color = panelTituloC.BackColor;
            if (cor.ShowDialog() == DialogResult.OK)
            {
                panelTituloC.BackColor = cor.Color;
                panelTitulo.BackColor = cor.Color;
                panelMenu.BackColor = cor.Color;
                titulo_color = ColorTranslator.ToHtml(cor.Color);
            }
        }

        private void panelFonte_Click(object sender, EventArgs e)
        {
            ColorDialog cor = new ColorDialog();
            cor.ShowHelp = true;
            cor.Color = panelFonte.BackColor;
            if (cor.ShowDialog() == DialogResult.OK)
            {
                panelFonte.BackColor = cor.Color;
                lblSysTitulo.ForeColor = cor.Color;
                lblTitulo.ForeColor = cor.Color;
                fontes_color = ColorTranslator.ToHtml(cor.Color);
            }
        }

        private void btnColorSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(null, "Deseja alterar o esquema de cores?", "Cores", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (existsColors)
                    result = opt.updateColors(elogbook_color, titulo_color, fontes_color, empresa_id);
                else
                    result = opt.saveColors(elogbook_color, titulo_color, fontes_color, empresa_id);
                if (result == "true")
                    MessageBox.Show(null, "Registro salvo com sucesso", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(null, "Registro não foi salvo com sucesso, informe o administrador!  \n Código do Erro: " + result, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                changeColors(elogbook_color, titulo_color, fontes_color);

        }

        #endregion

        #region Seleciona as Tabs
        private void btnCores_Click(object sender, EventArgs e)
        {
            tabControlConfig.SelectedTab = tabColor;
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            if (empresa_id == 1)
            {
                preencheDGVEmpresa();
                preencheComboTabEmpresa();
                tabControlConfig.SelectedTab = tabEmpresa;
            }
            else
                MessageBox.Show("Dados disponiveis somente ao administrativo da Zero Hora", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            preencheCombos();
            tabControlConfig.SelectedTab = tabOthers;
        }

        private void btnManutencao_Click(object sender, EventArgs e)
        {
            tabControlConfig.SelectedTab = tabManutencao;
        }

        

        #endregion

        #region tab manutenção

        private void btnValida_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tools.VerificarPastaETS())//Verfica se a pasta do ETS esta padrão
                {
                    Tools.Copiar($@"{Application.StartupPath}\Plugins\", Tools.DiretorioPadraoETS);

                    MessageBox.Show("Os plugins foram instalads com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível encontrar o diretório do Eurotruck 2 automaticamente. Por favor indique o direório do seu jogo para que os plugins possam ser instalados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (folderBrowserDialogets.ShowDialog() == DialogResult.OK)
                    {
                        Tools.Copiar($@"{Application.StartupPath}\Plugins\", folderBrowserDialogets.SelectedPath);

                        MessageBox.Show("Os plugins foram instalads com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (MessageBox.Show("Continua com problemas no APP? Instale o Visual C++.", "Visual C++", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.microsoft.com/en-gb/download/details.aspx?id=48145");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Não foi possível efetuar a instalação dos plugins! Execute o software como administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region tab empresa

        private void btnSalvarEmpresa_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtResp.Text != "" && txtSlots.Text != "")
            {
                int limite = Convert.ToInt32(txtSlots.Text);
                string _result = cll.saveCompany(txtNome.Text, txtResp.Text, limite);
                if (_result == "true")
                    MessageBox.Show(null, "Dados inseridos com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(null, "Dados não inseridos com sucesso, contate o administrador!  \n Código do Erro: " + _result, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show(null, "Insira os dados antes de continuar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            preencheDGVEmpresa();
        }

        private void btnTSServer_Click(object sender, EventArgs e)
        {
            if(txtServidor.Text != "" && txtPorta.Text != "")
            {
                string _result = opt.saveTS(empresa_id, txtServidor.Text, txtPorta.Text);
                if(_result == "true")
                    MessageBox.Show(null, "Dados atualizados com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(null, "Dados não atualizados com sucesso, contate o administrador!  \n Código do Erro: " + _result, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(null, "Insira os dados antes de continuar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCriarEvento_Click(object sender, EventArgs e)
        {
            FRM_Eventos even = new FRM_Eventos();
            even.ShowDialog();
        }

        private void dgvEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Deseja alterar a quantidade de slots?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Prompt = "Informe a quantidade de Slots";
                string Titulo = "Alerta";
                string Resultado = Microsoft.VisualBasic.Interaction.InputBox(Prompt, Titulo, "0", 500, 300);
                if (Resultado != "")
                {
                    DataGridViewRow linhaSelecionada = dgvEmpresa.CurrentRow;
                    int empresaSlots = Convert.ToInt32(linhaSelecionada.Cells["id"].Value.ToString());
                    string result = dfts.Update("Empresa", "LimiteUsers = " + Resultado, "ID = " + empresaSlots);
                    if(result == "true")
                        MessageBox.Show("Slots atualizados com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro: "+result+"!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Informe a quantidade de slots!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            preencheDGVEmpresa();
        }

        private void btnMADM_Click(object sender, EventArgs e)
        {
            int selectMADM = Convert.ToInt32(cboMADM.SelectedValue);
            string resultADM = drv.setADM(selectMADM, 0);
            if(resultADM == "true")
                MessageBox.Show("Admin atribuidos com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro: "+resultADM, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDADM_Click(object sender, EventArgs e)
        {
            int selectMADM = Convert.ToInt32(cboMADM.SelectedValue);
            string resultADM = drv.setADM(selectMADM, 1);
            if (resultADM == "true")
                MessageBox.Show("Admin removido com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro: " + resultADM, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void preencheDGVEmpresa()
        {
            dgvEmpresa.DataSource = "";
            DataTable _dt = new DataTable();
            _dt = cll.infoEmpresa(0);
            var _bs = new BindingSource();
            _bs.DataSource = _dt;
            dgvEmpresa.DataSource = _bs;
        }

        #endregion 

        #region outras configs
        private void btnZerar_Click(object sender, EventArgs e)
        {
            if (cboRanking.SelectedIndex != -1)
            {
                string valorCombo = cboRanking.SelectedItem.ToString();
                string _result = opt.zerarRanking(valorCombo);
                if (_result == "true")
                    MessageBox.Show(null, "Dados zerados com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(null, "Os dados não foram zerados com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show(null, "Selecione os dados antes de continuar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void preencheCombos()
        {
            DataTable _dt = new DataTable();
            _dt = drv.getInformationMotoristas(empresa_id);
            DataRow _row = _dt.NewRow();
            _row["Nome"] = "";

            cboANCMotoristas.DataSource = _dt;
            cboANCMotoristas.ValueMember = "ID";
            cboANCMotoristas.DisplayMember = "Nome";

            DataTable _dt2 = new DataTable();
            _dt2 = drv.getInformationMotoristas(empresa_id);
            DataRow _row2 = _dt2.NewRow();
            _row2["Nome"] = "";

            cboRSMotorista.DataSource = _dt2;
            cboRSMotorista.ValueMember = "ID";
            cboRSMotorista.DisplayMember = "Nome";
        }

        public void preencheComboTabEmpresa()
        {
            DataTable _dt4 = new DataTable();
            _dt4 = drv.getAllMotoristas();
            DataRow _row4 = _dt4.NewRow();
            _row4["Nome"] = "";

            cboMADM.DataSource = _dt4;
            cboMADM.ValueMember = "ID";
            cboMADM.DisplayMember = "Nome";
        }

        private void btnSalvarNumero_Click(object sender, EventArgs e)
        {
            int Numero = Convert.ToInt32(txtNumeroCaminhao.Text);
            int IDM = Convert.ToInt32(cboANCMotoristas.SelectedValue);

            string _result = drv.saveNumber(Numero, IDM);
            if(_result == "true")
                MessageBox.Show(null, "Número do caminhão alterado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(null, "O Número do caminhão não foi alterado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnResetarSenha_Click(object sender, EventArgs e)
        {
            int IDM = Convert.ToInt32(cboRSMotorista.SelectedValue);
            string _senhaPadrao = "ELOGBOOK";
            _senhaPadrao = Tools.getMD5Hash(_senhaPadrao);

            string _result = drv.resetPassDefault(_senhaPadrao, IDM);
            if (_result == "true")
                MessageBox.Show(null, "A senha foi redefinida com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(null, "A senha não foi redefinida com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        #endregion 
    }
}
