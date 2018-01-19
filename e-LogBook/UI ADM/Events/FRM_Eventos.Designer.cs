namespace e_LogBook.UI_ADM
{
    partial class FRM_Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Eventos));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelSysTitulo = new System.Windows.Forms.Panel();
            this.lblSysTitulo = new System.Windows.Forms.Label();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.idEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPontos = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.btnEditarEvento = new System.Windows.Forms.Button();
            this.btnCriarEvento = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.panelSysTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.panelMenu.SuspendLayout();
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
            this.panelTitulo.Size = new System.Drawing.Size(619, 54);
            this.panelTitulo.TabIndex = 9;
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
            this.btnMinimizar.Location = new System.Drawing.Point(536, 12);
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
            this.button1.Location = new System.Drawing.Point(572, 12);
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
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEvento,
            this.nomeEvento,
            this.dataEvento,
            this.criadoPor,
            this.status});
            this.dgvEventos.Location = new System.Drawing.Point(195, 60);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(595, 368);
            this.dgvEventos.TabIndex = 27;
            // 
            // idEvento
            // 
            this.idEvento.DataPropertyName = "idEvento";
            this.idEvento.HeaderText = "ID";
            this.idEvento.Name = "idEvento";
            this.idEvento.ReadOnly = true;
            // 
            // nomeEvento
            // 
            this.nomeEvento.DataPropertyName = "nomeEvento";
            this.nomeEvento.HeaderText = "Descrição";
            this.nomeEvento.Name = "nomeEvento";
            this.nomeEvento.ReadOnly = true;
            // 
            // dataEvento
            // 
            this.dataEvento.DataPropertyName = "dataEvento";
            this.dataEvento.HeaderText = "Data";
            this.dataEvento.Name = "dataEvento";
            this.dataEvento.ReadOnly = true;
            // 
            // criadoPor
            // 
            this.criadoPor.DataPropertyName = "criadoPor";
            this.criadoPor.HeaderText = "Criado Por";
            this.criadoPor.Name = "criadoPor";
            this.criadoPor.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "eStatus";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.btnPontos);
            this.panelMenu.Controls.Add(this.btnAtualizar);
            this.panelMenu.Controls.Add(this.lblTituloMenu);
            this.panelMenu.Controls.Add(this.btnEditarEvento);
            this.panelMenu.Controls.Add(this.btnCriarEvento);
            this.panelMenu.Location = new System.Drawing.Point(0, 54);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(189, 393);
            this.panelMenu.TabIndex = 29;
            // 
            // btnPontos
            // 
            this.btnPontos.BackColor = System.Drawing.Color.Transparent;
            this.btnPontos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPontos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPontos.FlatAppearance.BorderSize = 0;
            this.btnPontos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPontos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPontos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPontos.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.btnPontos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPontos.Location = new System.Drawing.Point(13, 239);
            this.btnPontos.Name = "btnPontos";
            this.btnPontos.Size = new System.Drawing.Size(165, 49);
            this.btnPontos.TabIndex = 6;
            this.btnPontos.Text = "Pontuação";
            this.btnPontos.UseVisualStyleBackColor = false;
            this.btnPontos.Click += new System.EventHandler(this.btnPontos_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizar.Location = new System.Drawing.Point(12, 181);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(165, 49);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblTituloMenu
            // 
            this.lblTituloMenu.AutoSize = true;
            this.lblTituloMenu.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.lblTituloMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloMenu.Location = new System.Drawing.Point(63, 17);
            this.lblTituloMenu.Name = "lblTituloMenu";
            this.lblTituloMenu.Size = new System.Drawing.Size(64, 27);
            this.lblTituloMenu.TabIndex = 1;
            this.lblTituloMenu.Text = "Menu";
            // 
            // btnEditarEvento
            // 
            this.btnEditarEvento.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarEvento.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEvento.FlatAppearance.BorderSize = 0;
            this.btnEditarEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditarEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEvento.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.btnEditarEvento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarEvento.Location = new System.Drawing.Point(12, 124);
            this.btnEditarEvento.Name = "btnEditarEvento";
            this.btnEditarEvento.Size = new System.Drawing.Size(165, 49);
            this.btnEditarEvento.TabIndex = 4;
            this.btnEditarEvento.Text = "Editar";
            this.btnEditarEvento.UseVisualStyleBackColor = false;
            this.btnEditarEvento.Click += new System.EventHandler(this.btnEditarEvento_Click);
            // 
            // btnCriarEvento
            // 
            this.btnCriarEvento.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarEvento.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCriarEvento.FlatAppearance.BorderSize = 0;
            this.btnCriarEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCriarEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCriarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarEvento.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.btnCriarEvento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCriarEvento.Location = new System.Drawing.Point(13, 67);
            this.btnCriarEvento.Name = "btnCriarEvento";
            this.btnCriarEvento.Size = new System.Drawing.Size(165, 49);
            this.btnCriarEvento.TabIndex = 1;
            this.btnCriarEvento.Text = "Novo";
            this.btnCriarEvento.UseVisualStyleBackColor = false;
            this.btnCriarEvento.Click += new System.EventHandler(this.btnCriarEvento_Click);
            // 
            // FRM_Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(802, 436);
            this.ControlBox = false;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelSysTitulo);
            this.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Eventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.FRM_Eventos_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelSysTitulo.ResumeLayout(false);
            this.panelSysTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelSysTitulo;
        private System.Windows.Forms.Label lblSysTitulo;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Button btnEditarEvento;
        private System.Windows.Forms.Button btnCriarEvento;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPontos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn criadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}