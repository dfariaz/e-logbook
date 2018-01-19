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

namespace e_LogBook.UI_ADM
{
    public partial class FRM_EventosPoints : Form
    {
        Defaults dft = new Defaults();

        public int public_idEvento { get; set; }
        private int idEvento, idpontos, idM, idRanking;
        private double pMes, pAno;
        private string motorista;
        public FRM_EventosPoints()
        {
            InitializeComponent();
        }

        private void FRM_EventosPoints_Load(object sender, EventArgs e)
        {
            if (!this.public_idEvento.Equals(""))
                idEvento = public_idEvento;
            preencheDGV(idEvento);
            changeColors();
        }

        private void preencheDGV(int evento)
        {
            DataTable _dt = dft.select("ID, Nome, if(Status = 1, 'Aceito', 'Inscrito') as Status, IdEvento","Participantes WHERE IdEvento = " + evento);
            var bs = new BindingSource();
            bs.DataSource = _dt;
            dgvPontos.DataSource = bs;
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPontos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaSelecionada = dgvPontos.CurrentRow;
            idpontos = Convert.ToInt32(linhaSelecionada.Cells["id"].Value.ToString());
            motorista = linhaSelecionada.Cells["nome"].Value.ToString();
            if (linhaSelecionada.Cells["status"].Value.ToString() == "Aceito")
                MessageBox.Show("Os pontos já foram dados ao motorista!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Deseja dar 10 pontos ao motorista: " + motorista + "?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string dPontos = darPontos(idpontos);
                    if (dPontos == "true")
                        MessageBox.Show("Os pontos foram dados ao motorista!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro: " + dPontos, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    preencheDGV(idEvento);
                }
            }
        }

        private string darPontos(int idE)
        {
            string upP = updateParticipantes(idE);
            if (upP == "true")
            {
                string uP = updatePontos(motorista);
                return uP;
            }
            else
                return upP;
        }

        private string updatePontos(string nome)
        {
            DataTable _dt = dft.select("ID, Login", "Motorista WHERE Login = '" + nome + "'");
            foreach(DataRow dr in _dt.Rows)
            {
                idM = Convert.ToInt32(dr["ID"].ToString());
            }

            DataTable _dtr = dft.select("ID, PontosAno, PontosMes", "Ranking WHERE IdMotorista = " + idM +" LIMIT 1");
            foreach(DataRow drr in _dtr.Rows)
            {
                idRanking = Convert.ToInt32(drr["ID"].ToString());
                pMes = Convert.ToDouble(drr["PontosMes"].ToString());
                pAno = Convert.ToDouble(drr["PontosAno"].ToString());
            }
            pMes = pMes + 10.0;
            pAno = pAno + 10.0;

            string _tabela = "Ranking";
            string _condicao = "ID = " + idRanking;
            return dft.UpdateRankingPontos(_tabela, pMes, pAno, _condicao);
        }

        private string updateParticipantes(int id)
        {
            string _tabela = "Participantes";
            string _comandos = "Status = 1";
            string _condicao = "ID = " + id;
            return dft.Update(_tabela, _comandos, _condicao);
        }
    }
}
