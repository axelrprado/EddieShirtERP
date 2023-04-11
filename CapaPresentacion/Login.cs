using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            // Verificar el login
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.IdUsuario == Convert.ToInt32(txtusuario.Text) &&
            u.Clave == txtclave.Text).FirstOrDefault();

            if (ousuario != null)
            {
                Inicio form = new Inicio();
                form.Show();
                this.Hide();
                //Muestra el formulario de logeo que ocultamos anteriormente
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            txtclave.Text = "";
            this.Show();
        }
    }
}
