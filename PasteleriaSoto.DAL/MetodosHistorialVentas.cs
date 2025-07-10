using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PantallasProyecto.DAL;
using PasteleriaSoto.DAL.Entities;
using Pedido.DAL;

namespace PasteleriaSoto.DAL
{
    public class MetodosHistorialVentas
    {
        public List<Venta> ObtenerVenta(DateTime fechaInicio, DateTime fechaFinal)
        {
            List<Venta> ventas = new List<Venta>();

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    SqlCommand cmd = new SqlCommand("USP_VentaPorRango", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFinal", fechaFinal);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var venta = new Venta()

                        {
                            ID_VENTA = (int)reader["ID_VENTA"],
                            ID_PEDIDO = (int)reader["ID_PEDIDO"],
                            ID_CLIENTE = (int)reader["ID_CLIENTE"],
                            NOMBRECLIENTE = (string)reader["NOMBRECLIENTE"],
                            FECHAVENTA = (DateTime)reader["FECHAVENTA"],

                            TOTALVENTA = (double)reader["TOTALVENTA"],
                        };
                        ventas.Add(venta);
                    }

                    connection.Close();
                    return ventas;

                }
            }
            catch
            {
                ventas = null;
                return ventas;
            }
        }


        public List<Detalle_Venta> ObtenerDetalleVentas(int id_venta)
        {
            List<Detalle_Venta> detallesVenta = new List<Detalle_Venta>();

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    SqlCommand cmd = new SqlCommand("USP_DetalleDeVenta", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_VENTA", id_venta);

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var detalle = new Detalle_Venta()
                        {
                            ID_DETALLEVENTA = (int)reader["ID_DVENTA"],
                            ID_VENTA = (int)reader["ID_VENTA"],
                            ID_PRODUCTO = (int)reader["ID_PRODUCTO"],
                            NOMBREPRODUCTO = (string)reader["NOMBREPRODUCTO"],
                            CANTIDAD = (int)reader["CANTIDAD"],
                            PRECIO_VENTA = (double)reader["PRECIO_VENTA"],
                            TOTAL_LINEA = (double)reader["TOTAL_LINEA"]
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

    }
}
