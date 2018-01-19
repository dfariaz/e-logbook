namespace e_LogBook.UI_ADM
{
    partial class FRM_EventosNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EventosNew));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelSysTitulo = new System.Windows.Forms.Panel();
            this.lblSysTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtOBS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboResp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEventoSave = new System.Windows.Forms.Button();
            this.btnIMG = new System.Windows.Forms.Button();
            this.lblNomeIMG = new System.Windows.Forms.Label();
            this.lblCarregando = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.panelSysTitulo.SuspendLayout();
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
            this.panelTitulo.Location = new System.Drawing.Point(188, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(615, 54);
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
            this.btnMinimizar.Location = new System.Drawing.Point(534, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 8;
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
            this.button1.Location = new System.Drawing.Point(570, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 4;
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
            this.lblTitulo.Size = new System.Drawing.Size(89, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Eventos";
            // 
            // panelSysTitulo
            // 
            this.panelSysTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSysTitulo.Controls.Add(this.lblSysTitulo);
            this.panelSysTitulo.Location = new System.Drawing.Point(-1, 0);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(151, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 27);
            this.txtNome.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(472, 66);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(284, 27);
            this.txtData.TabIndex = 11;
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(151, 100);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(250, 27);
            this.txtSaida.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Saída:";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(472, 100);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(284, 27);
            this.txtDestino.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Destino:";
            // 
            // txtHora
            // 
            this.txtHora.CustomFormat = "HH:mm";
            this.txtHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtHora.Location = new System.Drawing.Point(151, 133);
            this.txtHora.Name = "txtHora";
            this.txtHora.ShowUpDown = true;
            this.txtHora.Size = new System.Drawing.Size(250, 27);
            this.txtHora.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cboStatus.Location = new System.Drawing.Point(472, 133);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(284, 27);
            this.cboStatus.TabIndex = 19;
            // 
            // txtOBS
            // 
            this.txtOBS.Location = new System.Drawing.Point(151, 166);
            this.txtOBS.Multiline = true;
            this.txtOBS.Name = "txtOBS";
            this.txtOBS.Size = new System.Drawing.Size(605, 79);
            this.txtOBS.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Observações:";
            // 
            // cboResp
            // 
            this.cboResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResp.FormattingEnabled = true;
            this.cboResp.Location = new System.Drawing.Point(151, 251);
            this.cboResp.Name = "cboResp";
            this.cboResp.Size = new System.Drawing.Size(238, 27);
            this.cboResp.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Responsável:";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(472, 251);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(284, 27);
            this.cboEmpresa.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Empresa:";
            // 
            // btnEventoSave
            // 
            this.btnEventoSave.BackColor = System.Drawing.Color.Transparent;
            this.btnEventoSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEventoSave.FlatAppearance.BorderSize = 0;
            this.btnEventoSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEventoSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEventoSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventoSave.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.btnEventoSave.ForeColor = System.Drawing.Color.Black;
            this.btnEventoSave.Image = global::e_LogBook.Properties.Resources.btnSalvarNew;
            this.btnEventoSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventoSave.Location = new System.Drawing.Point(645, 284);
            this.btnEventoSave.Name = "btnEventoSave";
            this.btnEventoSave.Size = new System.Drawing.Size(111, 49);
            this.btnEventoSave.TabIndex = 26;
            this.btnEventoSave.Text = "Salvar";
            this.btnEventoSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEventoSave.UseVisualStyleBackColor = false;
            this.btnEventoSave.Click += new System.EventHandler(this.btnEventoSave_Click);
            // 
            // btnIMG
            // 
            this.btnIMG.BackColor = System.Drawing.Color.Transparent;
            this.btnIMG.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIMG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIMG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIMG.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.btnIMG.ForeColor = System.Drawing.Color.Black;
            this.btnIMG.Location = new System.Drawing.Point(151, 284);
            this.btnIMG.Name = "btnIMG";
            this.btnIMG.Size = new System.Drawing.Size(111, 33);
            this.btnIMG.TabIndex = 27;
            this.btnIMG.Text = "Imagem";
            this.btnIMG.UseVisualStyleBackColor = false;
            this.btnIMG.Click += new System.EventHandler(this.btnIMG_Click);
            // 
            // lblNomeIMG
            // 
            this.lblNomeIMG.AutoSize = true;
            this.lblNomeIMG.Location = new System.Drawing.Point(147, 320);
            this.lblNomeIMG.Name = "lblNomeIMG";
            this.lblNomeIMG.Size = new System.Drawing.Size(76, 19);
            this.lblNomeIMG.TabIndex = 28;
            this.lblNomeIMG.Text = "NomeIMG";
            this.lblNomeIMG.Visible = false;
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCarregando.Location = new System.Drawing.Point(317, 292);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(243, 19);
            this.lblCarregando.TabIndex = 29;
            this.lblCarregando.Text = "Imagem sendo carregada, aguarde!";
            this.lblCarregando.Visible = false;
            // 
            // FRM_EventosNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(798, 351);
            this.ControlBox = false;
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.lblNomeIMG);
            this.Controls.Add(this.btnIMG);
            this.Controls.Add(this.btnEventoSave);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboResp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOBS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelSysTitulo);
            this.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_EventosNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo/Editar Evento";
            this.Load += new System.EventHandler(this.FRM_EventosNew_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelSysTitulo.ResumeLayout(false);
            this.panelSysTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelSysTitulo;
        private System.Windows.Forms.Label lblSysTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtOBS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboResp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEventoSave;
        private System.Windows.Forms.Button btnIMG;
        private System.Windows.Forms.Label lblNomeIMG;
        private System.Windows.Forms.Label lblCarregando;
    }
}