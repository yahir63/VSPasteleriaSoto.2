
using System;
using System.Collections.Generic;
using System.Text;

namespace PantallasProyecto.DAL
{
    public class DetallePedido
    {
        public int ID_DETALLEPEDIDO { get; set; }
        public int ID_PEDIDO { get; set; }  
        public int ID_PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }  
        public double PRECIO { get; set; }
        public double TOTAL { get; set; }

    }
}
