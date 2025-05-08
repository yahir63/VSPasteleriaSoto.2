using Microsoft.Data.SqlClient;
using PantallasProyecto.DAL;
using PasteleriaSoto.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteleriaSoto.BLL
{
    public class RegistroRepositoryCAT
    {
        public List<Categoria> MostrarCategorias()
        {
            List<Categoria> ListaCategoriasOFC = new List<Categoria>();

            try
            {

                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ID_CATEGORIA, NOMBRECATEGORIA, DESCRIPCION  FROM CATEGORIA", connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Categoria cat = new Categoria
                        {
                            ID_CATEGORIA = Convert.ToInt32(reader["ID_CATEGORIA"]),
                            NOMBRECATEGORIA = reader["NOMBRECATEGORIA"].ToString(),
                            DESCRIPCION = reader["DESCRIPCION"].ToString()
                        };

                        ListaCategoriasOFC.Add(cat);
                    }
                    connection.Close();
                }
                return ListaCategoriasOFC;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RegistrarCategorias(List<Categoria> ListaNuevasCategorias)
        {
            foreach (var categoria in ListaNuevasCategorias)
            {
                try
                {
                    using (SqlConnection connection = BDConection.connect())
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO CATEGORIA(NOMBRECATEGORIA, DESCRIPCION) VALUES(@NOMBRECATEGORIA, @DESCRIPCION)", connection);

                        cmd.Parameters.AddWithValue("@NOMBRECATEGORIA", categoria.NOMBRECATEGORIA);
                        cmd.Parameters.AddWithValue("@DESCRIPCION", categoria.DESCRIPCION);

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

        public void ActualizarCategoria(Categoria categoria)

        {

            try
            {
                //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();


                    SqlCommand cmd = new SqlCommand("UPDATE CATEGORIA SET NOMBRECATEGORIA = @NOMBRECATEGORIA, DESCRIPCION = @DESCRIPCION WHERE ID_CATEGORIA = @ID_CATEGORIA", connection);
                    cmd.Parameters.AddWithValue("@ID_CATEGORIA", categoria.ID_CATEGORIA);
                    cmd.Parameters.AddWithValue("@NOMBRECATEGORIA", categoria.NOMBRECATEGORIA);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", categoria.DESCRIPCION);


                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }


        }


        public void EliminarCategoria(string ID_CATEGORIA)

        {
            try
            {
                //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("delete from CATEGORIA where ID_CATEGORIA = @ID", connection);


                    cmd.Parameters.AddWithValue("@ID", ID_CATEGORIA);

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

