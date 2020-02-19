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
    public partial class FrmArchivosMenores : Form
    {
        Conexion conectar = new Conexion();

        public FrmArchivosMenores()
        {
            InitializeComponent();
        }

        private void FrmArchivosMenores_Load(object sender, EventArgs e)
        {

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            FrmNuevoPasaporteMenor principaladmon = new FrmNuevoPasaporteMenor();
            principaladmon.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           string sql  = "INSERT INTO documentosaceptados (NoDocumento, Nombre,Cui,Ruta,TipoTramitePasaporte_idTipoTramite) VALUES('" + TxtDPIM.Text + "' ,'" + "DPI MADRE" + "' ,'" + LblCUI.Text + "' ,'"  + TxtRutaDPIM.Text + "') ";
            OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
            OdbcDataReader read = command.ExecuteReader();

            string sql1 = "INSERT INTO documentosaceptados (NoDocumento, Nombre,Cui,Ruta) VALUES('" + TxtDPIP.Text + "' ,'" + "DPI PADRE" + "' ,'" + LblCUI.Text + "' ,'" + TxtRutaDPIP.Text + "') ";
            OdbcCommand command1 = new OdbcCommand(sql, conectar.conexion());
            OdbcDataReader read1 = command.ExecuteReader();

            string sql2 = "INSERT INTO documentosaceptados (NoDocumento, Nombre,Cui,Ruta) VALUES('" + TxtCartaPoder.Text + "' ,'" + "CARTA DE PODER" + "' ,'" + LblCUI.Text + "' ,'" + TxtRutaCart+ "') ";
            OdbcCommand command2 = new OdbcCommand(sql, conectar.conexion());
            OdbcDataReader read2 = command.ExecuteReader();

            string sql3 = "INSERT INTO documentosaceptados (NoDocumento, Nombre,Cui,Ruta) VALUES('" + TxtCertNaci.Text + "' ,'" + "CERTIFICACION DE NACIMIENTO" + "' ,'" + LblCUI.Text + "' ,'" + TxtRutaCertNacimiento.Text + "') ";
            OdbcCommand command3 = new OdbcCommand(sql, conectar.conexion());
            OdbcDataReader read3 = command.ExecuteReader();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void BtnDPI_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Filter = "PDF | .pdf ";
                TxtDPIM.Text = ofd.SafeFileName;
            }

        }

        private void BtnBoletoOrnato_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Filter = "PDF | .pdf ";
                TxtRutaDPIP.Text = ofd.SafeFileName;
            }
        }

        private void BtnBoletPago_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Filter = "PDF | .pdf ";
                TxtRutaCart.Text = ofd.SafeFileName;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Filter = "PDF | .pdf ";
                TxtCertNaci.Text = ofd.SafeFileName;
            }
        }
    }
}
