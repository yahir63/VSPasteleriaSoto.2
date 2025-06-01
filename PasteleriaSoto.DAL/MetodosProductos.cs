using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PantallasProyecto.DAL;

namespace PasteleriaSoto.DAL
{
    public class MetodosProductos
    {
        public void RegistrarProductos(List<Producto> ListaNuevosProductos)
        {
            foreach (var Producto in ListaNuevosProductos)
            {
                try
                {
                    //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                    using (SqlConnection connection = BDConection.connect())
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTO(NOMBREPRODUCTO,DESCRIPCION,PRODUCTOBASE,UNIDADDEMEDIDA,ID_CATEGORIA,CANTIDAD,TAMAÑO) VALUES(@NOMBREPRODUCTO,@DESCRIPCION,PRODUCTOBASE,@ID_CATEGORIA,@CANTIDAD, @TAMAÑO )", connection);

                        cmd.Parameters.AddWithValue("@NOMBREPRODUCTO", Producto.NOMBREPRODUCTO);
                        cmd.Parameters.AddWithValue("@DESCRIPCION", Producto.DESCRIPCION);
                        cmd.Parameters.AddWithValue("@UNIDADDEMEDIDA", Producto.UNIDADDEMEDIDA);
                        cmd.Parameters.AddWithValue("@PRODUCTOBASE", Producto.PRODUCTOBASE);
                        cmd.Parameters.AddWithValue("@ID_CATEGORIA", Producto.ID_CATEGORIA);
                        cmd.Parameters.AddWithValue("@CANTIDAD", Producto.CANTIDAD);
                        cmd.Parameters.AddWithValue("@TAMAÑO", Producto.TAMAÑO);



                        cmd.ExecuteNonQuery();

                        connection.Close();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public List<Producto> ObtenerListProductos()
        {
            List<Producto> ListProductosTemp = new List<Producto>();

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    // Consulta para obtener datos de PRODUCTO junto con la CANTIDAD de DETALLEPEDIDO
                    SqlCommand cmd = new SqlCommand("SELECT [ID_PRODUCTO],[NOMBREPRODUCTO],[PRODUCTOBASE].[UNIDADDEMEDIDA],[TAMAÑO],[CANTIDAD],[NOMBRECATEGORIA],[PRODUCTO.DESCRIPCION] FROM [PRODUCTO] INNER JOIN CATEGORIA ON PRODUCTO.ID_CATEGORIA = CATEGORIA.ID_CATEGORIA\r\n", connection);


                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        var producto = new Producto()
                        {
                            ID_PRODUCTO = Convert.ToInt32(reader["ID_PRODUCTO"]),
                            NOMBREPRODUCTO = reader["NOMBREPRODUCTO"].ToString(),
                            ID_CATEGORIA = Convert.ToInt32(reader["ID_CATEGORIA"]),
                            PRODUCTOBASE = reader["NOMBRECATEGORIA"].ToString(),
                            UNIDADDEMEDIDA = Convert.ToInt32(reader["UNIDADDEMEDIDA"]),
                            TAMAÑO = Convert.ToDecimal(reader["TAMAÑO"]),
                            CANTIDAD = Convert.ToInt32(reader["CANTIDAD"]),
                            DESCRIPCION = reader["DESCRIPCION"].ToString(),
                        };

                        ListProductosTemp.Add(producto);
                    }

                    connection.Close();

                    return ListProductosTemp;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ActualizarProducto(Producto producto)

        {

            try
            {
                //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(("UPDATE PRODUCTO SET NOMBREPRODUCTO=@NOMBREPRODUCTO,DESCRIPCION=@DESCRIPCION,UNIDADDEMEDIDA=@UNIDADDEMEDIDA,PRODUCTOBASE=@PRODUCTOBASE,ID_CATEGORIA=@ID_CATEGORIA,CANTIDAD=@CANTIDAD,TAMAÑO=@TAMAÑO WHERE ID_PRODUCTO =@ID_PRODUCTO "), connection);

                    cmd.Parameters.AddWithValue("@NOMBREPRODUCTO", producto.NOMBREPRODUCTO);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", producto.DESCRIPCION);
                    cmd.Parameters.AddWithValue("@UNIDADDEMEDIDA", producto.UNIDADDEMEDIDA);
                    cmd.Parameters.AddWithValue("@PRODUCTOBASE", p  .PRODUCTOBASE);
                    cmd.Parameters.AddWithValue("@ID_CATEGORIA", producto.ID_CATEGORIA);
                    cmd.Parameters.AddWithValue("@CANTIDAD", producto.CANTIDAD);
                    cmd.Parameters.AddWithValue("@TAMAÑO", producto.TAMAÑO);


                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void Eliminar(int ID_PRODUCTO)
        {

            try
            {

                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    //Aqui ejecutamos la consulta para eliminar el producto segun su id
                    SqlCommand cmd = new SqlCommand("delete from PRODUCTO where ID_PRODUCTO = @ID_PRODUCTO", connection);


                    cmd.Parameters.AddWithValue("@ID_PRODUCTO", ID_PRODUCTO);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }



        }

        public Producto BuscarProducto(string NOMBREPRODUCTO)
        {
            Producto productoEncontrado = null;

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SP_BUSCAR_PRODUCTO", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Pasar el parámetro @ID_PRODUCTO al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@NOMBREPRODUCTO", NOMBREPRODUCTO);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        productoEncontrado = new Producto()
                        {
                            ID_PRODUCTO = Convert.ToInt32(reader["ID_PRODUCTO"]),
                            NOMBREPRODUCTO = reader["NOMBREPRODUCTO"].ToString(),
                            ID_CATEGORIA = Convert.ToInt32(reader["ID_CATEGORIA"]),
                            PRODUCTOBASE = reader["NOMBRECATEGORIA"].ToString(),
                            UNIDADDEMEDIDA = Convert.ToInt32(reader["UNIDADDEMEDIDA"]),
                            TAMAÑO = Convert.ToDecimal(reader["TAMAÑO"]),
                            CANTIDAD = Convert.ToInt32(reader["CANTIDAD"]),
                            DESCRIPCION = reader["DESCRIPCION"].ToString(),

                        };
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                
            }

            return productoEncontrado;
        }
    }
}
