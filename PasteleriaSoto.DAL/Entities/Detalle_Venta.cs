using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteleriaSoto.DAL.Entities
{
    public class Detalle_Venta
    {
        public int ID_DETALLEVENTA { get; set; }
        public int ID_VENTA { get; set; }
        public int ID_PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public double PRECIO_VENTA { get; set; }
        public string? NOMBREPRODUCTO { get; set; }

        public double TOTAL_LINEA { get; set; }
    }
}
