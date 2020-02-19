namespace ProcesoPasaporte
{
    partial class FrmMenuPrincipalAdmon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipalAdmon));
            this.BtnRenovacion = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.PicLogo2 = new System.Windows.Forms.PictureBox();
            this.LblInfo = new System.Windows.Forms.Label();
            this.BtnImpresion = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRenovacion
            // 
            this.BtnRenovacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRenovacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRenovacion.Location = new System.Drawing.Point(341, 374);
            this.BtnRenovacion.Name = "BtnRenovacion";
            this.BtnRenovacion.Size = new System.Drawing.Size(175, 50);
            this.BtnRenovacion.TabIndex = 11;
            this.BtnRenovacion.Text = "RENOVACIÓN PASAPORTE";
            this.BtnRenovacion.UseVisualStyleBackColor = false;
            this.BtnRenovacion.Click += new System.EventHandler(this.BtnRenovacion_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(341, 292);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(175, 50);
            this.BtnNuevo.TabIndex = 10;
            this.BtnNuevo.Text = "NUEVO PASAPORTE";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // PicLogo2
            // 
            this.PicLogo2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PicLogo2.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo2.Image")));
            this.PicLogo2.Location = new System.Drawing.Point(207, 50);
            this.PicLogo2.Name = "PicLogo2";
            this.PicLogo2.Size = new System.Drawing.Size(446, 119);
            this.PicLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicLogo2.TabIndex = 8;
            this.PicLogo2.TabStop = false;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(309, 221);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(251, 23);
            this.LblInfo.TabIndex = 9;
            this.LblInfo.Text = "SELECCIONE UNA OPCIÓN";
            // 
            // BtnImpresion
            // 
            this.BtnImpresion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnImpresion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImpresion.Location = new System.Drawing.Point(341, 459);
            this.BtnImpresion.Name = "BtnImpresion";
            this.BtnImpresion.Size = new System.Drawing.Size(175, 50);
            this.BtnImpresion.TabIndex = 12;
            this.BtnImpresion.Text = "IMPRESIÓN PASAPORTE";
            this.BtnImpresion.UseVisualStyleBackColor = false;
            this.BtnImpresion.Click += new System.EventHandler(this.BtnImpresion_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(12, 568);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(118, 41);
            this.BtnCancelar.TabIndex = 147;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmMenuPrincipalAdmon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 621);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnImpresion);
            this.Controls.Add(this.BtnRenovacion);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.PicLogo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipalAdmon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipalAdmon";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRenovacion;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.PictureBox PicLogo2;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Button BtnImpresion;
        private System.Windows.Forms.Button BtnCancelar;
    }
}