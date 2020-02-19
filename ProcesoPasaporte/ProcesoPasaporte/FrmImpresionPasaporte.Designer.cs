namespace ProcesoPasaporte
{
    partial class FrmImpresionPasaporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpresionPasaporte));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.TxtNoPasaporte = new System.Windows.Forms.TextBox();
            this.PicLogo2 = new System.Windows.Forms.PictureBox();
            this.LblInfo = new System.Windows.Forms.Label();
            this.LblNoPasaporte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(434, 422);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(144, 41);
            this.BtnCancelar.TabIndex = 21;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnImprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(278, 422);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(144, 41);
            this.BtnImprimir.TabIndex = 20;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // TxtNoPasaporte
            // 
            this.TxtNoPasaporte.Location = new System.Drawing.Point(396, 328);
            this.TxtNoPasaporte.Name = "TxtNoPasaporte";
            this.TxtNoPasaporte.Size = new System.Drawing.Size(247, 20);
            this.TxtNoPasaporte.TabIndex = 19;
            // 
            // PicLogo2
            // 
            this.PicLogo2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PicLogo2.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo2.Image")));
            this.PicLogo2.Location = new System.Drawing.Point(202, 106);
            this.PicLogo2.Name = "PicLogo2";
            this.PicLogo2.Size = new System.Drawing.Size(450, 95);
            this.PicLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicLogo2.TabIndex = 17;
            this.PicLogo2.TabStop = false;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(302, 247);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(247, 23);
            this.LblInfo.TabIndex = 16;
            this.LblInfo.Text = "IMPRESIÓN DE PASAPORTE";
            // 
            // LblNoPasaporte
            // 
            this.LblNoPasaporte.AutoSize = true;
            this.LblNoPasaporte.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoPasaporte.Location = new System.Drawing.Point(207, 328);
            this.LblNoPasaporte.Name = "LblNoPasaporte";
            this.LblNoPasaporte.Size = new System.Drawing.Size(170, 22);
            this.LblNoPasaporte.TabIndex = 22;
            this.LblNoPasaporte.Text = "No. de Pasaporte";
            // 
            // FrmImpresionPasaporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 621);
            this.Controls.Add(this.LblNoPasaporte);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.TxtNoPasaporte);
            this.Controls.Add(this.PicLogo2);
            this.Controls.Add(this.LblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmImpresionPasaporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImpresionPasaporte";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.TextBox TxtNoPasaporte;
        private System.Windows.Forms.PictureBox PicLogo2;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label LblNoPasaporte;
    }
}