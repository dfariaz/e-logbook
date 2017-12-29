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
    public partial class FRM_DriverControl : Form
    {
        /* 
         * Projeto e-LogBook
         * Dev: Deivid Farias | Data: 13/12/2017
         * Form FRM_DriverControl
         * 
         * Formulário de Controle de Motoristas.
         */

        DriverController drv = new DriverController();

        public int public_empresa;
        private int empresaID;

        public FRM_DriverControl()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            int numeroSelecionado = getIDDGV();
            FRM_DriverDetails det = new FRM_DriverDetails();
            det.public_id_motorista = numeroSelecionado;
            det.ShowDialog();
        }

        #region CORES

        private void changeColors()
        {
            ColorConverter nome = new ColorConverter();
            // Pinta o padrão do formulário
            panelSysTitulo.BackColor = (Color)nome.ConvertFromString(Settings.Default.colorEBook);
            panelTitulo.BackColor = (Color)nome.ConvertFromString(Settings.Default.colorTitulo);
            panelMenu.BackColor = (Color)nome.ConvertFromString(Settings.Default.colorTitulo);
            lblTitulo.ForeColor = (Color)nome.ConvertFromString(Settings.Default.colorFonte);
            lblSysTitulo.ForeColor = (Color)nome.ConvertFromString(Settings.Default.colorFonte);
        }

        #endregion

        private void FRM_DriverControl_Load(object sender, EventArgs e)
        {
            if (!this.public_empresa.Equals(""))
                empresaID = public_empresa;
            changeColors();
            preencheDGV();
        }

        private void preencheDGV()
        {
            DataTable _dt = new DataTable();
            _dt = drv.getInformationMotoristas(empresaID);
            var _bs = new BindingSource();
            _bs.DataSource = _dt;
            dgvMotoristas.DataSource = _bs;
        }

        private int getIDDGV()
        {
            DataGridViewRow linhaSelecionada = dgvMotoristas.CurrentRow;
            return Convert.ToInt32(linhaSelecionada.Cells["ID"].Value.ToString());
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            preencheDGV();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
