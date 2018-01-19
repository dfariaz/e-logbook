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

namespace e_LogBook.UI_USER.Company
{
    public partial class FRM_Company : Form
    {
        CompanyController ccl = new CompanyController();
        public int public_login { get; set; }
        private int idLogin;
        public FRM_Company()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillCombo()
        {
            DataTable _dt = new DataTable();
            _dt = ccl.infoEmpresa(0);
            DataRow _row = _dt.NewRow();
            _row["Nome"] = "";

            cboEmpresa.DataSource = _dt;
            cboEmpresa.ValueMember = "ID";
            cboEmpresa.DisplayMember = "Nome";
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

        private void FRM_Company_Load(object sender, EventArgs e)
        {
            if (!this.public_login.Equals(""))
                idLogin = public_login;
            changeColors();
            fillCombo();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            limpa();
            int combo = Convert.ToInt16(cboEmpresa.SelectedValue.ToString());
            preencheInfo(combo);
            preencheMotoristaKM(combo, idLogin);
            preencheEmpresaKM(combo);
            showCampos();
        }

        private void limpa()
        {
            lblAnoEmpresa.Text = "";
            lblAnoMotorista.Text = "";
            lblMensalMotorista.Text = "";
            lblMesEmpresa.Text = "";
            lblNomeEmpresa.Text = "";
            lblQTDMotoristas.Text = "";
        }

        private void showCampos()
        {
            lblAnoEmpresa.Visible = true;
            lblAnoMotorista.Visible = true;
            lblMensalMotorista.Visible = true;
            lblMesEmpresa.Visible = true;
            lblNomeEmpresa.Visible = true;
            lblQTDMotoristas.Visible = true;
        }

        private void preencheEmpresaKM(int combo)
        {
            int mes = Convert.ToInt32(DateTime.Now.Month);
            int ano = Convert.ToInt32(DateTime.Now.Year);
            DataTable _dtM = new DataTable();
            _dtM = ccl.KMEmpresaMes(combo, mes, ano);
            foreach (DataRow _dr in _dtM.Rows)
            {
                lblMesEmpresa.Text = _dr["KMMes"].ToString();
            }

            DataTable _dtA = new DataTable();
            _dtA = ccl.KMEmpresaAno(combo, ano);
            foreach (DataRow _dr in _dtA.Rows)
            {
                lblAnoEmpresa.Text = _dr["KMAno"].ToString();
            }
        }

        private void preencheInfo(int combo)
        {
            DataTable _dt = new DataTable();
            _dt = ccl.infoEmpresa(combo);
            foreach (DataRow _dr in _dt.Rows)
            {
                lblNomeEmpresa.Text = _dr["Nome"].ToString();
                lblQTDMotoristas.Text = _dr["Motoristas"].ToString();
            }
        }

        private void preencheMotoristaKM(int combo, int id)
        {
            int mes = Convert.ToInt32(DateTime.Now.Month);
            int ano = Convert.ToInt32(DateTime.Now.Year);
            DataTable _dtM = new DataTable();
            _dtM = ccl.KMMotoristaMesC(id, mes, ano, combo);
            foreach (DataRow _dr in _dtM.Rows)
            {
                lblMensalMotorista.Text = _dr["KMMes"].ToString();
            }

            DataTable _dtA = new DataTable();
            _dtA = ccl.KMMotoristaAnoC(id, ano, combo);
            foreach (DataRow _dr in _dtA.Rows)
            {
                lblAnoMotorista.Text = _dr["KMAno"].ToString();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
