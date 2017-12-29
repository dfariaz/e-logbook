namespace e_LogBook.UI_USER.LogBook
{
    partial class FRM_LogBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LogBook));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelSysTitulo = new System.Windows.Forms.Panel();
            this.lblSysTitulo = new System.Windows.Forms.Label();
            this.panelVelocidade = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TimerAvisoSonoro = new System.Windows.Forms.Timer(this.components);
            this.lblPartida = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.PicCarga = new System.Windows.Forms.PictureBox();
            this.img_EmpresaDestino = new System.Windows.Forms.PictureBox();
            this.img_EmpresaPartida = new System.Windows.Forms.PictureBox();
            this.lblVelDis = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.panelSysTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_EmpresaDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_EmpresaPartida)).BeginInit();
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
            this.panelTitulo.Size = new System.Drawing.Size(630, 54);
            this.panelTitulo.TabIndex = 7;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_LogBook_MouseDown);
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FRM_LogBook_MouseMove);
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
            this.btnMinimizar.Location = new System.Drawing.Point(550, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 5;
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
            this.button1.Location = new System.Drawing.Point(587, 12);
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
            this.lblTitulo.Size = new System.Drawing.Size(200, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "LogBook Eletrônico";
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
            // panelVelocidade
            // 
            this.panelVelocidade.BackColor = System.Drawing.Color.Black;
            this.panelVelocidade.Location = new System.Drawing.Point(20, 250);
            this.panelVelocidade.Name = "panelVelocidade";
            this.panelVelocidade.Size = new System.Drawing.Size(320, 3);
            this.panelVelocidade.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(77, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 3);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(458, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 3);
            this.panel2.TabIndex = 20;
            // 
            // TimerAvisoSonoro
            // 
            this.TimerAvisoSonoro.Enabled = true;
            this.TimerAvisoSonoro.Interval = 2000;
            this.TimerAvisoSonoro.Tick += new System.EventHandler(this.TimerAvisoSonoro_Tick);
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.lblPartida.Location = new System.Drawing.Point(128, 122);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(74, 27);
            this.lblPartida.TabIndex = 23;
            this.lblPartida.Text = "Partida";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.lblDestino.Location = new System.Drawing.Point(509, 122);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(79, 27);
            this.lblDestino.TabIndex = 24;
            this.lblDestino.Text = "Destino";
            // 
            // PicCarga
            // 
            this.PicCarga.BackColor = System.Drawing.Color.Transparent;
            this.PicCarga.Image = global::e_LogBook.Properties.Resources.Descarregado;
            this.PicCarga.Location = new System.Drawing.Point(458, 183);
            this.PicCarga.Name = "PicCarga";
            this.PicCarga.Size = new System.Drawing.Size(320, 70);
            this.PicCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCarga.TabIndex = 22;
            this.PicCarga.TabStop = false;
            // 
            // img_EmpresaDestino
            // 
            this.img_EmpresaDestino.BackColor = System.Drawing.Color.Transparent;
            this.img_EmpresaDestino.Location = new System.Drawing.Point(401, 68);
            this.img_EmpresaDestino.Name = "img_EmpresaDestino";
            this.img_EmpresaDestino.Size = new System.Drawing.Size(102, 81);
            this.img_EmpresaDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_EmpresaDestino.TabIndex = 21;
            this.img_EmpresaDestino.TabStop = false;
            // 
            // img_EmpresaPartida
            // 
            this.img_EmpresaPartida.BackColor = System.Drawing.Color.Transparent;
            this.img_EmpresaPartida.Location = new System.Drawing.Point(20, 74);
            this.img_EmpresaPartida.Name = "img_EmpresaPartida";
            this.img_EmpresaPartida.Size = new System.Drawing.Size(102, 75);
            this.img_EmpresaPartida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_EmpresaPartida.TabIndex = 19;
            this.img_EmpresaPartida.TabStop = false;
            // 
            // lblVelDis
            // 
            this.lblVelDis.AutoSize = true;
            this.lblVelDis.Location = new System.Drawing.Point(24, 221);
            this.lblVelDis.Name = "lblVelDis";
            this.lblVelDis.Size = new System.Drawing.Size(156, 19);
            this.lblVelDis.TabIndex = 25;
            this.lblVelDis.Text = "Velocidade e Distância";
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Location = new System.Drawing.Point(478, 277);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(147, 47);
            this.btnIniciar.TabIndex = 26;
            this.btnIniciar.Text = "Iniciar LogBook";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnParar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Location = new System.Drawing.Point(631, 277);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(147, 47);
            this.btnParar.TabIndex = 27;
            this.btnParar.Text = "Parar LogBook";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // FRM_LogBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(818, 336);
            this.ControlBox = false;
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblVelDis);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblPartida);
            this.Controls.Add(this.PicCarga);
            this.Controls.Add(this.img_EmpresaDestino);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.img_EmpresaPartida);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelVelocidade);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelSysTitulo);
            this.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_LogBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogBook";
            this.Load += new System.EventHandler(this.FRM_LogBook_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_LogBook_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FRM_LogBook_MouseMove);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelSysTitulo.ResumeLayout(false);
            this.panelSysTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_EmpresaDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_EmpresaPartida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelSysTitulo;
        private System.Windows.Forms.Label lblSysTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel panelVelocidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox img_EmpresaPartida;
        private System.Windows.Forms.PictureBox img_EmpresaDestino;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PicCarga;
        private System.Windows.Forms.Timer TimerAvisoSonoro;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblVelDis;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnParar;
    }
}