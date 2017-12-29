using e_LogBook.Properties;
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

namespace e_LogBook.UI_ADM.Drivers
{
    public partial class FRM_DriverDetails : Form
    {
        /* 
         * Projeto e-LogBook
         * Dev: Deivid Farias | Data: 13/12/2017
         * Form FRM_DriverDetails
         * 
         * Formulário de Controle de Motoristas Detalhes.
         */
        CompanyController cll = new CompanyController();
        DriverController dft = new DriverController();

        public int public_id_motorista;
        private int idMotorista, id_empresa, statusINT;
        private string status;

        public FRM_DriverDetails()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cbosSelect();
            string _result = dft.saveDriverDetails(statusINT, id_empresa, idMotorista);
            if (_result != "true")
                MessageBox.Show(null, "Os dados não foram atualizados com sucesso, contate o administrador! \n Código do Erro: "+_result, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show(null, "Os dados foram atualizados com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbosSelect()
        {
            int statusS = cboStatus.SelectedIndex;
            if (statusS == 1)
                statusINT = 0;
            else
                statusINT = 1;

            int empresaS = Convert.ToInt32(cboEmpresa.SelectedValue);
            if (empresaS != 0)
                id_empresa = Convert.ToInt32(cboEmpresa.SelectedValue);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            fillGrid(idMotorista);
            infoMotorista(idMotorista);
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

        private void FRM_DriverDetails_Load(object sender, EventArgs e)
        {
            changeColors();

            if (!this.public_id_motorista.Equals(""))
                idMotorista = public_id_motorista;

            infoMotorista(idMotorista);
            infoMotoristaSpecific(idMotorista);
            comboEmpresa();
            statusCombo();
            fillGrid(idMotorista);
        }

        private void comboEmpresa()
        {
            DataTable _dt = new DataTable();
            _dt = cll.infoEmpresa(0);
            DataRow _row = _dt.NewRow();
            _row["Nome"] = "";

            cboEmpresa.DataSource = _dt;
            cboEmpresa.ValueMember = "ID";
            cboEmpresa.DisplayMember = "Nome";

            cboEmpresa.SelectedValue = id_empresa;
        }

        private void fillGrid(int id)
        {
            dgvFretes.DataSource = "";
            DataTable _dt = new DataTable();
            _dt = dft.getFreights(id,0);
            var _bs = new BindingSource();
            _bs.DataSource = _dt;
            dgvFretes.DataSource = _bs;
        }

        private void infoMotorista(int id)
        {
            DataTable _dt = new DataTable();
            _dt = dft.getFreightsCount(id);
            foreach(DataRow _dr in _dt.Rows)
            {
                lblPontosAno.Text = _dr["PontosAno"].ToString();
                lblPontosMes.Text = _dr["PontosMes"].ToString();
                lblCountFretes.Text = _dr["CFretes"].ToString();
            }
        }

        private void infoMotoristaSpecific(int id)
        {
            DataTable _dt = new DataTable();
            _dt = dft.getInformationSpecific(id);
            foreach (DataRow _dr in _dt.Rows)
            {
                lblNomeMotorista.Text = _dr["Nome"].ToString();
                id_empresa = Convert.ToInt32(_dr["IdEmpresa"].ToString());
                status = _dr["Status"].ToString();
                lblNumeroCaminhao.Text = _dr["NumeroCaminhao"].ToString();
            }
        }

        private void statusCombo()
        {
            if (status == "Inativo")
                cboStatus.SelectedIndex = cboStatus.FindStringExact("Inativo");
            else
                cboStatus.SelectedIndex = cboStatus.FindStringExact("Ativo");
        }
    }
}
