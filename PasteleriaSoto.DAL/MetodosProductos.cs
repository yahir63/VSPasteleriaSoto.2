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
                        SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTO(NOMBREPRODUCTO,CANTIDAD,LIBRAS,ID_CATEGORIA,ID_SABOR,ID_RELLENO, ID_BANO, PRECIO) VALUES(@NOMBREPRODUCTO,@CANTIDAD,@LIBRAS,@ID_CATEGORIA,@ID_SABOR,@ID_RELLENO, @ID_BANO, @PRECIO)", connection);

                        cmd.Parameters.AddWithValue("@NOMBREPRODUCTO", Producto.NOMBREPRODUCTO);
                        cmd.Parameters.AddWithValue("@ID_CATEGORIA", Producto.ID_CATEGORIA);
                        cmd.Parameters.AddWithValue("@CANTIDAD", Producto.CANTIDAD);
                        cmd.Parameters.AddWithValue("@LIBRAS", Producto.LIBRAS);
                        cmd.Parameters.AddWithValue("@PRECIO", Producto.PRECIO);



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
                    SqlCommand cmd = new SqlCommand("SELECT [ID_PRODUCTO],[NOMBREPRODUCTO],[PRECIO],[PRODUCTO].[ID_CATEGORIA],[CANTIDAD],[PRODUCTO].[ESTADO],[LIBRAS],[STOCK],[NOMBRECATEGORIA] FROM [PRODUCTO] INNER JOIN CATEGORIA ON PRODUCTO.ID_CATEGORIA = CATEGORIA.ID_CATEGORIA\r\n", connection);


                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        var producto = new Producto()
                        {
                            ID_PRODUCTO = Convert.ToInt32(reader["ID_PRODUCTO"]),
                            NOMBREPRODUCTO = reader["NOMBREPRODUCTO"].ToString(),
                            ID_CATEGORIA = Convert.ToInt32(reader["ID_CATEGORIA"]),
                            NOMBRECATEGORIA = reader["NOMBRECATEGORIA"].ToString(),
                            LIBRAS = decimal.Parse(reader["LIBRAS"].ToString()),
                            PRECIO = Convert.ToSingle(reader["PRECIO"]),
                            CANTIDAD = Convert.ToInt32(reader["CANTIDAD"])
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

                    SqlCommand cmd = new SqlCommand(("UPDATE PRODUCTO SET NOMBREPRODUCTO=@NOMBREPRODUCTO,ID_CATEGORIA=@ID_CATEGORIA,ID_SABOR=@ID_SABOR,CANTIDAD=@CANTIDAD,ID_RELLENO=@ID_RELLENO,ID_BANO=@ID_BANO,LIBRAS=@LIBRAS WHERE ID_PRODUCTO =@ID_PRODUCTO "), connection);

                    cmd.Parameters.AddWithValue("@ID_PRODUCTO", producto.ID_PRODUCTO);
                    cmd.Parameters.AddWithValue("@NOMBREPRODUCTO", producto.NOMBREPRODUCTO);
                    cmd.Parameters.AddWithValue("@ID_CATEGORIA", producto.ID_CATEGORIA);
                    cmd.Parameters.AddWithValue("@CANTIDAD", producto.CANTIDAD);


                    cmd.Parameters.AddWithValue("@LIBRAS", producto.LIBRAS);


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
                            CANTIDAD = Convert.ToInt32(reader["CANTIDAD"]),
                            LIBRAS = Convert.ToDecimal(reader["LIBRAS"]),
                            PRECIO = Convert.ToSingle(reader["PRECIO"]),
                      
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
