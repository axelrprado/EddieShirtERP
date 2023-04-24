using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CapaNegocio
{
    public class CN_TipoPrenda
    {
        private CD_TipoPrenda objcd_TipoPrenda = new CD_TipoPrenda();

        public List<TipoPrenda> Listar()
        {
            return objcd_TipoPrenda.Listar();
        }

        public int Registrar(TipoPrenda obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripcion del tipo de prenda \n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_TipoPrenda.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(TipoPrenda obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripcion del tipo de prenda \n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_TipoPrenda.Editar(obj, out Mensaje);
            }

        }


        public bool Eliminar(TipoPrenda obj, out string Mensaje)
        {
            return objcd_TipoPrenda.Eliminar(obj, out Mensaje);
        }
    }
}
