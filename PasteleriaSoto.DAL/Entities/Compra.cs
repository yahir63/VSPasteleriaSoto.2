using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteleriaSoto.DAL.Entities
{
    public class Compra

    {
        public int ID_COMPRA { get; set; }
        public int ID_PROVEEDOR { get; set; }
        public DateTime FECHA_COMPRA { get; set; }

        public string? NUMEROFACTURA { get; set; }
        public double TOTAL { get; set; }



    }
}
