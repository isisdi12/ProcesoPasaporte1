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
    public partial class FrmLogin : Form
    {
        
       
        public FrmLogin()
        {
            InitializeComponent();
            //FECHA 
            LblFecha.Text = DateTime.Now.ToLongDateString();
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            FrmMenuUsuarioNuevo moviendo = new FrmMenuUsuarioNuevo();
            moviendo.LblCUI.Text = TxtUsuario.Text;
            moviendo.Show();


            if (CboTipoUsuario.Text == "Administrador")
            {
                
                FrmSaludoAdmon saludoadmon = new FrmSaludoAdmon();
                saludoadmon.Show();

            }
            else
            {
                if (CboTipoUsuario.Text == "Usuario")
                {
                    SALUDO saludousuario = new SALUDO();
                    saludousuario.Show();

                }
            }
           
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
