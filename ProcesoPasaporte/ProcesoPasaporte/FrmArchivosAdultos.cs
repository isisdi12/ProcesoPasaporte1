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
    public partial class FrmArchivosAdultos : Form
    {
        public FrmArchivosAdultos()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        

        private void BtnDPI_Click(object sender, EventArgs e)
        {
           if (ofd.ShowDialog()== DialogResult.OK)
            {
                ofd.Filter = "PDF | .pdf " ;
                TxtRutaDPI.Text = ofd.SafeFileName;
            }
        }

        private void FrmArchivos_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnBoletoOrnato_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Filter = "PDF | .pdf ";
                TxtRutaBoletoOrnato.Text = ofd.SafeFileName;
            }
        }

        private void BtnBoletPago_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Filter = "PDF | .pdf ";
                TxtRutaBoletaPago.Text = ofd.SafeFileName;
            }
        }

        Conexion conectar = new Conexion();

        private void PicLogo2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            FrmNuevoPasaporteAdulto principaladmon = new FrmNuevoPasaporteAdulto();
            principaladmon.Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
            string sql = "INSERT INTO documentosaceptados (NoDocumento, Nombre,Cui,Ruta,TipoTramitePasaporte_idTipoTramite) VALUES('" + TxtDPI.Text + "' ,'" + "DPI" + "' ,'" + LblCUI.Text + "' ,'" + TxtRutaDPI.Text + "' ,'" + "1" + "') ";
            OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
            OdbcDataReader read = command.ExecuteReader();

            string sql1 = "INSERT INTO documentosaceptados (NoDocumento, Nombre,Cui,Ruta,TipoTramitePasaporte_idTipoTramite) VALUES('" + TxtBoletoOrnato.Text + "' ,'" + "BOLETO ORNATO" + "' ,'" + LblCUI.Text + "' ,'" + TxtRutaBoletoOrnato.Text + "' ,'" + "1" + "') ";
            OdbcCommand command1 = new OdbcCommand(sql1, conectar.conexion());
            OdbcDataReader read1 = command1.ExecuteReader();

            string sql2 = "INSERT INTO documentosaceptados (NoDocumento, Nombre,Cui,Ruta,TipoTramitePasaporte_idTipoTramite) VALUES('" + TxtBoletadePago.Text + "' ,'" + "BOLETA DE PAGO" + "' ,'" + LblCUI.Text + "' ,'" + TxtRutaBoletaPago.Text + "' ,'" + "1" + "') ";
            OdbcCommand command2 = new OdbcCommand(sql2, conectar.conexion());
            OdbcDataReader read2 = command2.ExecuteReader();

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
