using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public Usuario OIdUsuario { get; set; }
        public string Proveedor { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
