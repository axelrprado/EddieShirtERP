using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUsuarios_Load_1(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in Dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "BtnSeleccionar")
                {
                    CboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
                CboBusqueda.DisplayMember = "Texto";
                CboBusqueda.ValueMember = "Valor";
                //CboBusqueda.SelectedIndex = 0;

            }
        }

        private void limpiar()
        {
            txtId.Text = "0";
            txtNombre.Text = "";
            txtAPaterno.Text = "";
            txtAMaterno.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtConClave.Text = "";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Dgvdata es la lista de usuarios
            Dgvdata.Rows.Add(new object[] {"",txtId.Text,txtNombre.Text,txtAPaterno.Text,txtAMaterno.Text,txtCorreo.Text,txtClave.Text});
            limpiar();
        }

        
    }
}
