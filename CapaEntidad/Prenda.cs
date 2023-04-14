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
        public decimal PrecioCompra { get; set; }
        public int Stock { get; set; }
        public TallaPrenda OIdTallaPrenda { get; set; }
        public ColorPrenda OIdColorPrenda { get; set; }
        public TipoPrenda OIdTipoPrenda { get; set; }
    }
}
