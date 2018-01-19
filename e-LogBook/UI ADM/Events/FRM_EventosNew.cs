using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using e_LogBook.Properties;
using e_LogBook.Controller;

namespace e_LogBook.UI_ADM
{
    public partial class FRM_EventosNew : Form
    {
        DriverController drv = new DriverController();
        CompanyController cll = new CompanyController();
        Optional opt = new Optional();
        Defaults dft = new Defaults();

        public int public_empresas { get; set; }
        public int public_id_evento { get; set; }
        private int empresas_id, id_evento;
        public FRM_EventosNew()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string nome, saida, data, destino, hora, obs, img, caminhoarquivo, nomeext;
        private int status, resp, empresa;

        private void preencheCampos(int eventoid)
        {
            DataTable dt = dft.select("*", "Eventos WHERE ID = "+ eventoid);
            foreach(DataRow dr in dt.Rows)
            {
                nome = dr["Nome"].ToString();
                saida = dr["Saida"].ToString();
                destino = dr["Destino"].ToString();
                data = dr["Data"].ToString();
                hora = dr["Hora"].ToString();
                obs = dr["Observacoes"].ToString();
                status = Convert.ToInt32(dr["Status"].ToString());
                resp = Convert.ToInt32(dr["IdMotorista"].ToString());
                empresa = Convert.ToInt32(dr["IdEmpresa"].ToString());
                img = dr["IMG"].ToString();
            }
            lblTitulo.Text = "Evento: " + nome;
            txtNome.Text = nome;
            txtSaida.Text = saida;
            txtData.Value = Convert.ToDateTime(data);
            txtDestino.Text = destino;
            txtHora.Value = Convert.ToDateTime(hora);
            txtOBS.Text = obs;
            cboEmpresa.SelectedItem = empresa;
            cboResp.SelectedItem = resp;
            if (status == 1)
                cboStatus.Text = "Ativo";
            else
                cboStatus.Text = "Inativo";
            lblNomeIMG.Text = img;
            lblNomeIMG.Visible = true;

            cboEmpresa.Enabled = false;
            cboResp.Enabled = false;
        }

        private void btnEventoSave_Click(object sender, EventArgs e)
        {
            bool val = validaCampos();
            if (val == true)
            {
                if (id_evento != 0)
                {
                    string result = opt.updateEvento(nome, data, saida, destino, hora, status, obs, img, id_evento);
                    if (result == "true")
                        MessageBox.Show("Evento atualizado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("O evento não foi atualizado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string result = opt.saveEvento(empresa, nome, data, saida, destino, hora, resp, status, obs, img);
                    if (result == "true")
                        MessageBox.Show("Evento criado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("O evento não foi criado com sucesso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool validaCampos()
        {
            status = 0; resp = 0; empresa = 0;
            nome = txtNome.Text;
            saida = txtSaida.Text;
            data = txtData.Value.ToString("dd/MM/yyyy");
            destino = txtDestino.Text;
            hora = txtHora.Value.ToString("HH:mm");
            obs = txtOBS.Text;
            if (cboStatus.Text == "Ativo")
                status = 1;
            else if (cboStatus.Text == "Inativo")
                status = 2;
            else
                status = 0;
            img = lblNomeIMG.Text;
            resp = Convert.ToInt32(cboResp.SelectedValue);
            empresa = Convert.ToInt32(cboEmpresa.SelectedValue);

            int acm = 0;

            if (nome == "")
                acm = 1;
            if (saida == "")
                acm += 1;
            if (data == "")
                acm += 1;
            if (destino == "")
                acm += 1;
            if (hora == "")
                acm += 1;
            if (obs == "")
                acm += 1;
            if (status == 0)
                acm += 1;
            if (resp == 0)
                acm += 1;
            if (empresa == 0)
                acm += 1;
            if (img == "NomeIMG")
                acm += 1;

            if (acm == 6)
                return false;
            else
                return true;
        }

        private void btnIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.CheckFileExists = true;
            ofd1.Multiselect = false;
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                caminhoarquivo = ofd1.FileName;
                FileInfo fileInfo2 = new FileInfo(caminhoarquivo);
                nomeext = fileInfo2.Name;
                lblNomeIMG.Text = nomeext;
            }

            lblCarregando.Visible = true;
            
            string url = "ftp://br834.hostgator.com.br";
            string usuario = "elogbook@zerohoravirtual.com";
            string senha = "@Logbook";
            string arquivo = caminhoarquivo;

            string urlArquivoEnviar = url+ "/beta/Images/Eventos/" + Path.GetFileName(arquivo);
            try
            {
                EnviarArquivoFTP(arquivo, urlArquivoEnviar, usuario, senha);
                lblNomeIMG.Visible = true;
                lblCarregando.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRM_EventosNew_Load(object sender, EventArgs e)
        {
            if (!this.public_empresas.Equals(""))
                empresas_id = this.public_empresas;
            if (!this.public_id_evento.Equals(""))
                id_evento = this.public_id_evento;
            preencheCombos(empresas_id);
            if (id_evento != 0)
                preencheCampos(id_evento);
            changeColors();
        }

        private void preencheCombos(int empresa_id)
        {
            DataTable _dt = new DataTable();
            _dt = drv.getInformationMotoristas(empresa_id);
            DataRow _row = _dt.NewRow();
            _row["Nome"] = "";

            cboResp.DataSource = _dt;
            cboResp.ValueMember = "ID";
            cboResp.DisplayMember = "Nome";

            DataTable _dt2 = new DataTable();
            _dt2 = cll.infoEmpresa(0);
            DataRow _row2 = _dt2.NewRow();
            _row2["Nome"] = "";

            cboEmpresa.DataSource = _dt2;
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

        #region FTP
        public static void EnviarArquivoFTP(string arquivo, string url, string usuario, string senha)
        {
            try
            {
                FileInfo arquivoInfo = new FileInfo(arquivo);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(url));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(usuario, senha);
                request.UseBinary = true;
                request.ContentLength = arquivoInfo.Length;
                using (FileStream fs = arquivoInfo.OpenRead())
                {
                    byte[] buffer = new byte[2048];
                    int bytesSent = 0;
                    int bytes = 0;
                    using (Stream stream = request.GetRequestStream())
                    {
                        while (bytesSent < arquivoInfo.Length)
                        {
                            bytes = fs.Read(buffer, 0, buffer.Length);
                            stream.Write(buffer, 0, bytes);
                            bytesSent += bytes;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        #endregion        
    }
}
