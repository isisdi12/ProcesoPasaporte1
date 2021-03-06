﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesoPasaporte
{
    public partial class FrmTipodeArchivoRenovacion : Form
    {
        public FrmTipodeArchivoRenovacion()
        {
            InitializeComponent();
        }

        private void BtnMenores_Click(object sender, EventArgs e)
        {
            FrmArchivosAdultos archivos = new FrmArchivosAdultos();
            archivos.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAdultos_Click(object sender, EventArgs e)
        {
            FrmMenuUsuarioRenovacion renovacion = new FrmMenuUsuarioRenovacion();
            renovacion.Show();
        }
    }
}
