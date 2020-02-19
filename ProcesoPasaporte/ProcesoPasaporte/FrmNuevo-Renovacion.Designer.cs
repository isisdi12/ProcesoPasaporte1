namespace ProcesoPasaporte
{
    partial class FrmNuevo_Renovacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevo_Renovacion));
            this.BtnAdultos = new System.Windows.Forms.Button();
            this.BtnMenores = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.PicLogo2 = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdultos
            // 
            this.BtnAdultos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAdultos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdultos.Location = new System.Drawing.Point(337, 401);
            this.BtnAdultos.Name = "BtnAdultos";
            this.BtnAdultos.Size = new System.Drawing.Size(175, 50);
            this.BtnAdultos.TabIndex = 18;
            this.BtnAdultos.Text = "NUEVO";
            this.BtnAdultos.UseVisualStyleBackColor = false;
            this.BtnAdultos.Click += new System.EventHandler(this.BtnAdultos_Click);
            // 
            // BtnMenores
            // 
            this.BtnMenores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMenores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenores.Location = new System.Drawing.Point(337, 329);
            this.BtnMenores.Name = "BtnMenores";
            this.BtnMenores.Size = new System.Drawing.Size(175, 50);
            this.BtnMenores.TabIndex = 17;
            this.BtnMenores.Text = "RENOVACION";
            this.BtnMenores.UseVisualStyleBackColor = false;
            this.BtnMenores.Click += new System.EventHandler(this.BtnMenores_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(315, 263);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(226, 23);
            this.LblInfo.TabIndex = 16;
            this.LblInfo.Text = "¿QUÉ DESEA TRAMITAR?";
            this.LblInfo.Click += new System.EventHandler(this.LblInfo_Click);
            // 
            // PicLogo2
            // 
            this.PicLogo2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PicLogo2.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo2.Image")));
            this.PicLogo2.Location = new System.Drawing.Point(281, 113);
            this.PicLogo2.Name = "PicLogo2";
            this.PicLogo2.Size = new System.Drawing.Size(300, 99);
            this.PicLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicLogo2.TabIndex = 15;
            this.PicLogo2.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(12, 568);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(118, 41);
            this.BtnCancelar.TabIndex = 151;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmNuevo_Renovacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 621);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAdultos);
            this.Controls.Add(this.BtnMenores);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.PicLogo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevo_Renovacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevo_Renovacion";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAdultos;
        private System.Windows.Forms.Button BtnMenores;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.PictureBox PicLogo2;
        private System.Windows.Forms.Button BtnCancelar;
    }
}