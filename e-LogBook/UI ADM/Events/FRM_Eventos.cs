using e_LogBook.Controller;
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

namespace e_LogBook.UI_ADM
{
    public partial class FRM_Eventos : Form
    {

        LoginController dft = new LoginController();
        Defaults dfts = new Defaults();
        public string public_login { get; set; }
        private int empresa_id;
        public FRM_Eventos()
        {
            InitializeComponent();
        }

        private void btnCriarEvento_Click(object sender, EventArgs e)
        {
            FRM_EventosNew even = new FRM_EventosNew();
            even.public_empresas = empresa_id;
            even.public_id_evento = 0;
            if(even.ShowDialog() == DialogResult.Cancel)
            {
                preencheDGV();
            }
        }

        private void FRM_Eventos_Load(object sender, EventArgs e)
        {
            if (!this.public_login.Equals(""))
                getInformation(this.public_login);
            preencheDGV();
            changeColors();
        }

        private int getIDDGV()
        {
            DataGridViewRow linhaSelecionada = dgvEventos.CurrentRow;
            return Convert.ToInt32(linhaSelecionada.Cells["idEvento"].Value.ToString());
        }

        private void getInformation(string login)
        {
            DataTable _dt = dft.getInformation(login);
            foreach (DataRow dr in _dt.Rows)
            {
                empresa_id = Convert.ToInt32(dr["IDEmpresa"]);
            }
        }

        private void btnEditarEvento_Click(object sender, EventArgs e)
        {
            int idEventoDGV = getIDDGV();
            FRM_EventosNew even = new FRM_EventosNew();
            even.public_empresas = empresa_id;
            even.public_id_evento = idEventoDGV;
            if (even.ShowDialog() == DialogResult.Cancel)
            {
                preencheDGV();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preencheDGV()
        {
            string comandos = "e.ID as idEvento, e.Nome as nomeEvento, e.Data as dataEvento, if (e.Status = 1, 'Ativo', 'Inativo') as eStatus, m.Nome as criadoPor";
            string condicao = "Eventos e INNER JOIN Motorista m ON(e.IdMotorista = m.ID) ORDER BY e.ID DESC";
            DataTable _dt = dfts.select(comandos, condicao);
            var bs = new BindingSource();
            bs.DataSource = _dt;
            dgvEventos.DataSource = bs;
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            preencheDGV();
        }

        private void btnPontos_Click(object sender, EventArgs e)
        {
            int idEventoDGV = getIDDGV();
            FRM_EventosPoints point = new FRM_EventosPoints();
            point.public_idEvento = idEventoDGV;
            point.ShowDialog();
        }
    }
}
