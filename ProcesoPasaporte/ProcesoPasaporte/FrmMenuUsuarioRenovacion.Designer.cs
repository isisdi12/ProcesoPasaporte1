namespace ProcesoPasaporte
{
    partial class FrmMenuUsuarioRenovacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuUsuarioRenovacion));
            this.PicLogo2 = new System.Windows.Forms.PictureBox();
            this.LblInfo = new System.Windows.Forms.Label();
            this.BtnMenores = new System.Windows.Forms.Button();
            this.BtnAdultos = new System.Windows.Forms.Button();
            this.BtnMayores = new System.Windows.Forms.Button();
            this.PicDudas = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDudas)).BeginInit();
            this.SuspendLayout();
            // 
            // PicLogo2
            // 
            this.PicLogo2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PicLogo2.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo2.Image")));
            this.PicLogo2.Location = new System.Drawing.Point(174, 70);
            this.PicLogo2.Name = "PicLogo2";
            this.PicLogo2.Size = new System.Drawing.Size(465, 132);
            this.PicLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicLogo2.TabIndex = 0;
            this.PicLogo2.TabStop = false;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(292, 229);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(231, 23);
            this.LblInfo.TabIndex = 1;
            this.LblInfo.Text = "PASAPORTE A SOLICITAR";
            // 
            // BtnMenores
            // 
            this.BtnMenores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMenores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenores.Location = new System.Drawing.Point(322, 286);
            this.BtnMenores.Name = "BtnMenores";
            this.BtnMenores.Size = new System.Drawing.Size(175, 50);
            this.BtnMenores.TabIndex = 2;
            this.BtnMenores.Text = "MENOR DE EDAD";
            this.BtnMenores.UseVisualStyleBackColor = false;
            this.BtnMenores.Click += new System.EventHandler(this.BtnMenores_Click);
            // 
            // BtnAdultos
            // 
            this.BtnAdultos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAdultos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdultos.Location = new System.Drawing.Point(322, 368);
            this.BtnAdultos.Name = "BtnAdultos";
            this.BtnAdultos.Size = new System.Drawing.Size(175, 50);
            this.BtnAdultos.TabIndex = 3;
            this.BtnAdultos.Text = "ADULTOS";
            this.BtnAdultos.UseVisualStyleBackColor = false;
            this.BtnAdultos.Click += new System.EventHandler(this.BtnAdultos_Click);
            // 
            // BtnMayores
            // 
            this.BtnMayores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMayores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMayores.Location = new System.Drawing.Point(322, 447);
            this.BtnMayores.Name = "BtnMayores";
            this.BtnMayores.Size = new System.Drawing.Size(175, 50);
            this.BtnMayores.TabIndex = 4;
            this.BtnMayores.Text = "MAYORES DE 60 AÑOS";
            this.BtnMayores.UseVisualStyleBackColor = false;
            this.BtnMayores.Click += new System.EventHandler(this.BtnMayores_Click);
            // 
            // PicDudas
            // 
            this.PicDudas.Image = ((System.Drawing.Image)(resources.GetObject("PicDudas.Image")));
            this.PicDudas.Location = new System.Drawing.Point(865, 12);
            this.PicDudas.Name = "PicDudas";
            this.PicDudas.Size = new System.Drawing.Size(47, 46);
            this.PicDudas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDudas.TabIndex = 5;
            this.PicDudas.TabStop = false;
            this.PicDudas.Tag = "";
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
            // FrmMenuUsuarioRenovacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(924, 624);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.PicDudas);
            this.Controls.Add(this.BtnMayores);
            this.Controls.Add(this.BtnAdultos);
            this.Controls.Add(this.BtnMenores);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.PicLogo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuUsuarioRenovacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "]";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogo2;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Button BtnMenores;
        private System.Windows.Forms.Button BtnAdultos;
        private System.Windows.Forms.Button BtnMayores;
        private System.Windows.Forms.PictureBox PicDudas;
        private System.Windows.Forms.Button BtnCancelar;
    }
}