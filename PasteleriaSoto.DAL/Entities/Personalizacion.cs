using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteleriaSoto.DAL.Entities
{
    public class Personalizacion
    {
        public int ID_PERSONALIZACION { get; set; }
        public int ID_PRODUCTO { get; set; }
        public int ID_OPCION { get; set; }
        public int ID_USUARIO  { get; set; }

    }
}
