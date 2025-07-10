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
                        SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTO(NOMBREPRODUCTO,DESCRIPCION,UNIDADDEMEDIDA,VOLUMEN,ID_CATEGORIA,CANTIDAD,TAMAÑO,ESTADO,StockReservado,PRECIO_COMPRA,PRECIO) VALUES(@NOMBREPRODUCTO,@DESCRIPCION,@UNIDADDEMEDIDA,@VOLUMEN,@ID_CATEGORIA,@CANTIDAD, @TAMAÑO,@ESTADO,@StockReservado,@PRECIO_COMPRA,@PRECIO )", connection);

                        cmd.Parameters.AddWithValue("@NOMBREPRODUCTO", Producto.NOMBREPRODUCTO);
                        cmd.Parameters.AddWithValue("@DESCRIPCION", Producto.DESCRIPCION);
                        cmd.Parameters.AddWithValue("@UNIDADDEMEDIDA", Producto.UNIDADDEMEDIDA);
                        cmd.Parameters.AddWithValue("@VOLUMEN", Producto.VOLUMEN);
                        cmd.Parameters.AddWithValue("@ID_CATEGORIA", Producto.ID_CATEGORIA);
                        cmd.Parameters.AddWithValue("@CANTIDAD", Producto.CANTIDAD);
                        cmd.Parameters.AddWithValue("@TAMAÑO", Producto.TAMAÑO);
                        cmd.Parameters.AddWithValue("@ESTADO", Producto.ESTADO);
                        cmd.Parameters.AddWithValue("@StockReservado", Producto.StockReservado);
                        cmd.Parameters.AddWithValue("@PRECIO_COMPRA", Producto.PRECIOCOMPRA);
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
                    SqlCommand cmd = new SqlCommand("SELECT PRODUCTO.ID_PRODUCTO, PRODUCTO.NOMBREPRODUCTO, PRODUCTO.UNIDADDEMEDIDA, PRODUCTO.TAMAÑO, PRODUCTO.VOLUMEN ,PRODUCTO.PRECIO,PRODUCTO.PRECIO_COMPRA, PRODUCTO.CANTIDAD,PRODUCTO.StockReservado, PRODUCTO.ID_CATEGORIA,  PRODUCTO.DESCRIPCION AS DESCRIPCION_PRODUCTO FROM PRODUCTO INNER JOIN CATEGORIA ON PRODUCTO.ID_CATEGORIA = CATEGORIA.ID_CATEGORIA;",   connection);



                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        var producto = new Producto()
                        {
                            ID_PRODUCTO = Convert.ToInt32(reader["ID_PRODUCTO"]),
                            NOMBREPRODUCTO = reader["NOMBREPRODUCTO"].ToString(),
                            ID_CATEGORIA = Convert.ToInt32(reader["ID_CATEGORIA"]),
                            StockReservado = Convert.ToInt32(reader["StockReservado"]),
                            UNIDADDEMEDIDA = reader["UNIDADDEMEDIDA"].ToString(),
                            VOLUMEN = Convert.ToDouble(reader["VOLUMEN"].ToString()),
                            TAMAÑO = reader["TAMAÑO"].ToString(),
                            PRECIO = Convert.ToDouble(reader["PRECIO"].ToString()),
                            PRECIOCOMPRA = Convert.ToDouble(reader["PRECIO_COMPRA"].ToString()),
                            CANTIDAD = Convert.ToInt32(reader["CANTIDAD"]),
                            DESCRIPCION = reader["DESCRIPCION_PRODUCTO"].ToString(),
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

                    SqlCommand cmd = new SqlCommand(("UPDATE PRODUCTO SET NOMBREPRODUCTO=@NOMBREPRODUCTO,DESCRIPCION=@DESCRIPCION,UNIDADDEMEDIDA=@UNIDADDEMEDIDA,VOLUMEN=@VOLUMEN,ID_CATEGORIA=@ID_CATEGORIA,CANTIDAD=@CANTIDAD,TAMAÑO=@TAMAÑO WHERE ID_PRODUCTO =@ID_PRODUCTO "), connection);
                    
                    cmd.Parameters.AddWithValue("@ID_PRODUCTO", producto.ID_PRODUCTO);
                    cmd.Parameters.AddWithValue("@NOMBREPRODUCTO", producto.NOMBREPRODUCTO);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", producto.DESCRIPCION);
                    cmd.Parameters.AddWithValue("@UNIDADDEMEDIDA", producto.UNIDADDEMEDIDA);
                    cmd.Parameters.AddWithValue("@VOLUMEN", producto.VOLUMEN);
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


    }
}
