using System;
using System.Collections.Generic;
using System.Text;

namespace PantallasProyecto.DAL
{
    public class Producto
    {
        public int ID_PRODUCTO { get; set; }
        public string? NOMBREPRODUCTO { get; set; }

        public double PRECIOCOMPRA { get; set; }
        public double PRECIO { get; set; }

        public string UNIDADDEMEDIDA { get; set; }
        public string? DESCRIPCION { get; set; }

        public int ID_CATEGORIA { get; set; }
        public int CANTIDAD { get; set; }
        public int StockReservado { get; set; }
        public double VOLUMEN { get; set; }
        public bool ESTADO { get; set; }

        public string? TAMAÑO { get; set; }



    }

}
