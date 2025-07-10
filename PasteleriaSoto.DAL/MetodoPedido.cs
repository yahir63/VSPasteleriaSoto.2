using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PantallasProyecto.DAL;
using PasteleriaSoto.DAL;
using PasteleriaSoto.DAL.Entities;
using Pedido.DAL;


namespace PasteleriaSoto.DAL
{
    public class MetodoPedido
    {
        public static bool RegistarPedidos(Pedidos pedido, List<DetallePedido> detallePedido)
        {
            bool resultado = false;

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    SqlCommand cmd = new SqlCommand("RegistrarDPedido", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_CLIENTE", pedido.ID_CLIENTE);
                    cmd.Parameters.AddWithValue("@FECHAPEDIDO", pedido.FECHAPEDIDO);
                    cmd.Parameters.AddWithValue("@FECHAENTREGA", pedido.FECHAENTREGA);
                    cmd.Parameters.AddWithValue("@HORAENTREGA", pedido.HORAENTREGA);
                    cmd.Parameters.AddWithValue("@SUBTOTAL", pedido.SUBTOTAL);
                    cmd.Parameters.AddWithValue("@TOTAL", pedido.TOTAL);
                    cmd.Parameters.AddWithValue("@ADELANTO", pedido.ADELANTO);
                    cmd.Parameters.Add("@RESULT", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    var detallePedidoTable = new DataTable();
                    detallePedidoTable.Columns.Add("ID_PRODUCTO", typeof(int));
                    detallePedidoTable.Columns.Add("CANTIDAD", typeof(int));
                    detallePedidoTable.Columns.Add("VOLUMEN", typeof(decimal));
                    detallePedidoTable.Columns.Add("PRECIO", typeof(double));
                    

                    foreach (var detalle in detallePedido)
                    {
                        detallePedidoTable.Rows.Add(detalle.ID_PRODUCTO, detalle.CANTIDAD, detalle.VOLUMEN, detalle.PRECIO_VENTA);
                    }

                    var detallePedidoParam = cmd.Parameters.AddWithValue("@ListaDPedido", detallePedidoTable);
                    detallePedidoParam.SqlDbType = SqlDbType.Structured;
                    detallePedidoParam.TypeName = "dbo.ListaDePedido";

                    

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(cmd.Parameters["@Result"].Value);

                    return resultado;
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                return false;
            }
        }

       





    }
}
