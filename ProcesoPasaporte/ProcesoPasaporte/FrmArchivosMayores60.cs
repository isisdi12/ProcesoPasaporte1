using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesoPasaporte
{
    public partial class FrmArchivosMayores60 : Form
    {
        public FrmArchivosMayores60()
        {
            InitializeComponent();
        }

        Conexion conectar = new Conexion();

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            FrmNuevoPasaporteMayor60 principaladmon = new FrmNuevoPasaporteMayor60();
            principaladmon.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO documentosaceptados (NoDocumento, Nombre,Cui,Ruta) VALUES('" + TxtDPI.Text + "' ,'" + "DPI" + "' ,'" + LblCUI.Text + "' ,'" + TxtRutaDPI.Text + "') ";
            OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
            OdbcDataReader read = command.ExecuteReader();

            string sql1 = "INSERT INTO documentosaceptados (NoDocumento, Nombre,Cui,Ruta) VALUES('" + TxtRutaBoletaPago.Text + "' ,'" + "BOLETO ORNATO" + "' ,'" + LblCUI.Text + "' ,'" + TxtRutaBoletaPago.Text + "') ";
            OdbcCommand command1 = new OdbcCommand(sql, conectar.conexion());
            OdbcDataReader read1 = command.ExecuteReader();

           

        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void BtnDPI_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Filter = "PDF | .pdf ";
                TxtDPI.Text = ofd.SafeFileName;
            }
        }

        private void BtnBoletoOrnato_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Filter = "PDF | .pdf ";
                TxtRutaBoletaPago.Text = ofd.SafeFileName;
            }
        }
    }
}
