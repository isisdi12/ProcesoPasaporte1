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
    public partial class FrmSaludoAdmon : Form
    {
        public FrmSaludoAdmon()
        {
            InitializeComponent();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipalAdmon principaladmon = new FrmMenuPrincipalAdmon();
            principaladmon.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
