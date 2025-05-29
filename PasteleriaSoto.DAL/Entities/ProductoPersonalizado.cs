using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteleriaSoto.DAL.Entities
{
    public class ProductoPersonalizado
    {
        public int ID_PERSONALIZAD0 { get; set; }
        public string? DESCRIPCION { get; set; }
        public float PRECIO_VENTA { get; set; }
        public decimal VOLUMEN { get; set; }
        public int UNIDADEMEDIDA { get; set; }
    }
}
