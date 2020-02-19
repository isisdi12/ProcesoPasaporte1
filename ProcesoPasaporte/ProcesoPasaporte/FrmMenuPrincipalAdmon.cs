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
    public partial class FrmMenuPrincipalAdmon : Form
    {
        public FrmMenuPrincipalAdmon()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmMenuAdmon nuevo = new FrmMenuAdmon();
            nuevo.Show();
        }

        private void BtnImpresion_Click(object sender, EventArgs e)
        {
            FrmImpresionPasaporte impresion = new FrmImpresionPasaporte();
            impresion.Show();
        }

        private void BtnRenovacion_Click(object sender, EventArgs e)
        {
            FrmMenuAdmon1 renovacion = new FrmMenuAdmon1();
            renovacion.Show();
        }
    }
}
