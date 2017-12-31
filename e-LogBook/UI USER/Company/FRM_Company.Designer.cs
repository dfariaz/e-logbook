namespace e_LogBook.UI_USER.Company
{
    partial class FRM_Company
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Company));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelSysTitulo = new System.Windows.Forms.Panel();
            this.lblSysTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.lblQTDMotoristas = new System.Windows.Forms.Label();
            this.lblMesEmpresa = new System.Windows.Forms.Label();
            this.lblMensalMotorista = new System.Windows.Forms.Label();
            this.lblAnoEmpresa = new System.Windows.Forms.Label();
            this.lblAnoMotorista = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.panelSysTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitulo.Controls.Add(this.btnFechar);
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(189, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(333, 54);
            this.panelTitulo.TabIndex = 9;
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
            this.btnFechar.Location = new System.Drawing.Point(288, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 3;
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
            this.btnMinimizar.Location = new System.Drawing.Point(249, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(105, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Empresas";
            // 
            // panelSysTitulo
            // 
            this.panelSysTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSysTitulo.Controls.Add(this.lblSysTitulo);
            this.panelSysTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelSysTitulo.Name = "panelSysTitulo";
            this.panelSysTitulo.Size = new System.Drawing.Size(189, 54);
            this.panelSysTitulo.TabIndex = 8;
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
            this.label1.Location = new System.Drawing.Point(16, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quantidade de Motoristas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quilometros (KM) Percorridos até o momento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mensal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Anual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Selecione a empresa:";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(189, 70);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(242, 27);
            this.cboEmpresa.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nome da Empresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(365, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quilometros (KM) Percorridos por você nesta empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Anual:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mensal:";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackgroundImage = global::e_LogBook.Properties.Resources.btnPesquisar;
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Location = new System.Drawing.Point(438, 70);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(33, 27);
            this.btnPesquisa.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnPesquisa, "Pesquisar");
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(155, 113);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(133, 19);
            this.lblNomeEmpresa.TabIndex = 22;
            this.lblNomeEmpresa.Text = "Nome da Empresa:";
            this.lblNomeEmpresa.Visible = false;
            // 
            // lblQTDMotoristas
            // 
            this.lblQTDMotoristas.AutoSize = true;
            this.lblQTDMotoristas.Location = new System.Drawing.Point(205, 146);
            this.lblQTDMotoristas.Name = "lblQTDMotoristas";
            this.lblQTDMotoristas.Size = new System.Drawing.Size(183, 19);
            this.lblQTDMotoristas.TabIndex = 23;
            this.lblQTDMotoristas.Text = "Quantidade de Motoristas:";
            this.lblQTDMotoristas.Visible = false;
            // 
            // lblMesEmpresa
            // 
            this.lblMesEmpresa.AutoSize = true;
            this.lblMesEmpresa.Location = new System.Drawing.Point(109, 212);
            this.lblMesEmpresa.Name = "lblMesEmpresa";
            this.lblMesEmpresa.Size = new System.Drawing.Size(17, 19);
            this.lblMesEmpresa.TabIndex = 24;
            this.lblMesEmpresa.Text = "0";
            this.lblMesEmpresa.Visible = false;
            // 
            // lblMensalMotorista
            // 
            this.lblMensalMotorista.AutoSize = true;
            this.lblMensalMotorista.Location = new System.Drawing.Point(109, 285);
            this.lblMensalMotorista.Name = "lblMensalMotorista";
            this.lblMensalMotorista.Size = new System.Drawing.Size(17, 19);
            this.lblMensalMotorista.TabIndex = 25;
            this.lblMensalMotorista.Text = "0";
            this.lblMensalMotorista.Visible = false;
            // 
            // lblAnoEmpresa
            // 
            this.lblAnoEmpresa.AutoSize = true;
            this.lblAnoEmpresa.Location = new System.Drawing.Point(320, 212);
            this.lblAnoEmpresa.Name = "lblAnoEmpresa";
            this.lblAnoEmpresa.Size = new System.Drawing.Size(17, 19);
            this.lblAnoEmpresa.TabIndex = 26;
            this.lblAnoEmpresa.Text = "0";
            this.lblAnoEmpresa.Visible = false;
            // 
            // lblAnoMotorista
            // 
            this.lblAnoMotorista.AutoSize = true;
            this.lblAnoMotorista.Location = new System.Drawing.Point(320, 285);
            this.lblAnoMotorista.Name = "lblAnoMotorista";
            this.lblAnoMotorista.Size = new System.Drawing.Size(17, 19);
            this.lblAnoMotorista.TabIndex = 27;
            this.lblAnoMotorista.Text = "0";
            this.lblAnoMotorista.Visible = false;
            // 
            // FRM_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(522, 330);
            this.ControlBox = false;
            this.Controls.Add(this.lblAnoMotorista);
            this.Controls.Add(this.lblAnoEmpresa);
            this.Controls.Add(this.lblMensalMotorista);
            this.Controls.Add(this.lblMesEmpresa);
            this.Controls.Add(this.lblQTDMotoristas);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelSysTitulo);
            this.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.FRM_Company_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelSysTitulo.ResumeLayout(false);
            this.panelSysTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelSysTitulo;
        private System.Windows.Forms.Label lblSysTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Label lblQTDMotoristas;
        private System.Windows.Forms.Label lblMesEmpresa;
        private System.Windows.Forms.Label lblMensalMotorista;
        private System.Windows.Forms.Label lblAnoEmpresa;
        private System.Windows.Forms.Label lblAnoMotorista;
    }
}