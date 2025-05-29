using System;
using System.Collections;
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
public class StockMetodos
{
    // le di valor a cada constante
    const int paquetesPorCaja = 5;   //cada caja tiene en total 5 paquetes
    const int unidadesPorPaquete = 20; //cada paquete tiene 20 unidades

    // Convierto las unidades a paquetes + unidades sueltas
    public string ConvertirUnidadesAPaquetes(int unidades)
    {
        int paquetes = unidades / unidadesPorPaquete;
        int unidadesRestantes = unidades % unidadesPorPaquete;
        return $"Paquetes: {paquetes}, Unidades: {unidadesRestantes}";
    }

    // Convierto los paquetes a cajas + paquetes restantes
    public string ConvertirPaquetesACajas(int paquetes)
    {
        int cajas = paquetes / paquetesPorCaja;
        int paquetesRestantes = paquetes % paquetesPorCaja;
        return $"Cajas: {cajas}, Paquetes: {paquetesRestantes}";
    }

    // Convierto las cajas a unidades totales
    public int ConvertirCajasAUnidades(int cajas)
    {
        return cajas * paquetesPorCaja * unidadesPorPaquete;
    }

    // Convierto unidades a cajas + paquetes + unidades sueltas
    public string ConvertirUnidadesACajasPaquetes(int unidades)
    {
        int paquetesTotales = unidades / unidadesPorPaquete;
        int unidadesRestantes = unidades % unidadesPorPaquete;

        int cajas = paquetesTotales / paquetesPorCaja;
        int paquetesRestantes = paquetesTotales % paquetesPorCaja;

        return $"Cajas: {cajas}, Paquetes: {paquetesRestantes}, Unidades: {unidadesRestantes}";
    }

    // cuando vendan unidades (resto unidades vendidas al stock y devuelvo stock actualizado)
    public string VenderUnidades(int cajas, int paquetes, int unidades, int unidadesVendidas)
    {
        int totalUnidades = ConvertirCajasAUnidades(cajas) + (paquetes * unidadesPorPaquete) + unidades;
        totalUnidades -= unidadesVendidas;

        if (totalUnidades < 0)
            return "Error: No hay suficiente stock para vender esa cantidad.";

        return ConvertirUnidadesACajasPaquetes(totalUnidades);
    }

    public string VenderPorPaquetes(int cantidadBase, int paquetesVendidos)
    {
        int unidadesVendidas = paquetesVendidos * unidadesPorPaquete;
        int unidadesRestantes = cantidadBase - unidadesVendidas;

        if (unidadesRestantes < 0)
            return "Error: No hay suficiente stock para vender esa cantidad de paquetes.";

        return ConvertirUnidadesACajasPaquetes(unidadesRestantes);
    }
}



public class StockNegocio
{
    StockMetodos _stockMetodos = new StockMetodos();

    // Método para mostrar stock
    public string ObtenerConversionesStock(Stock stock)
    {
        return _stockMetodos.ConvertirUnidadesACajasPaquetes(stock.CantidadBase);
    }

    // Método cuando hacen una venta por unidades y mostrar el nuevo stock
    public string VentaStockUnidades(Stock stock, int unidadesVendidas)
    {
        return _stockMetodos.VenderUnidades(stock.CantidadBase, unidadesVendidas);
    }


    // Método cuando hacen una venta por paquetes y mostrar el nuevo stock
    public string VentaStockPaquetes(Stock stock, int paquetesVendidos)
    {
        return _stockMetodos.VenderPorPaquetes(stock.CantidadBase, paquetesVendidos);
    }
}