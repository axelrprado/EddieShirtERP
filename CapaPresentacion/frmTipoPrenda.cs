using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using System.Windows.Shapes;

namespace CapaPresentacion
{
    public partial class frmTipoPrenda : Form
    {
        public frmTipoPrenda()
        {
            InitializeComponent();
        }

        private void frmTipoPrenda_Load(object sender, EventArgs e)
        {
            //cbo.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            //cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            //cboestado.DisplayMember = "Texto";
            //cboestado.ValueMember = "Valor";
            //cboestado.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in Dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "BtnSeleccionar")
                {
                    CboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
                CboBusqueda.DisplayMember = "Texto";
                CboBusqueda.ValueMember = "Valor";
                //CboBusqueda.SelectedIndex = 0;


                //Mostrar todos los usuarios

                Dgvdata.Rows.Clear();

                //Mostrar todos los usuarios
                List<TipoPrenda> lista = new CN_TipoPrenda().Listar();
                for (int i = 0; i < lista.Count; i++)
                {
                    TipoPrenda item = lista[i];
                    Dgvdata.Rows.Add(new object[] { "", item.IdTipoPrenda, item.Descripcion });
                }

                //List<TipoPrenda> lista = new CN_TipoPrenda().Listar();
                //foreach (TipoPrenda item in lista)
                //{
                    
                //    Dgvdata.Rows.Add(new object[] { "", item.IdTipoPrenda, item.Descripcion });
                //}
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            TipoPrenda obj = new TipoPrenda()
            {
                IdTipoPrenda = Convert.ToInt32(txtId.Text),
                Descripcion = txtDescripcion.Text
            };

            if (obj.IdTipoPrenda == 0)
            {
                int idgenerado = new CN_TipoPrenda().Registrar(obj, out mensaje);
                if (idgenerado != 0)
                {
                    Dgvdata.Rows.Add(new object[] { "", idgenerado, txtDescripcion.Text });
                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            //else
            //{
            //    bool resultado = new CN_TipoPrenda().Editar(obj, out mensaje);

            //    if (resultado)
            //    {
            //        DataGridViewRow row = Dgvdata.Rows[Convert.ToInt32(txtIndice.Text)]; 
            //        row.Cells["Id"].Value = txtId.Text;
            //        row.Cells["Descripcion"].Value = txtDescripcion.Text;
            //        limpiar();
            //    }
            //    else
            //    {
            //        MessageBox.Show(mensaje);
            //    }
            //}
        }


        private void limpiar()
        {
            txtIndice.Text = "0";
            txtId.Text = "0";
            txtDescripcion.Text = "";
            txtDescripcion.Select();
        }

        //private void dgvdata_cellpainting(object sender, datagridviewcellpaintingeventargs e)
        //{
        //    if (e.rowindex < 0)
        //        return;

        //    if (e.columnindex == 0)
        //    {
        //        //revisar checks
        //        e.paint(e.cellbounds, datagridviewpaintparts.all);
        //        var w = properties.resources.check20.width;
        //        var h = properties.resources.check20.height;
        //        var x = e.cellbounds.left + (e.cellbounds.width - w) / 2;
        //        var y = e.cellbounds.left + (e.cellbounds.height - w) / 2;

        //        e.graphics.drawimage(properties.resources.check20, new rectangle(x, y, w, h));
        //        e.handled = true;
        //    }
        //}

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if(MessageBox.Show("Desea eliminar el tipo de prenda","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    TipoPrenda obj = new TipoPrenda()
                    {
                        IdTipoPrenda = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CN_TipoPrenda().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        Dgvdata.Rows.RemoveAt((Convert.ToInt32(txtIndice.Text)));
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                    }
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CboBusqueda.SelectedItem).Valor.ToString();
            
            if (Dgvdata.Rows.Count < 0)
            {
                foreach (DataGridViewRow row in Dgvdata.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in Dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        //private void Dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    if (e.RowIndex < 0)
        //        return;

        //    if (e.ColumnIndex == 0)
        //    {
        //        //revisar checks
        //        e.Paint(e.CellBounds, DataGridViewPaintParts.All);
        //        var w = Properties.Resources.check20.Width;
        //        var h = Properties.Resources.check20.Height;
        //        var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
        //        var y = e.CellBounds.Left + (e.CellBounds.Height - w) / 2;

        //        e.Graphics.DrawImage(Properties.Resources.check20, new System.Drawing.Rectangle(x, y, w, h));
        //        e.Handled = true;
        //    }
        //}

        private void Dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgvdata.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int indice = e.RowIndex;

                if(indice >= 0) 
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = Dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtDescripcion.Text = Dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();
                }
            } 
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            TipoPrenda obj = new TipoPrenda()
            {
                IdTipoPrenda = Convert.ToInt32(txtId.Text),
                Descripcion = txtDescripcion.Text
            };
            bool resultado = new CN_TipoPrenda().Editar(obj, out mensaje);

            if (resultado)
            {
                DataGridViewRow row = Dgvdata.Rows[Convert.ToInt32(txtIndice.Text)];
                row.Cells["Id"].Value = txtId.Text;
                row.Cells["Descripcion"].Value = txtDescripcion.Text;
                limpiar();
            }

            else
            {
                MessageBox.Show(mensaje);
            }
        }
    }

}

