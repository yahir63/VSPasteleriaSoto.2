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
        public int ID_CLIENTE { get; set; }
        public int ID_PRODUCTO { get; set; }
        public int ID_USUARIO { get; set; }
        public decimal TOTAL { get; set; }
        public DateTime FECHAPEDIDO { get; set; }
        public DateTime HORAENTREGA { get; set; }
        public decimal SUBTOTAL { get; set; }
        public DataTable dt { get; set; }



        // Se instancia la clase de métodos de la entidad Pedido
        MetodoPedido pedidoMet = new MetodoPedido();

        // Se crea el método para insertar un pedido y su detalle, se reciben los parámetros como objeto `ClassPedido`
        public bool InsertarPedido(DetallePedido obj)
        {
            try
            {
                // Se llama al método `InsertarPedido` de la clase `CDPedido`
                return pedidoMet.InsertarPedidos(obj.FECHAPEDIDO.ToString("yyyy-MM-dd"), obj.HORAENTREGA.ToString("HH:mm:ss"), obj.SUBTOTAL, obj.TOTAL, obj.ID_CLIENTE, obj.ID_USUARIO, obj.dt);
            }
            catch (Exception ex)
            {
                // Se imprime el mensaje de la excepción
                string error = ex.Message;
                Console.WriteLine(error);
                return false;
            }
        }

    }
}
