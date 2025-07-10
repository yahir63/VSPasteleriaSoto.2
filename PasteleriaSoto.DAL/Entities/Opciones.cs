using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteleriaSoto.DAL.Entities
{
    public class Opciones
    {
        public int ID_OPCIONES { get; set; }
        public string NOMBRE_OPCION { get; set; }
        public double PRECIO { get; set; }
        public string UNIDADMEDIDA { get; set; }
        public string DESCRIPCION { get; set; }

        public int CANTIDAD { get; set; }
    }
}
