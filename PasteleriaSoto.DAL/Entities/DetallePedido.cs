using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using PasteleriaSoto.DAL;

namespace PantallasProyecto.DAL
{
    public class DetallePedido
    {
        public int ID_DETALLEPEDIDO { get; set; }
        public int ID_PEDIDO { get; set; }
        public int ID_PRODUCTO { get; set; }
        public int ID_PERSONALIZADO { get; set; }
        public int CANTIDAD { get; set; }
        public double PRECIO_VENTA { get; set; }
        public string? NOMBREPRODUCTO { get; set; }
        public double VOLUMEN { get; set; }
        public double TOTAL { get; set; }
        public double SUBTOTAL { get; set; }
      



 

    }
}
