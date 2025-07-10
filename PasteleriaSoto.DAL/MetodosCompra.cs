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
    public class MetodosCompra
    {
        public static bool RegistrarCompra(Compra compra, List<Detallle_compra> DetalleCompra)
        {
         bool resultado = false;

            try
            {

                using (SqlConnection connection = BDConection.connect())
                {
                    SqlCommand cmd = new SqlCommand("USP_DETALLECOMPRA", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_PROVEEDOR", compra.ID_PROVEEDOR);
                    cmd.Parameters.AddWithValue("@FECHA", compra.FECHA_COMPRA);
                    cmd.Parameters.AddWithValue("@TOTAL", compra.TOTAL);
                    cmd.Parameters.AddWithValue("@NUMEROFACTURA", compra.NUMEROFACTURA);


                    var detalleCompraTable = new DataTable();
                    detalleCompraTable.Columns.Add("ID_PRODUCTO", typeof(int));
                    detalleCompraTable.Columns.Add("PRECIOVENTA", typeof(double));
                    detalleCompraTable.Columns.Add("PRECIOCOMPRA", typeof(double));
                    detalleCompraTable.Columns.Add("CANTIDAD", typeof(int));
                    detalleCompraTable.Columns.Add("TOTAL", typeof(double));




                    foreach (var detalle in DetalleCompra)
                    {
                        detalleCompraTable.Rows.Add(detalle.ID_PRODUCTO, detalle.PRECIOVENTA, detalle.PRECIOCOMPRA, detalle.CANTIDAD, detalle.TOTAL);
                    }

                    var detalleCompraParam = cmd.Parameters.AddWithValue("@ListaDetalleCompra", detalleCompraTable);
                    detalleCompraParam.SqlDbType = SqlDbType.Structured;
                    detalleCompraParam.TypeName = "dbo.ListaDetalleDECompraType";

                 
                    SqlParameter resultadoParam = new SqlParameter("@RESULTADO", SqlDbType.Bit);
                    resultadoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultadoParam);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(resultadoParam.Value);

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
