using System;
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
    public partial class FrmNuevo_Renovacion : Form
    {
        public FrmNuevo_Renovacion()
        {
            InitializeComponent();
        }

        private void LblInfo_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMenores_Click(object sender, EventArgs e)
        {
            FrmMenuUsuarioRenovacion renovar = new FrmMenuUsuarioRenovacion();
            renovar.Show();
        }

        private void BtnAdultos_Click(object sender, EventArgs e)
        {
            FrmMenuUsuarioNuevo nuevousuario = new FrmMenuUsuarioNuevo();
            nuevousuario.Show();
        }
    }
}
