using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PantallasProyecto.DAL;
using PasteleriaSoto.DAL;

namespace PasteleriaSoto.DAL
{
    public class MetodoPedido
    {
        // Se instancia la clase de conexión  
        BDConection connection = new BDConection();

        // Método para insertar pedido y detalles del pedido  
        public bool InsertarPedidos(string FECHAPEDIDO, string HORAENTREGA, decimal SUBTOTAL, decimal TOTAL, int ID_CLIENTE, int ID_USUARIO, DataTable dt)
        {
            try
            {
                DateTime fecha;
                DateTime hora;

                // Validar formato de fecha y hora antes de convertir
                if (!DateTime.TryParseExact(FECHAPEDIDO, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out fecha))
                {
                    Console.WriteLine("Error: Formato de fecha incorrecto.");
                    return false;
                }

                if (!DateTime.TryParseExact(HORAENTREGA, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out hora))
                {
                    Console.WriteLine("Error: Formato de hora incorrecto.");
                    return false;
                }

                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SpInsertarPedido", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter idPedidoParam = new SqlParameter("@ID_PEDIDO", SqlDbType.Int);
                    idPedidoParam.Direction = ParameterDirection.Output;

                    command.Parameters.AddWithValue("@FECHAPEDIDO", fecha);
                    command.Parameters.AddWithValue("@HORAENTREGA", hora);
                    command.Parameters.AddWithValue("@SUBTOTAL", SUBTOTAL);
                    command.Parameters.AddWithValue("@TOTAL", TOTAL);
                    command.Parameters.AddWithValue("@IDCLIENTE", ID_CLIENTE);
                    command.Parameters.AddWithValue("@IDUSUARIO", ID_USUARIO);
                    command.Parameters.Add(idPedidoParam);

                    command.ExecuteNonQuery();

                    // Obtener el ID del pedido registrado
                    int id_pedido = (int)command.Parameters["@ID_PEDIDO"].Value;

                    if (id_pedido <= 0)
                    {
                        return false;
                    }

                    // Insertar los detalles del pedido
                    foreach (DataRow row in dt.Rows)
                    {
                        decimal total_detalle = Convert.ToDecimal(row["CANTIDAD"]) * Convert.ToDecimal(row["PRECIO"]);

                        SqlCommand detailCommand = new SqlCommand("SpInsertarDetallePedido", connection);
                        detailCommand.CommandType = CommandType.StoredProcedure;

                        detailCommand.Parameters.AddWithValue("@ID_PEDIDO", id_pedido);
                        detailCommand.Parameters.AddWithValue("@ID_PRODUCTO", row["ID_PRODUCTO"]);
                        detailCommand.Parameters.AddWithValue("@CANTIDAD", row["CANTIDAD"]);
                        detailCommand.Parameters.AddWithValue("@PRECIO", row["PRECIO"]);
                        detailCommand.Parameters.AddWithValue("@TOTAL", total_detalle);

                        detailCommand.ExecuteNonQuery();
                    }

                    // Cerrar conexión una vez insertados todos los detalles
                    connection.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en InsertarPedido: " + ex.Message);
                File.AppendAllText("errores_log.txt", $"[{DateTime.Now}] {ex.Message}{Environment.NewLine}");
                return false;
            }
        }

        public void InsertarPedido(DetallePedido detallePedido)
        {
            this.InsertarPedidos(
                detallePedido.FECHAPEDIDO.ToString("yyyy-MM-dd"),
                detallePedido.HORAENTREGA.ToString("HH:mm:ss"),
                detallePedido.SUBTOTAL,
                detallePedido.TOTAL,
                detallePedido.ID_CLIENTE,
                detallePedido.ID_USUARIO,
                detallePedido.dt
            );
        }

    }
}
