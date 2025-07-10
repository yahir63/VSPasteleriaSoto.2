using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteleriaSoto.DAL.Entities
{
    public class Venta
    {
        public int ID_VENTA { get; set; }
        public int ID_CLIENTE { get; set; }
        public int ID_PEDIDO { get; set; }
        public string? NOMBRECLIENTE { get; set; }

        public DateTime FECHAVENTA { get; set; }
        public double TOTALVENTA { get; set; }
    }
}
