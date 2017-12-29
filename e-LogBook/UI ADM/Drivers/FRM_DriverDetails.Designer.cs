namespace e_LogBook.UI_ADM.Drivers
{
    partial class FRM_DriverDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DriverDetails));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblNomeMotorista = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelSysTitulo = new System.Windows.Forms.Panel();
            this.lblSysTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountFretes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvFretes = new System.Windows.Forms.DataGridView();
            this.idfrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeinicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadedestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmrodado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontuacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPontosAno = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPontosMes = new System.Windows.Forms.Label();
            this.lblNumeroCaminhao = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.panelSysTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFretes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitulo.Controls.Add(this.lblNomeMotorista);
            this.panelTitulo.Controls.Add(this.button1);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(189, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(887, 54);
            this.panelTitulo.TabIndex = 5;
            // 
            // lblNomeMotorista
            // 
            this.lblNomeMotorista.AutoSize = true;
            this.lblNomeMotorista.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.lblNomeMotorista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeMotorista.Location = new System.Drawing.Point(246, 10);
            this.lblNomeMotorista.Name = "lblNomeMotorista";
            this.lblNomeMotorista.Size = new System.Drawing.Size(235, 29);
            this.lblNomeMotorista.TabIndex = 5;
            this.lblNomeMotorista.Text = "Controle de Motoristas";
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
            this.button1.Location = new System.Drawing.Point(761, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Detalhes do Motorista:";
            // 
            // panelSysTitulo
            // 
            this.panelSysTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSysTitulo.Controls.Add(this.lblSysTitulo);
            this.panelSysTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelSysTitulo.Name = "panelSysTitulo";
            this.panelSysTitulo.Size = new System.Drawing.Size(189, 54);
            this.panelSysTitulo.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboStatus.Location = new System.Drawing.Point(189, 66);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(179, 27);
            this.cboStatus.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empresa:";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(189, 104);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(409, 27);
            this.cboEmpresa.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fretes:";
            // 
            // lblCountFretes
            // 
            this.lblCountFretes.AutoSize = true;
            this.lblCountFretes.Location = new System.Drawing.Point(185, 143);
            this.lblCountFretes.Name = "lblCountFretes";
            this.lblCountFretes.Size = new System.Drawing.Size(17, 19);
            this.lblCountFretes.TabIndex = 11;
            this.lblCountFretes.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pontos:";
            // 
            // dgvFretes
            // 
            this.dgvFretes.AllowUserToAddRows = false;
            this.dgvFretes.AllowUserToDeleteRows = false;
            this.dgvFretes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFretes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvFretes.Location = new System.Drawing.Point(12, 198);
            this.dgvFretes.Name = "dgvFretes";
            this.dgvFretes.ReadOnly = true;
            this.dgvFretes.Size = new System.Drawing.Size(968, 287);
            this.dgvFretes.TabIndex = 14;
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
            this.btnSalvar.Location = new System.Drawing.Point(874, 143);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 49);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.Image = global::e_LogBook.Properties.Resources.btnAtualizar;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(738, 143);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(130, 49);
            this.btnAtualizar.TabIndex = 25;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(330, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 19);
            this.label17.TabIndex = 48;
            this.label17.Text = "Ano:";
            // 
            // lblPontosAno
            // 
            this.lblPontosAno.AutoSize = true;
            this.lblPontosAno.Location = new System.Drawing.Point(366, 173);
            this.lblPontosAno.Name = "lblPontosAno";
            this.lblPontosAno.Size = new System.Drawing.Size(17, 19);
            this.lblPontosAno.TabIndex = 47;
            this.lblPontosAno.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(189, 173);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 19);
            this.label20.TabIndex = 46;
            this.label20.Text = "Mês:";
            // 
            // lblPontosMes
            // 
            this.lblPontosMes.AutoSize = true;
            this.lblPontosMes.Location = new System.Drawing.Point(228, 173);
            this.lblPontosMes.Name = "lblPontosMes";
            this.lblPontosMes.Size = new System.Drawing.Size(17, 19);
            this.lblPontosMes.TabIndex = 45;
            this.lblPontosMes.Text = "0";
            // 
            // lblNumeroCaminhao
            // 
            this.lblNumeroCaminhao.AutoSize = true;
            this.lblNumeroCaminhao.Location = new System.Drawing.Point(487, 143);
            this.lblNumeroCaminhao.Name = "lblNumeroCaminhao";
            this.lblNumeroCaminhao.Size = new System.Drawing.Size(17, 19);
            this.lblNumeroCaminhao.TabIndex = 50;
            this.lblNumeroCaminhao.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Número do Caminhão:";
            // 
            // FRM_DriverDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(988, 501);
            this.Controls.Add(this.lblNumeroCaminhao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblPontosAno);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblPontosMes);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvFretes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCountFretes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelSysTitulo);
            this.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_DriverDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes - Controle de Motoristas";
            this.Load += new System.EventHandler(this.FRM_DriverDetails_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelSysTitulo.ResumeLayout(false);
            this.panelSysTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFretes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelSysTitulo;
        private System.Windows.Forms.Label lblSysTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCountFretes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvFretes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNomeMotorista;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblPontosAno;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblPontosMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeinicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadedestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmrodado;
        private System.Windows.Forms.DataGridViewTextBoxColumn carga;
        private System.Windows.Forms.DataGridViewTextBoxColumn dano;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontuacao;
        private System.Windows.Forms.Label lblNumeroCaminhao;
        private System.Windows.Forms.Label label6;
    }
}