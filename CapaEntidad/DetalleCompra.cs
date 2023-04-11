using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        //LLave foranea de la tabla compra
        public Compra OIdCompra { get; set; }
        public Prenda OIdPrenda { get; set; }
        public decimal PrecioCompra { get; set; }

        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
