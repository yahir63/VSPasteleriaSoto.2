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
    
        public decimal TOTAL { get; set; }
        public DateTime FECHAPEDIDO { get; set; }
        public DateTime HORAENTREGA { get; set; }
        public decimal SUBTOTAL { get; set; }
      



 

    }
}
