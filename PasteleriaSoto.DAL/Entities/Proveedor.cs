using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteleriaSoto.DAL.Entities
{
    public class Proveedor
    {
        public int ID_PROVEEDOR { get; set; }
        public string NOMBREPROVEEDOR { get; set; }
        public string UBICACION{ get; set; }
        public string TELEFONO { get; set; }
    }
}
