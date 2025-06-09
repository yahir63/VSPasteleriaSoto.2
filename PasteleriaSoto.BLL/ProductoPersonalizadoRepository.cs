using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PasteleriaSoto.DAL;
using PasteleriaSoto.DAL.Entities;

namespace PasteleriaSoto.BLL
{
    public class ProductoPersonalizadoRepository
    {

        public bool Registrar(ProductoPersonalizado producto, List<Opciones> ListaOpciones)
        {
            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("Registrar_ProductoPersonalizado", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@DESCRIPCION", producto.DESCRIPCION);
                    cmd.Parameters.AddWithValue("@PRECIO_VENTA", producto.PRECIO_VENTA);
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", producto.ID_CLIENTE);
                    cmd.Parameters.AddWithValue("@ID_PRODUCTO", producto.ID_PRODUCTO);
                    cmd.Parameters.AddWithValue("@FECHACREACION", DateTime.Now);
                    cmd.Parameters.Add("@RESULT", SqlDbType.Bit).Direction = ParameterDirection.Output;





                    // Creacion de objeto para capturar la lista de las opcoiones
                    //Se crea una tabla de tipo definido por el usuario
                    DataTable DataTable_Opciones = new DataTable();
                    DataTable_Opciones.Columns.Add("ID_OPCION", typeof(int));
                    DataTable_Opciones.Columns.Add("CANTIDAD", typeof(int));
                    DataTable_Opciones.Columns.Add("PRECIO_VENTA", typeof(decimal));
                    DataTable_Opciones.Columns.Add("SUBTOTAL", typeof(decimal));

                    //Captura de los detalles de compra
                    foreach (var item in ListaOpciones)
                    {
                        DataTable_Opciones.Rows.Add(item.ID_OPCIONES, item.CANTIDAD, item.PRECIO, (item.CANTIDAD * item.PRECIO));
                    }

                    //Paso del detailsTable como parametro al comando
                    SqlParameter detailsParam = cmd.Parameters.AddWithValue("@TABLA_LISTAOPCIONES", DataTable_Opciones);
                    detailsParam.SqlDbType = SqlDbType.Structured;
                    detailsParam.TypeName = "dbo.ListaOpcionesType";


                    cmd.ExecuteNonQuery();



                    bool resultado = Convert.ToBoolean(cmd.Parameters["@RESULT"].Value);


                    if (resultado == true)
                    {
                        return true; // Registro exitoso
                    }
                    else
                    {
                        return false; // Registro fallido
                    }


                    connection.Close();
                }
            }
            catch
            {
                return false;
            }
        }

        public List<ProductoPersonalizado> ObtenerListaProductosPersonalizados()
        {
            List<ProductoPersonalizado> ListaProductosPersonalizados = new List<ProductoPersonalizado>();

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("Buscar_ProductoPersonalizado", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductoPersonalizado productoP = new ProductoPersonalizado
                            {
                                ID_PERSONALIZADO = reader.GetInt32(0),
                                ID_CLIENTE = reader.GetInt32(1),
                                ID_PRODUCTO = reader.GetInt32(2),
                                DESCRIPCION = reader.IsDBNull(3) ? null : reader.GetString(3),
                                PRECIO_VENTA = reader.GetDouble(4),
                                UNIDADEMEDIDA = reader.GetInt32(5),

                            };

                            ListaProductosPersonalizados.Add(productoP);
                        }

                       
                        if (reader.NextResult())
                        {
                            while (reader.Read())
                            {
                                Opciones opcion = new Opciones
                                {
                                    ID_OPCIONES = reader.GetInt32(1),
                                    CANTIDAD = reader.GetInt32(2),
                                    PRECIO = reader.GetDouble(3),
                                    DESCRIPCION = reader.IsDBNull(4) ? null : reader.GetString(4)
                                };

                         
                                int idProductoPersonalizado = reader.GetInt32(0);
                                ProductoPersonalizado producto = ListaProductosPersonalizados.FirstOrDefault(p => p.ID_PERSONALIZADO == idProductoPersonalizado);

                                if (producto != null)
                                {
                                    producto.Opciones.Add(opcion);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de productos personalizados: " + ex.Message);
            }

            return ListaProductosPersonalizados;
        }
        public bool ActualizarProductoPersonalizado(ProductoPersonalizado producto, List<Opciones> listaOpciones)
        {
            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("Actualizar_ProductoPersonalizado", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    
                    cmd.Parameters.AddWithValue("@ID_PRODUCTO_PERSONALIZADO", producto.ID_PERSONALIZADO);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", producto.DESCRIPCION);
                    cmd.Parameters.AddWithValue("@PRECIO_VENTA", producto.PRECIO_VENTA);
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", producto.ID_CLIENTE);

                    // Creación del DataTable para las opciones
                    DataTable dataTableOpciones = new DataTable();
                    dataTableOpciones.Columns.Add("ID_OPCION", typeof(int));
                    dataTableOpciones.Columns.Add("CANTIDAD", typeof(int));
                    dataTableOpciones.Columns.Add("PRECIO_VENTA", typeof(decimal));
                    dataTableOpciones.Columns.Add("SUBTOTAL", typeof(decimal));

                    // Llenar DataTabl
                    foreach (var item in listaOpciones)
                    {
                        dataTableOpciones.Rows.Add(item.ID_OPCIONES, item.CANTIDAD, producto.PRECIO_VENTA, (item.CANTIDAD * producto.PRECIO_VENTA));
                    }

                    // Pasar el DataTable como parámetro
                    SqlParameter detailsParam = cmd.Parameters.AddWithValue("@TABLA_LISTAOPCIONES", dataTableOpciones);
                    detailsParam.SqlDbType = SqlDbType.Structured;
                    detailsParam.TypeName = "dbo.ListaOpcionesType";

                    // Parametro de salida
                    SqlParameter resultParam = new SqlParameter("@RESULT", SqlDbType.Bit);
                    resultParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultParam);

                    cmd.ExecuteNonQuery();

                    return Convert.ToBoolean(resultParam.Value);
                }
            }
            catch
            {
                return false; 
            }
        }




        //vamos con eliminar 😭
        public bool EliminarProductoPersonalizado(int idProductoPersonalizado)
        {
            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("Eliminar_ProductoPersonalizado", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetro de entrada
                    cmd.Parameters.AddWithValue("@ID_PRODUCTO_PERSONALIZADO", idProductoPersonalizado);

                    // Parámetro de salida
                    SqlParameter resultParam = new SqlParameter("@RESULT", SqlDbType.Bit);
                    resultParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultParam);

                    cmd.ExecuteNonQuery();

                    // Verificar el resultado
                    return Convert.ToBoolean(resultParam.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el producto personalizado: " + ex.Message);
                return false;
            }
        }
    }
}

