namespace ProcesoPasaporte
{
    partial class FrmArchivosAdultos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArchivosAdultos));
            this.LblInfo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PicLogo2 = new System.Windows.Forms.PictureBox();
            this.BtnDPI = new System.Windows.Forms.Button();
            this.BtnBoletoOrnato = new System.Windows.Forms.Button();
            this.BtnBoletPago = new System.Windows.Forms.Button();
            this.TxtRutaDPI = new System.Windows.Forms.TextBox();
            this.TxtRutaBoletoOrnato = new System.Windows.Forms.TextBox();
            this.TxtRutaBoletaPago = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtBoletadePago = new System.Windows.Forms.TextBox();
            this.TxtBoletoOrnato = new System.Windows.Forms.TextBox();
            this.TxtDPI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.PicDudas = new System.Windows.Forms.PictureBox();
            this.LblCUI = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDudas)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(248, 169);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(370, 46);
            this.LblInfo.TabIndex = 2;
            this.LblInfo.Text = "SELECCIONE LOS SIGUIENTES ARCHIVOS\r\nE INGRESE LOS SIGUIENTES DATOS\r\n";
            this.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // PicLogo2
            // 
            this.PicLogo2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PicLogo2.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo2.Image")));
            this.PicLogo2.Location = new System.Drawing.Point(207, 37);
            this.PicLogo2.Name = "PicLogo2";
            this.PicLogo2.Size = new System.Drawing.Size(450, 95);
            this.PicLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicLogo2.TabIndex = 7;
            this.PicLogo2.TabStop = false;
            this.PicLogo2.Click += new System.EventHandler(this.PicLogo2_Click);
            // 
            // BtnDPI
            // 
            this.BtnDPI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDPI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDPI.Location = new System.Drawing.Point(206, 256);
            this.BtnDPI.Name = "BtnDPI";
            this.BtnDPI.Size = new System.Drawing.Size(174, 50);
            this.BtnDPI.TabIndex = 8;
            this.BtnDPI.Text = "DPI";
            this.BtnDPI.UseVisualStyleBackColor = false;
            this.BtnDPI.Click += new System.EventHandler(this.BtnDPI_Click);
            // 
            // BtnBoletoOrnato
            // 
            this.BtnBoletoOrnato.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBoletoOrnato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBoletoOrnato.Location = new System.Drawing.Point(207, 340);
            this.BtnBoletoOrnato.Name = "BtnBoletoOrnato";
            this.BtnBoletoOrnato.Size = new System.Drawing.Size(173, 51);
            this.BtnBoletoOrnato.TabIndex = 9;
            this.BtnBoletoOrnato.Text = "BOLETO DE ORNATO";
            this.BtnBoletoOrnato.UseVisualStyleBackColor = false;
            this.BtnBoletoOrnato.Click += new System.EventHandler(this.BtnBoletoOrnato_Click);
            // 
            // BtnBoletPago
            // 
            this.BtnBoletPago.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBoletPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBoletPago.Location = new System.Drawing.Point(205, 441);
            this.BtnBoletPago.Name = "BtnBoletPago";
            this.BtnBoletPago.Size = new System.Drawing.Size(175, 46);
            this.BtnBoletPago.TabIndex = 10;
            this.BtnBoletPago.Text = "BOLETA DE PAGO";
            this.BtnBoletPago.UseVisualStyleBackColor = false;
            this.BtnBoletPago.Click += new System.EventHandler(this.BtnBoletPago_Click);
            // 
            // TxtRutaDPI
            // 
            this.TxtRutaDPI.Location = new System.Drawing.Point(480, 286);
            this.TxtRutaDPI.Name = "TxtRutaDPI";
            this.TxtRutaDPI.Size = new System.Drawing.Size(201, 20);
            this.TxtRutaDPI.TabIndex = 11;
            // 
            // TxtRutaBoletoOrnato
            // 
            this.TxtRutaBoletoOrnato.Location = new System.Drawing.Point(480, 371);
            this.TxtRutaBoletoOrnato.Name = "TxtRutaBoletoOrnato";
            this.TxtRutaBoletoOrnato.Size = new System.Drawing.Size(201, 20);
            this.TxtRutaBoletoOrnato.TabIndex = 12;
            // 
            // TxtRutaBoletaPago
            // 
            this.TxtRutaBoletaPago.Location = new System.Drawing.Point(480, 467);
            this.TxtRutaBoletaPago.Name = "TxtRutaBoletaPago";
            this.TxtRutaBoletaPago.Size = new System.Drawing.Size(201, 20);
            this.TxtRutaBoletaPago.TabIndex = 13;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(63, 545);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(144, 41);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(236, 545);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(144, 41);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtBoletadePago
            // 
            this.TxtBoletadePago.Location = new System.Drawing.Point(480, 441);
            this.TxtBoletadePago.Name = "TxtBoletadePago";
            this.TxtBoletadePago.Size = new System.Drawing.Size(201, 20);
            this.TxtBoletadePago.TabIndex = 16;
            // 
            // TxtBoletoOrnato
            // 
            this.TxtBoletoOrnato.Location = new System.Drawing.Point(480, 345);
            this.TxtBoletoOrnato.Name = "TxtBoletoOrnato";
            this.TxtBoletoOrnato.Size = new System.Drawing.Size(201, 20);
            this.TxtBoletoOrnato.TabIndex = 17;
            // 
            // TxtDPI
            // 
            this.TxtDPI.Location = new System.Drawing.Point(480, 260);
            this.TxtDPI.Name = "TxtDPI";
            this.TxtDPI.Size = new System.Drawing.Size(201, 20);
            this.TxtDPI.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "RUTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "RUTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "RUTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "NO.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "NO.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "NO.";
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSiguiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguiente.Location = new System.Drawing.Point(741, 545);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(129, 41);
            this.BtnSiguiente.TabIndex = 151;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = false;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // PicDudas
            // 
            this.PicDudas.Image = ((System.Drawing.Image)(resources.GetObject("PicDudas.Image")));
            this.PicDudas.Location = new System.Drawing.Point(865, 12);
            this.PicDudas.Name = "PicDudas";
            this.PicDudas.Size = new System.Drawing.Size(47, 46);
            this.PicDudas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDudas.TabIndex = 152;
            this.PicDudas.TabStop = false;
            this.PicDudas.Tag = "";
            // 
            // LblCUI
            // 
            this.LblCUI.AutoSize = true;
            this.LblCUI.Location = new System.Drawing.Point(24, 31);
            this.LblCUI.Name = "LblCUI";
            this.LblCUI.Size = new System.Drawing.Size(0, 13);
            this.LblCUI.TabIndex = 153;
            this.LblCUI.Visible = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // FrmArchivosAdultos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 624);
            this.Controls.Add(this.LblCUI);
            this.Controls.Add(this.PicDudas);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDPI);
            this.Controls.Add(this.TxtBoletoOrnato);
            this.Controls.Add(this.TxtBoletadePago);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtRutaBoletaPago);
            this.Controls.Add(this.TxtRutaBoletoOrnato);
            this.Controls.Add(this.TxtRutaDPI);
            this.Controls.Add(this.BtnBoletPago);
            this.Controls.Add(this.BtnBoletoOrnato);
            this.Controls.Add(this.BtnDPI);
            this.Controls.Add(this.PicLogo2);
            this.Controls.Add(this.LblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmArchivosAdultos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.FrmArchivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PicLogo2;
        private System.Windows.Forms.Button BtnDPI;
        private System.Windows.Forms.Button BtnBoletoOrnato;
        private System.Windows.Forms.Button BtnBoletPago;
        private System.Windows.Forms.TextBox TxtRutaDPI;
        private System.Windows.Forms.TextBox TxtRutaBoletoOrnato;
        private System.Windows.Forms.TextBox TxtRutaBoletaPago;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtBoletadePago;
        private System.Windows.Forms.TextBox TxtBoletoOrnato;
        private System.Windows.Forms.TextBox TxtDPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.PictureBox PicDudas;
        public System.Windows.Forms.Label LblCUI;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
    }
}