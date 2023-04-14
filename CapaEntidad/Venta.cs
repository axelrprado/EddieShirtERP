using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int IdVenta { get; set; }
        //LLave foranea de la tabla usuario
        public Usuario OIdUsuario { get; set; }
        public Cliente OIdCliente { get; set; }
        
        public decimal IVA { get; set; }
        public decimal ISR { get; set; }
        public decimal Subtotal { get; set; }

        public decimal GastosOperacion { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public decimal Ganancia { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
