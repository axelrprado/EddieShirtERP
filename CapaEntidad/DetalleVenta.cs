using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        //LLave foranea de la tabla venta
        public Venta OIdVenta { get; set; }
        public Prenda OIdPrenda { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
