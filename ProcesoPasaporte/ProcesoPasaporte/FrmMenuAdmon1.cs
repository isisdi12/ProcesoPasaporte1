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
    public partial class FrmMenuAdmon1 : Form
    {
        public FrmMenuAdmon1()
        {
            InitializeComponent();
        }

        private void BtnMenores_Click(object sender, EventArgs e)
        {
            FrmRenovacionPasaporteMenor renovacionmenor = new FrmRenovacionPasaporteMenor();
            renovacionmenor.Show();
        }

        private void BtnAdultos_Click(object sender, EventArgs e)
        {
            FrmRenovacionPasaporteAdulto renovacionadulto = new FrmRenovacionPasaporteAdulto();
            renovacionadulto.Show();
        }

        private void BtnMayores_Click(object sender, EventArgs e)
        {
            FrmRenovacionMayor60 renovacionmayor = new FrmRenovacionMayor60();
            renovacionmayor.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
