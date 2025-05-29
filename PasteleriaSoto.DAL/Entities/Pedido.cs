using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.DAL
{
    public class Pedidos

    {
        public int ID_PEDIDO { get; set; }
        public int ID_CLIENTE { get; set; }
        public DateTime FECHAPEDIDO { get; set; }
        public DateTime  HORAENTREGA { get; set; }
        public double SUBTOTAL { get; set; }
        public  double TOTAL { get; set; }
         
    }
}
 