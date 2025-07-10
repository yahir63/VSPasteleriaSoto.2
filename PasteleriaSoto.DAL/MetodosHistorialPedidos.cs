using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Pedido.DAL;
using PantallasProyecto.DAL;
using PasteleriaSoto.DAL.Entities;
using Clientes.DAL;

namespace PasteleriaSoto.DAL
{
    public class MetodosHistorialPedidos
    {
        public List<Pedidos> ObtenerPedido(DateTime fechaInicio, DateTime fechaFinal)
        {
            List<Pedidos> pedidos = new List<Pedidos>();

            try
            {
                using (SqlConnection connection = BDConection.connect()) 
                {
                    SqlCommand cmd = new SqlCommand("USP_VentaPorRangoDeFecha", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFinal", fechaFinal);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var Pedido = new Pedidos()
                    
                        {
                            ID_PEDIDO = (int)reader["ID_PEDIDO"],
                            ID_CLIENTE = (int)reader["ID_CLIENTE"],
                            NOMBRECLIENTE = reader["NOMBRECLIENTE"].ToString(),
                            FECHAENTREGA = (DateTime)reader["FECHAENTREGA"],

                            TOTAL = (double)reader["TOTAL"],
                        };
                        pedidos.Add(Pedido);
                    }

                    connection.Close();
                    return pedidos;

                }
            }
            catch
            {
                pedidos = null;
                return pedidos;
            }
        }


        public List<DetallePedido> ObtenerDetallePedido(int id_pedido)
        {
            List<DetallePedido> detallesVenta = new List<DetallePedido>();

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    SqlCommand cmd = new SqlCommand("USP_DetalleDeVentaUnica", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_PEDIDO", id_pedido);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var detalle = new DetallePedido()
                        {
                            ID_DETALLEPEDIDO = (int)reader["ID_DETALLEPEDIDO"],
                            ID_PEDIDO = (int)reader["ID_PEDIDO"],
                            ID_PRODUCTO = (int)reader["ID_PRODUCTO"],
                            NOMBREPRODUCTO = reader["DESCRIPCION"].ToString(),
                            CANTIDAD = (int)reader["CANTIDAD"],
                            PRECIO_VENTA = (double)reader["PRECIO_VENTA"],
                            TOTAL = (double)reader["TOTALLINEA"]
                        };
                        detallesVenta.Add(detalle);
                    }

                    connection.Close();
                    return detallesVenta;

                }
            }
            catch
            {
                detallesVenta = null;
                return detallesVenta;
            }
        }

        public static bool ActualizarEstadoPedido(Venta venta, List<Detalle_Venta> detalle_Ventas )
        {
            bool resultado = false;

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    SqlCommand cmd = new SqlCommand("USP_DetalleDVenta", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
   
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", venta.ID_CLIENTE);
                    cmd.Parameters.AddWithValue("@ID_PEDIDO", venta.ID_PEDIDO);
                    cmd.Parameters.AddWithValue("@FECHAVENTA", venta.FECHAVENTA);
                    cmd.Parameters.AddWithValue("@TOTAL_VENTA", venta.TOTALVENTA);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    var detalleVentaTable = new DataTable();
   
                    detalleVentaTable.Columns.Add("ID_PRODUCTO", typeof(int));
                    detalleVentaTable.Columns.Add("CANTIDAD", typeof(int));
                    detalleVentaTable.Columns.Add("PRECIO_VENTA", typeof(double));
                    detalleVentaTable.Columns.Add("TOTAL_LINEA", typeof(double));
                    foreach (var detalle in detalle_Ventas)
                    {
                        detalleVentaTable.Rows.Add( detalle.ID_PRODUCTO, detalle.CANTIDAD, detalle.PRECIO_VENTA, detalle.TOTAL_LINEA);
                    }
                    var detalleVentaParam = cmd.Parameters.AddWithValue("@listaVenta", detalleVentaTable);
                    detalleVentaParam.SqlDbType = SqlDbType.Structured;
                    detalleVentaParam.TypeName = "dbo.ListaVentaType";
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);

                    return resultado;
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                return false;
            }
        }
        public  static List<Pedidos> ObtenerPedidosCancelados()
        {
            List<Pedidos> pedidosCancelados = new List<Pedidos>();

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    string query = "SELECT ID_CLIENTE, ID_PEDIDO, FECHAPEDIDO, TOTAL FROM PEDIDO WHERE ESTADO = 2";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pedidos pedido = new Pedidos
                            {
                                ID_CLIENTE = (int)reader["ID_CLIENTE"],
                                ID_PEDIDO = (int)reader["ID_PEDIDO"],
                                FECHAPEDIDO = (DateTime)reader["FECHAPEDIDO"],
                                TOTAL = (double)reader["TOTAL"]
                            };

                            pedidosCancelados.Add(pedido);
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los pedidos cancelados", ex);
            }

            return pedidosCancelados;
        }

    }
}

