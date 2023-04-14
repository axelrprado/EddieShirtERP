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
        public Venta OIdVenta { get; set; }
        public Prenda OIdPrenda { get; set; }
        public string Descripcion { get; set; }
        public decimal Tinta { get; set; }
        public int Cantidad { get; set; }
        public decimal Comision_ML_25 { get; set; }
        public decimal Comision_ML_15 { get; set; }
        public decimal Comision_TER { get; set; }
    }
}
