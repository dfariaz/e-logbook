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
            this.lblVERSAOBETA = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblNomeMotorista = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnEmpresas = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnControle = new System.Windows.Forms.Button();
            this.btnLogBook = new System.Windows.Forms.Button();
            this.dgvLogBook = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeinicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadedestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmrodado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSync = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.panelSysTitulo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogBook)).BeginInit();
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
            this.panelTitulo.Size = new System.Drawing.Size(763, 54);
            this.panelTitulo.TabIndex = 7;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_Principal_MouseDown);
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FRM_Principal_MouseMove);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::e_LogBook.Properties.Resources.btnFechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(719, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnFechar, "Fechar");
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::e_LogBook.Properties.Resources.btnMinimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(683, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BackgroundImage = global::e_LogBook.Properties.Resources.btnConfigurações;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(637, 8);
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
            // lblVERSAOBETA
            // 
            this.lblVERSAOBETA.AutoSize = true;
            this.lblVERSAOBETA.BackColor = System.Drawing.Color.Transparent;
            this.lblVERSAOBETA.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.lblVERSAOBETA.ForeColor = System.Drawing.Color.Red;
            this.lblVERSAOBETA.Location = new System.Drawing.Point(450, 62);
            this.lblVERSAOBETA.Name = "lblVERSAOBETA";
            this.lblVERSAOBETA.Size = new System.Drawing.Size(117, 27);
            this.lblVERSAOBETA.TabIndex = 11;
            this.lblVERSAOBETA.Text = "Versão Beta";
            this.lblVERSAOBETA.Visible = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblAdmin.Location = new System.Drawing.Point(199, 90);
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
            this.lblNomeMotorista.Location = new System.Drawing.Point(315, 61);
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
            this.label1.Location = new System.Drawing.Point(198, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bem vindo,";
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.btnConfiguracoes);
            this.panelMenu.Controls.Add(this.btnEmpresas);
            this.panelMenu.Controls.Add(this.btnInfo);
            this.panelMenu.Controls.Add(this.btnControle);
            this.panelMenu.Controls.Add(this.btnLogBook);
            this.panelMenu.Location = new System.Drawing.Point(-1, 53);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(189, 432);
            this.panelMenu.TabIndex = 9;
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracoes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.btnConfiguracoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfiguracoes.Location = new System.Drawing.Point(13, 244);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(165, 49);
            this.btnConfiguracoes.TabIndex = 5;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmpresas
            // 
            this.btnEmpresas.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpresas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresas.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmpresas.FlatAppearance.BorderSize = 0;
            this.btnEmpresas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEmpresas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresas.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.btnEmpresas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmpresas.Location = new System.Drawing.Point(13, 127);
            this.btnEmpresas.Name = "btnEmpresas";
            this.btnEmpresas.Size = new System.Drawing.Size(165, 49);
            this.btnEmpresas.TabIndex = 4;
            this.btnEmpresas.Text = "Empresa";
            this.btnEmpresas.UseVisualStyleBackColor = false;
            this.btnEmpresas.Click += new System.EventHandler(this.btnEmpresas_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.btnInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(13, 8);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(165, 49);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Perfil";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnControle
            // 
            this.btnControle.BackColor = System.Drawing.Color.Transparent;
            this.btnControle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnControle.FlatAppearance.BorderSize = 0;
            this.btnControle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnControle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnControle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControle.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.btnControle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnControle.Location = new System.Drawing.Point(13, 185);
            this.btnControle.Name = "btnControle";
            this.btnControle.Size = new System.Drawing.Size(165, 49);
            this.btnControle.TabIndex = 2;
            this.btnControle.Text = "Controle";
            this.btnControle.UseVisualStyleBackColor = false;
            this.btnControle.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // btnLogBook
            // 
            this.btnLogBook.BackColor = System.Drawing.Color.Transparent;
            this.btnLogBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogBook.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogBook.FlatAppearance.BorderSize = 0;
            this.btnLogBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogBook.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.btnLogBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogBook.Location = new System.Drawing.Point(13, 68);
            this.btnLogBook.Name = "btnLogBook";
            this.btnLogBook.Size = new System.Drawing.Size(165, 49);
            this.btnLogBook.TabIndex = 1;
            this.btnLogBook.Text = "Log Book";
            this.btnLogBook.UseVisualStyleBackColor = false;
            this.btnLogBook.Click += new System.EventHandler(this.btnLogBook_Click);
            // 
            // dgvLogBook
            // 
            this.dgvLogBook.AllowUserToAddRows = false;
            this.dgvLogBook.AllowUserToDeleteRows = false;
            this.dgvLogBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLogBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLogBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLogBook.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLogBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLogBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.data,
            this.cidadeinicial,
            this.cidadedestino,
            this.carga,
            this.kmrodado,
            this.status});
            this.dgvLogBook.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLogBook.Location = new System.Drawing.Point(203, 121);
            this.dgvLogBook.Name = "dgvLogBook";
            this.dgvLogBook.ReadOnly = true;
            this.dgvLogBook.RowHeadersVisible = false;
            this.dgvLogBook.Size = new System.Drawing.Size(723, 351);
            this.dgvLogBook.TabIndex = 12;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 29;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Visible = false;
            this.data.Width = 44;
            // 
            // cidadeinicial
            // 
            this.cidadeinicial.DataPropertyName = "cidadeinicial";
            this.cidadeinicial.HeaderText = "Cidade Inicial";
            this.cidadeinicial.Name = "cidadeinicial";
            this.cidadeinicial.ReadOnly = true;
            this.cidadeinicial.Width = 122;
            // 
            // cidadedestino
            // 
            this.cidadedestino.DataPropertyName = "cidadedestino";
            this.cidadedestino.HeaderText = "Cidade Destino";
            this.cidadedestino.Name = "cidadedestino";
            this.cidadedestino.ReadOnly = true;
            this.cidadedestino.Width = 132;
            // 
            // carga
            // 
            this.carga.DataPropertyName = "carga";
            this.carga.HeaderText = "Carga";
            this.carga.Name = "carga";
            this.carga.ReadOnly = true;
            this.carga.Width = 73;
            // 
            // kmrodado
            // 
            this.kmrodado.DataPropertyName = "kmrodado";
            this.kmrodado.HeaderText = "KM Rodado";
            this.kmrodado.Name = "kmrodado";
            this.kmrodado.ReadOnly = true;
            this.kmrodado.Width = 109;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 73;
            // 
            // btnSync
            // 
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSync.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.Image = global::e_LogBook.Properties.Resources.btnAtualizar;
            this.btnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.Location = new System.Drawing.Point(779, 62);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(122, 51);
            this.btnSync.TabIndex = 13;
            this.btnSync.Text = "Sincronizar";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(949, 483);
            this.ControlBox = false;
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.dgvLogBook);
            this.Controls.Add(this.lblVERSAOBETA);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblNomeMotorista);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.label1);
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
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelSysTitulo;
        private System.Windows.Forms.Label lblSysTitulo;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblNomeMotorista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblVERSAOBETA;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnEmpresas;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnControle;
        private System.Windows.Forms.Button btnLogBook;
        private System.Windows.Forms.DataGridView dgvLogBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeinicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadedestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn carga;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmrodado;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btnSync;
    }
}

