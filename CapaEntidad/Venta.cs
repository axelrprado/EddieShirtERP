using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        //Revisar campos
        public int IdVenta { get; set; }
        //LLave foranea de la tabla usuario
        public Usuario OIdUsuario { get; set; }
        public Cliente OIdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string APaternoCliente { get; set; }
        public string AMaternoCliente { get; set; }

        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
