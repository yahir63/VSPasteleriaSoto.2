using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteleriaSoto.DAL.Entities
{
    public class Opcion
    {
        public int ID_OPCION { get; set; }
        public string? NOMBRE { get; set; }
        public float PRECIO { get; set; }
        public int UNIDADMEDIDA { get; set; }
    }
}
