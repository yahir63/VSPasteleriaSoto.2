using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.DAL
{
    public class Pedidos

    {
        public int ID_PEDIDO { get; set; }
        public int ID_CLIENTE { get; set; }
        public int ID_USUARIO { get; set; }
        public DateTime FECHAPEDIDO { get; set; }
        public DateTime FECHAENTREGA { get; set; }
        public DateTime HORAENTREGA { get; set; }

        public double ADELANTO { get; set; }

        public double SUBTOTAL { get; set; }
        public  double TOTAL { get; set; }
         public string ESTADO { get; set; }
        public string NOMBRECLIENTE { get; set; }
    }
}
 