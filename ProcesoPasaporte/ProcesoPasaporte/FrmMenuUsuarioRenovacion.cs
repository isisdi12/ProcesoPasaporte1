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
    public partial class FrmMenuUsuarioRenovacion : Form
    {
        public FrmMenuUsuarioRenovacion()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMenores_Click(object sender, EventArgs e)
        {
            FrmArchivosMenores pasaportemenor = new FrmArchivosMenores();
            pasaportemenor.Show();
        }

        private void BtnAdultos_Click(object sender, EventArgs e)
        {
            FrmArchivosAdultos pasaporteadulto = new FrmArchivosAdultos();
            pasaporteadulto.Show();
        }

        private void BtnMayores_Click(object sender, EventArgs e)
        {
            FrmRenovacionMayor60 renovacionmayor = new FrmRenovacionMayor60();
            renovacionmayor.Show();
        }
    }
}
