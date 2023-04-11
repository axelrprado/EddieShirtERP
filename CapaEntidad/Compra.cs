using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        //Revisar tabla
        public int IdCompra { get; set; }
        public Usuario OIdUsuario { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaRegistro {get;set;}
    }
}
