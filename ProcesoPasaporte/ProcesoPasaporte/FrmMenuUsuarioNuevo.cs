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
    

    public partial class FrmMenuUsuarioNuevo : Form
    {
        public FrmMenuUsuarioNuevo()
        {
            InitializeComponent();
           
           

        }

        Conexion conectar = new Conexion();
        
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMenores_Click(object sender, EventArgs e)
        {
            string fecha;
            fecha = DateTime.Now.ToString("yyyy-MM-dd");

            FrmArchivosMenores pasaportemenor = new FrmArchivosMenores();
            pasaportemenor.Show();


            string sql = "INSERT INTO tipotramitepasaporte(TipoTramite,Cui ,fecha) VALUES('"+ "MENORES" + "' ,'" + LblCUI.Text + "' ,'" + fecha.ToString() + "')";
            OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
            OdbcDataReader read = command.ExecuteReader();

        }

        private void BtnAdultos_Click(object sender, EventArgs e)
        {
            string fecha2;
            fecha2 = DateTime.Now.ToString("yyyy-MM-dd");

            string sql = "INSERT INTO tipotramitepasaporte(TipoTramite,Cui ,fecha) VALUES('" + "ADULTOS" + "' ,'" + LblCUI.Text + "' ,'" + fecha2.ToString() +  "')";
            OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
            OdbcDataReader read = command.ExecuteReader();


            FrmArchivosAdultos pasaporteadulto = new FrmArchivosAdultos();
            pasaporteadulto.Show();
        }

        private void BtnMayores_Click(object sender, EventArgs e)
        {
            string fecha1;
            fecha1 = DateTime.Now.ToString("yyyy-MM-dd");


            string sql = "INSERT INTO tipotramitepasaporte(TipoTramite,Cui ,fecha) VALUES('" + "MAYORES DE 60" + "' ,'" + LblCUI.Text + "' ,'" + fecha1.ToString() + "')";
            OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
            OdbcDataReader read = command.ExecuteReader();


            FrmNuevoPasaporteMayor60 pasaportemayor = new FrmNuevoPasaporteMayor60();
            pasaportemayor.Show();
        }
    }
}
