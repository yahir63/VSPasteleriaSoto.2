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


                    if (resultado==true)
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
                    SqlCommand cmd = new SqlCommand("SELECT ID_PERSONALIZADO,ID_CLIENTE,ID_PRODUCTO,DESCRIPCION,PRECIO_VENTA,UNIDADEMEDIDA FROM PRODUCTOPERSONALIZADO", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Aqui cree la instancia para que el reader vea los datos de la consulta
                        ProductoPersonalizado productoP = new ProductoPersonalizado
                        {
                            ID_PERSONALIZADO = reader.GetInt32(0),
                            ID_CLIENTE = reader.GetInt32(1),
                            ID_PRODUCTO = reader.GetInt32(2),
                            DESCRIPCION = reader.IsDBNull(3) ? null : reader.GetString(3),
                            PRECIO_VENTA = reader.GetDouble(4),
                            UNIDADEMEDIDA = reader.GetInt32(5)
                        };
                        ListaProductosPersonalizados.Add(productoP);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de productos personalizados: " + ex.Message);
            }
            return ListaProductosPersonalizados;
        }

        public void ActualizarProductoP(ProductoPersonalizado producto)
        {
            

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE PRODUCTO_PERSONALIZADO SET DESCRIPCION = @DESCRIPCION, PRECIO_VENTA = @PRECIO_VENTA, ID_CLIENTE = @ID_CLIENTE, ID_PRODUCTO = @ID_PRODUCTO, UNIDADEMEDIDA = @UNIDADEMEDIDA WHERE ID_PERSONALIZADO = @ID_PERSONALIZADO;", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_PERSONALIZADO", producto.ID_PERSONALIZADO);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", producto.DESCRIPCION ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PRECIO_VENTA", producto.PRECIO_VENTA);
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", producto.ID_CLIENTE);
                    cmd.Parameters.AddWithValue("@ID_PRODUCTO", producto.ID_PRODUCTO);
                    cmd.Parameters.AddWithValue("@UNIDADEMEDIDA", producto.UNIDADEMEDIDA);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el producto personalizado: " + ex.Message);
            }
        }



    }
    //vamos con eliminar 😭
    public void EliminarProductoP(int idPersonalizado)
        {
            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCTO_PERSONALIZADO WHERE ID_PERSONALIZADO = @ID_PERSONALIZADO", connection);
                    cmd.Parameters.AddWithValue("@ID_PERSONALIZADO", idPersonalizado);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el producto personalizado: " + ex.Message);
            }
        }
    }

