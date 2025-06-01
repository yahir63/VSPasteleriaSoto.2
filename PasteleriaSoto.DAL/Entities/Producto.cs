using System;
using System.Collections.Generic;
using System.Text;

namespace PantallasProyecto.DAL
{
    public class Producto
    {
       public int ID_PRODUCTO { get; set; }
        public string? NOMBREPRODUCTO { get; set; }
        public string? NOMBRECATEGORIA { get; set; }
        public float PRECIO { get; set; }
        public string? PRODUCTOBASE { get; set; }
        public int UNIDADDEMEDIDA { get; set; }
        public string? DESCRIPCION { get; set; }

        public int ID_CATEGORIA { get; set; }
        public int CANTIDAD { get; set; }
        public decimal TAMAÑO { get; set; }



    }

}
