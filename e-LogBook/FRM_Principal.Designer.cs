namespace e_LogBook
{
    partial class FRM_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelSysTitulo = new System.Windows.Forms.Panel();
            this.lblSysTitulo = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVERSAOBETA = new System.Windows.Forms.Label();
            this.listaDados = new System.Windows.Forms.ListBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblNomeMotorista = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerLogBook = new System.Windows.Forms.Timer(this.components);
            this.panelTitulo.SuspendLayout();
            this.panelSysTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitulo.Controls.Add(this.btnFechar);
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnConfig);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(188, -1);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(409, 54);
            this.panelTitulo.TabIndex = 7;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_Principal_MouseDown);
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FRM_Principal_MouseMove);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::e_LogBook.Properties.Resources.btnFechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(361, 11);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnFechar, "Fechar");
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
            this.btnMinimizar.Location = new System.Drawing.Point(320, 11);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BackgroundImage = global::e_LogBook.Properties.Resources.btnConfigurações;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(245, 8);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(40, 40);
            this.btnConfig.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnConfig, "Configurações");
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menu Principal";
            // 
            // panelSysTitulo
            // 
            this.panelSysTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSysTitulo.Controls.Add(this.lblSysTitulo);
            this.panelSysTitulo.Location = new System.Drawing.Point(-1, -1);
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
            // btnEmpresa
            // 
            this.btnEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpresa.BackgroundImage = global::e_LogBook.Properties.Resources.btnEmpresa;
            this.btnEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.FlatAppearance.BorderSize = 0;
            this.btnEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresa.Location = new System.Drawing.Point(204, 19);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(76, 77);
            this.btnEmpresa.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnEmpresa, "Empresa");
            this.btnEmpresa.UseVisualStyleBackColor = false;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.BackColor = System.Drawing.Color.Transparent;
            this.btnAdm.BackgroundImage = global::e_LogBook.Properties.Resources.btnAdmin;
            this.btnAdm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdm.FlatAppearance.BorderSize = 0;
            this.btnAdm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Location = new System.Drawing.Point(29, 195);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(76, 77);
            this.btnAdm.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnAdm, "Painel Administrativo");
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Visible = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Transparent;
            this.btnLog.BackgroundImage = global::e_LogBook.Properties.Resources.btnLogBook;
            this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Location = new System.Drawing.Point(115, 19);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(76, 77);
            this.btnLog.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnLog, "Log BooK");
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.BackColor = System.Drawing.Color.Transparent;
            this.btnInformacoes.BackgroundImage = global::e_LogBook.Properties.Resources.btnInfo;
            this.btnInformacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInformacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformacoes.FlatAppearance.BorderSize = 0;
            this.btnInformacoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInformacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInformacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacoes.Location = new System.Drawing.Point(27, 19);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(76, 77);
            this.btnInformacoes.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnInformacoes, "Minhas informações");
            this.btnInformacoes.UseVisualStyleBackColor = false;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::e_LogBook.Properties.Resources.Principal;
            this.panel1.Controls.Add(this.lblVERSAOBETA);
            this.panel1.Controls.Add(this.listaDados);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.lblNomeMotorista);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEmpresa);
            this.panel1.Controls.Add(this.btnAdm);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.btnInformacoes);
            this.panel1.Location = new System.Drawing.Point(-1, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 300);
            this.panel1.TabIndex = 8;
            // 
            // lblVERSAOBETA
            // 
            this.lblVERSAOBETA.AutoSize = true;
            this.lblVERSAOBETA.BackColor = System.Drawing.Color.Transparent;
            this.lblVERSAOBETA.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.lblVERSAOBETA.ForeColor = System.Drawing.Color.Red;
            this.lblVERSAOBETA.Location = new System.Drawing.Point(276, 111);
            this.lblVERSAOBETA.Name = "lblVERSAOBETA";
            this.lblVERSAOBETA.Size = new System.Drawing.Size(117, 27);
            this.lblVERSAOBETA.TabIndex = 11;
            this.lblVERSAOBETA.Text = "Versão Beta";
            this.lblVERSAOBETA.Visible = false;
            // 
            // listaDados
            // 
            this.listaDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaDados.FormattingEnabled = true;
            this.listaDados.ItemHeight = 19;
            this.listaDados.Items.AddRange(new object[] {
            "Controle de Motoristas",
            "Configurações"});
            this.listaDados.Location = new System.Drawing.Point(115, 194);
            this.listaDados.Name = "listaDados";
            this.listaDados.Size = new System.Drawing.Size(210, 78);
            this.listaDados.TabIndex = 10;
            this.listaDados.Visible = false;
            this.listaDados.Click += new System.EventHandler(this.listaDados_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblAdmin.Location = new System.Drawing.Point(25, 139);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(51, 19);
            this.lblAdmin.TabIndex = 8;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Visible = false;
            // 
            // lblNomeMotorista
            // 
            this.lblNomeMotorista.AutoSize = true;
            this.lblNomeMotorista.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeMotorista.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.lblNomeMotorista.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblNomeMotorista.Location = new System.Drawing.Point(141, 110);
            this.lblNomeMotorista.Name = "lblNomeMotorista";
            this.lblNomeMotorista.Size = new System.Drawing.Size(116, 29);
            this.lblNomeMotorista.TabIndex = 7;
            this.lblNomeMotorista.Text = "Motorista!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(24, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bem vindo,";
            // 
            // timerLogBook
            // 
            this.timerLogBook.Interval = 45000;
            this.timerLogBook.Tick += new System.EventHandler(this.timerLogBook_Tick);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(595, 352);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelSysTitulo);
            this.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FRM_Principal_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelSysTitulo.ResumeLayout(false);
            this.panelSysTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelSysTitulo;
        private System.Windows.Forms.Label lblSysTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInformacoes;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Label lblNomeMotorista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.ListBox listaDados;
        private System.Windows.Forms.Label lblVERSAOBETA;
        private System.Windows.Forms.Timer timerLogBook;
    }
}

