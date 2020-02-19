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
    public partial class FrmMenuAdmon : Form
    {
        public FrmMenuAdmon()
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

        private void BtnAdultos_Click(object sender, EventArgs e)
        {
            FrmNuevoPasaporteAdulto pasaporteadulto = new FrmNuevoPasaporteAdulto();
            pasaporteadulto.Show();
        }

        private void BtnMayores_Click(object sender, EventArgs e)
        {
            FrmNuevoPasaporteMayor60 pasaportemayor = new FrmNuevoPasaporteMayor60();
            pasaportemayor.Show();
        }

        private void BtnMenores_Click(object sender, EventArgs e)
        {
            FrmNuevoPasaporteMenor pasaportemenor = new FrmNuevoPasaporteMenor();
            pasaportemenor.Show();
        }

        private void FrmMenuAdmon_Load(object sender, EventArgs e)
        {

        }
    }
}
