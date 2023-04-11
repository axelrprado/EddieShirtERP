using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Prenda
    {
        public int IdPrenda { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //LLave foranea de la tabla prenda
        public Prenda OTipoPrenda  { get; set; }
        public int IdColorPrenda { get; set; }
        public int Stock { get; set; }
        public decimal PrecioCompra { get; set; }
        
        public decimal PrecioVenta { get; set; }
    }
}
