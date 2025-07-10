using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteleriaSoto.DAL.Entities
{
    public class ProductoPersonalizado
    {
        public int ID_PERSONALIZADO { get; set; }
        public int ID_CLIENTE { get; set; }
        public int ID_PRODUCTO { get; set; }
        public string? DESCRIPCION { get; set; }
        public double PRECIO_VENTA { get; set; }
   
    }
}
