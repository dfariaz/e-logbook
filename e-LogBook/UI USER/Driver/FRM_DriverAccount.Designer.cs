namespace e_LogBook.UI_USER.Driver
{
    partial class FRM_DriverAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DriverAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelSysTitulo = new System.Windows.Forms.Panel();
            this.lblSysTitulo = new System.Windows.Forms.Label();
            this.tabControlDriver = new System.Windows.Forms.TabControl();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnTabFretes = new System.Windows.Forms.Button();
            this.lblNumeroCaminhao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblShowStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblShowData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gboxSenha = new System.Windows.Forms.GroupBox();
            this.checkViewer = new System.Windows.Forms.CheckBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressNivel = new System.Windows.Forms.ProgressBar();
            this.txtCSenhaNova = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFretes = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPontosAno = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.lblPontosMes = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblCountFretes = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvFretes = new System.Windows.Forms.DataGridView();
            this.idfrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeinicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadedestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmrodado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontuacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTitulo.SuspendLayout();
            this.panelSysTitulo.SuspendLayout();
            this.tabControlDriver.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.gboxSenha.SuspendLayout();
            this.tabFretes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFretes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.button1);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(189, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(821, 54);
            this.panelTitulo.TabIndex = 7;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::e_LogBook.Properties.Resources.btnMinimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(719, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 99;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::e_LogBook.Properties.Resources.btnFechar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(759, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 100;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(216, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Informações Pessoais";
            // 
            // panelSysTitulo
            // 
            this.panelSysTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSysTitulo.Controls.Add(this.lblSysTitulo);
            this.panelSysTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelSysTitulo.Name = "panelSysTitulo";
            this.panelSysTitulo.Size = new System.Drawing.Size(189, 54);
            this.panelSysTitulo.TabIndex = 6;
            // 
            // lblSysTitulo
            // 
            this.lblSysTitulo.AutoSize = true;
            this.lblSysTitulo.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.lblSysTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSysTitulo.Location = new System.Drawing.Point(41, 11);
            this.lblSysTitulo.Name = "lblSysTitulo";
            this.lblSysTitulo.Size = new System.Drawing.Size(104, 27);
            this.lblSysTitulo.TabIndex = 0;
            this.lblSysTitulo.Text = "e-LogBook";
            // 
            // tabControlDriver
            // 
            this.tabControlDriver.Controls.Add(this.tabAccount);
            this.tabControlDriver.Controls.Add(this.tabFretes);
            this.tabControlDriver.Location = new System.Drawing.Point(0, 26);
            this.tabControlDriver.Name = "tabControlDriver";
            this.tabControlDriver.SelectedIndex = 0;
            this.tabControlDriver.Size = new System.Drawing.Size(994, 437);
            this.tabControlDriver.TabIndex = 8;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.btnSalvar);
            this.tabAccount.Controls.Add(this.btnTabFretes);
            this.tabAccount.Controls.Add(this.lblNumeroCaminhao);
            this.tabAccount.Controls.Add(this.label7);
            this.tabAccount.Controls.Add(this.lblShowStatus);
            this.tabAccount.Controls.Add(this.label8);
            this.tabAccount.Controls.Add(this.lblShowData);
            this.tabAccount.Controls.Add(this.label6);
            this.tabAccount.Controls.Add(this.gboxSenha);
            this.tabAccount.Controls.Add(this.txtNome);
            this.tabAccount.Controls.Add(this.label1);
            this.tabAccount.Location = new System.Drawing.Point(4, 28);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(986, 405);
            this.tabAccount.TabIndex = 0;
            this.tabAccount.Text = "Conta";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(178, 186);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 49);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnTabFretes
            // 
            this.btnTabFretes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabFretes.FlatAppearance.BorderSize = 0;
            this.btnTabFretes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTabFretes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTabFretes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabFretes.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.btnTabFretes.Image = global::e_LogBook.Properties.Resources.Go;
            this.btnTabFretes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTabFretes.Location = new System.Drawing.Point(826, 7);
            this.btnTabFretes.Name = "btnTabFretes";
            this.btnTabFretes.Size = new System.Drawing.Size(148, 63);
            this.btnTabFretes.TabIndex = 6;
            this.btnTabFretes.Text = "Ir para Fretes";
            this.btnTabFretes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnTabFretes, "Ir para fretes");
            this.btnTabFretes.UseVisualStyleBackColor = true;
            this.btnTabFretes.Click += new System.EventHandler(this.btnTabFretes_Click);
            // 
            // lblNumeroCaminhao
            // 
            this.lblNumeroCaminhao.AutoSize = true;
            this.lblNumeroCaminhao.Location = new System.Drawing.Point(174, 152);
            this.lblNumeroCaminhao.Name = "lblNumeroCaminhao";
            this.lblNumeroCaminhao.Size = new System.Drawing.Size(62, 19);
            this.lblNumeroCaminhao.TabIndex = 8;
            this.lblNumeroCaminhao.Text = "Número";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Número do Caminhão:";
            // 
            // lblShowStatus
            // 
            this.lblShowStatus.AutoSize = true;
            this.lblShowStatus.Location = new System.Drawing.Point(174, 112);
            this.lblShowStatus.Name = "lblShowStatus";
            this.lblShowStatus.Size = new System.Drawing.Size(48, 19);
            this.lblShowStatus.TabIndex = 6;
            this.lblShowStatus.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Status:";
            // 
            // lblShowData
            // 
            this.lblShowData.AutoSize = true;
            this.lblShowData.Location = new System.Drawing.Point(174, 74);
            this.lblShowData.Name = "lblShowData";
            this.lblShowData.Size = new System.Drawing.Size(40, 19);
            this.lblShowData.TabIndex = 4;
            this.lblShowData.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Data Cadastro:";
            // 
            // gboxSenha
            // 
            this.gboxSenha.Controls.Add(this.checkViewer);
            this.gboxSenha.Controls.Add(this.lblErro);
            this.gboxSenha.Controls.Add(this.label5);
            this.gboxSenha.Controls.Add(this.progressNivel);
            this.gboxSenha.Controls.Add(this.txtCSenhaNova);
            this.gboxSenha.Controls.Add(this.label4);
            this.gboxSenha.Controls.Add(this.txtSenhaNova);
            this.gboxSenha.Controls.Add(this.label3);
            this.gboxSenha.Controls.Add(this.txtSenhaAtual);
            this.gboxSenha.Controls.Add(this.label2);
            this.gboxSenha.Location = new System.Drawing.Point(538, 28);
            this.gboxSenha.Name = "gboxSenha";
            this.gboxSenha.Size = new System.Drawing.Size(323, 337);
            this.gboxSenha.TabIndex = 2;
            this.gboxSenha.TabStop = false;
            this.gboxSenha.Text = "Alterar Senha";
            // 
            // checkViewer
            // 
            this.checkViewer.AutoSize = true;
            this.checkViewer.Location = new System.Drawing.Point(167, 204);
            this.checkViewer.Name = "checkViewer";
            this.checkViewer.Size = new System.Drawing.Size(130, 23);
            this.checkViewer.TabIndex = 4;
            this.checkViewer.Text = "Mostrar Senhas";
            this.checkViewer.UseVisualStyleBackColor = true;
            this.checkViewer.CheckedChanged += new System.EventHandler(this.checkViewer_CheckedChanged);
            // 
            // lblErro
            // 
            this.lblErro.Location = new System.Drawing.Point(18, 254);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(279, 71);
            this.lblErro.TabIndex = 10;
            this.lblErro.Text = "Erro";
            this.lblErro.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nível de Força";
            // 
            // progressNivel
            // 
            this.progressNivel.Location = new System.Drawing.Point(21, 228);
            this.progressNivel.Name = "progressNivel";
            this.progressNivel.Size = new System.Drawing.Size(276, 23);
            this.progressNivel.TabIndex = 8;
            // 
            // txtCSenhaNova
            // 
            this.txtCSenhaNova.Location = new System.Drawing.Point(21, 169);
            this.txtCSenhaNova.Name = "txtCSenhaNova";
            this.txtCSenhaNova.Size = new System.Drawing.Size(276, 27);
            this.txtCSenhaNova.TabIndex = 3;
            this.txtCSenhaNova.UseSystemPasswordChar = true;
            this.txtCSenhaNova.Leave += new System.EventHandler(this.txtCSenhaNova_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirme a nova Senha:";
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Location = new System.Drawing.Point(21, 112);
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.Size = new System.Drawing.Size(276, 27);
            this.txtSenhaNova.TabIndex = 2;
            this.txtSenhaNova.UseSystemPasswordChar = true;
            this.txtSenhaNova.Leave += new System.EventHandler(this.txtSenhaNova_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nova Senha:";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(21, 52);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(276, 27);
            this.txtSenhaAtual.TabIndex = 1;
            this.txtSenhaAtual.UseSystemPasswordChar = true;
            this.txtSenhaAtual.Leave += new System.EventHandler(this.txtSenhaAtual_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha Atual:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(174, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(340, 27);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tabFretes
            // 
            this.tabFretes.Controls.Add(this.label17);
            this.tabFretes.Controls.Add(this.lblPontosAno);
            this.tabFretes.Controls.Add(this.label20);
            this.tabFretes.Controls.Add(this.btnAtualizar);
            this.tabFretes.Controls.Add(this.btnListar);
            this.tabFretes.Controls.Add(this.btnViewAccount);
            this.tabFretes.Controls.Add(this.lblPontosMes);
            this.tabFretes.Controls.Add(this.label18);
            this.tabFretes.Controls.Add(this.lblCountFretes);
            this.tabFretes.Controls.Add(this.label19);
            this.tabFretes.Controls.Add(this.dgvFretes);
            this.tabFretes.Location = new System.Drawing.Point(4, 28);
            this.tabFretes.Name = "tabFretes";
            this.tabFretes.Padding = new System.Windows.Forms.Padding(3);
            this.tabFretes.Size = new System.Drawing.Size(986, 405);
            this.tabFretes.TabIndex = 1;
            this.tabFretes.Text = "Fretes";
            this.tabFretes.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 19);
            this.label17.TabIndex = 41;
            this.label17.Text = "Ano:";
            // 
            // lblPontosAno
            // 
            this.lblPontosAno.AutoSize = true;
            this.lblPontosAno.Location = new System.Drawing.Point(73, 77);
            this.lblPontosAno.Name = "lblPontosAno";
            this.lblPontosAno.Size = new System.Drawing.Size(17, 19);
            this.lblPontosAno.TabIndex = 40;
            this.lblPontosAno.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(34, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 19);
            this.label20.TabIndex = 39;
            this.label20.Text = "Mês:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Image = global::e_LogBook.Properties.Resources.btnAtualizar;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(461, 48);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(110, 52);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnListar
            // 
            this.btnListar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Image = global::e_LogBook.Properties.Resources.btnListar;
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.Location = new System.Drawing.Point(323, 48);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(132, 52);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar todos";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAccount.FlatAppearance.BorderSize = 0;
            this.btnViewAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnViewAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnViewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAccount.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.btnViewAccount.Image = global::e_LogBook.Properties.Resources.Back;
            this.btnViewAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAccount.Location = new System.Drawing.Point(825, 6);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(151, 63);
            this.btnViewAccount.TabIndex = 36;
            this.btnViewAccount.Text = "Ir para Dados";
            this.btnViewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnViewAccount, "Ir para dados");
            this.btnViewAccount.UseVisualStyleBackColor = true;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // lblPontosMes
            // 
            this.lblPontosMes.AutoSize = true;
            this.lblPontosMes.Location = new System.Drawing.Point(73, 48);
            this.lblPontosMes.Name = "lblPontosMes";
            this.lblPontosMes.Size = new System.Drawing.Size(17, 19);
            this.lblPontosMes.TabIndex = 35;
            this.lblPontosMes.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 19);
            this.label18.TabIndex = 34;
            this.label18.Text = "Pontos";
            // 
            // lblCountFretes
            // 
            this.lblCountFretes.AutoSize = true;
            this.lblCountFretes.Location = new System.Drawing.Point(235, 22);
            this.lblCountFretes.Name = "lblCountFretes";
            this.lblCountFretes.Size = new System.Drawing.Size(17, 19);
            this.lblCountFretes.TabIndex = 33;
            this.lblCountFretes.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(167, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 19);
            this.label19.TabIndex = 32;
            this.label19.Text = "Fretes:";
            // 
            // dgvFretes
            // 
            this.dgvFretes.AllowUserToAddRows = false;
            this.dgvFretes.AllowUserToDeleteRows = false;
            this.dgvFretes.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFretes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFretes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFretes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFretes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFretes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFretes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfrete,
            this.cidadeinicial,
            this.cidadedestino,
            this.kmrodado,
            this.carga,
            this.dano,
            this.data,
            this.pontuacao});
            this.dgvFretes.Location = new System.Drawing.Point(6, 106);
            this.dgvFretes.Name = "dgvFretes";
            this.dgvFretes.ReadOnly = true;
            this.dgvFretes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFretes.Size = new System.Drawing.Size(968, 287);
            this.dgvFretes.TabIndex = 23;
            // 
            // idfrete
            // 
            this.idfrete.DataPropertyName = "ID";
            this.idfrete.HeaderText = "ID Frete";
            this.idfrete.Name = "idfrete";
            this.idfrete.ReadOnly = true;
            // 
            // cidadeinicial
            // 
            this.cidadeinicial.DataPropertyName = "CidadeInicial";
            this.cidadeinicial.HeaderText = "Cidade Inicial";
            this.cidadeinicial.Name = "cidadeinicial";
            this.cidadeinicial.ReadOnly = true;
            // 
            // cidadedestino
            // 
            this.cidadedestino.DataPropertyName = "CidadeDestino";
            this.cidadedestino.HeaderText = "Cidade Destino";
            this.cidadedestino.Name = "cidadedestino";
            this.cidadedestino.ReadOnly = true;
            // 
            // kmrodado
            // 
            this.kmrodado.DataPropertyName = "KmRodado";
            this.kmrodado.HeaderText = "KM Rodado";
            this.kmrodado.Name = "kmrodado";
            this.kmrodado.ReadOnly = true;
            // 
            // carga
            // 
            this.carga.DataPropertyName = "Carga";
            this.carga.HeaderText = "Carga";
            this.carga.Name = "carga";
            this.carga.ReadOnly = true;
            // 
            // dano
            // 
            this.dano.DataPropertyName = "Dano";
            this.dano.HeaderText = "Dano %";
            this.dano.Name = "dano";
            this.dano.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "DataFinalFrete";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // pontuacao
            // 
            this.pontuacao.DataPropertyName = "Pontuacao";
            this.pontuacao.HeaderText = "Pontuação";
            this.pontuacao.Name = "pontuacao";
            this.pontuacao.ReadOnly = true;
            // 
            // FRM_DriverAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(991, 462);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelSysTitulo);
            this.Controls.Add(this.tabControlDriver);
            this.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_DriverAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta do Motorista";
            this.Load += new System.EventHandler(this.FRM_DriverAccount_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelSysTitulo.ResumeLayout(false);
            this.panelSysTitulo.PerformLayout();
            this.tabControlDriver.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.gboxSenha.ResumeLayout(false);
            this.gboxSenha.PerformLayout();
            this.tabFretes.ResumeLayout(false);
            this.tabFretes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFretes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelSysTitulo;
        private System.Windows.Forms.Label lblSysTitulo;
        private System.Windows.Forms.TabControl tabControlDriver;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabFretes;
        private System.Windows.Forms.GroupBox gboxSenha;
        private System.Windows.Forms.ProgressBar progressNivel;
        private System.Windows.Forms.TextBox txtCSenhaNova;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.CheckBox checkViewer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblShowData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumeroCaminhao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblShowStatus;
        private System.Windows.Forms.DataGridView dgvFretes;
        private System.Windows.Forms.Label lblPontosMes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblCountFretes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnTabFretes;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblPontosAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeinicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadedestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmrodado;
        private System.Windows.Forms.DataGridViewTextBoxColumn carga;
        private System.Windows.Forms.DataGridViewTextBoxColumn dano;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontuacao;
        private System.Windows.Forms.Button btnMinimizar;
    }
}