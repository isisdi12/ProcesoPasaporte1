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
    public partial class SALUDO : Form
    {
        public SALUDO()
        {
            InitializeComponent();
        }

        private void SALUDO_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LblSaludo_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
          
            FrmNuevo_Renovacion nuevorenovacion = new FrmNuevo_Renovacion();
            nuevorenovacion.Show();
        }
    }
}
