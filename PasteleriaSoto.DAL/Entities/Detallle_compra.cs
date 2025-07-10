using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteleriaSoto.DAL.Entities
{
    public class Detallle_compra
    {
        public int ID_DETALLECOMPRA { get; set; }
        public int ID_COMPRA { get; set; }
        public int ID_PRODUCTO { get; set; }
        public string? NOMBREPRODUCTO { get; set; }
        public double PRECIOCOMPRA { get; set; }
        public double PRECIOVENTA{ get; set; }
        public int CANTIDAD { get; set; }
        public double TOTAL { get; set; }


    }
}
