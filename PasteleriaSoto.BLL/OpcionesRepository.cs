using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PasteleriaSoto.DAL;
using PasteleriaSoto.DAL.Entities;

namespace PasteleriaSoto.BLL
{
    public class OpcionesRepository
    {
        public void RegistrarOpcion(List<Opciones> ListaNuevasOpciones)
        {
            foreach (var opcion in ListaNuevasOpciones)
            {
                try
                {
                    using (var con = BDConection.connect())
                    {
                        con.Open();
                        using (var cmd = new SqlCommand("INSERT INTO OPCIONES (NOMBRE, PRECIO, UNIDADMEDIDA, DESCRIPCION) VALUES (@NOMBRE, @PRECIO, @UNIDADMEDIDA, @DESCRIPCION);", con))
                        {
                            cmd.Parameters.AddWithValue("@NOMBRE", opcion.NOMBRE_OPCION);
                            cmd.Parameters.AddWithValue("@DESCRIPCION", opcion.DESCRIPCION);
                            cmd.Parameters.AddWithValue("@UNIDADMEDIDA", opcion.UNIDADMEDIDA);
                            cmd.Parameters.AddWithValue("@PRECIO", opcion.PRECIO);
                            cmd.ExecuteNonQuery();
                        }

                        con.Close();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        public List<Opciones> ObtenerListaOpciones()
        {
            List<Opciones> ListaOpciones = new List<Opciones>();
            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ID_OPCIONES, NOMBRE, PRECIO, UNIDADMEDIDA, DESCRIPCION FROM OPCIONES", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Opciones opcion = new Opciones
                        {
                            ID_OPCIONES = reader.GetInt32(0),
                            NOMBRE_OPCION = reader.GetString(1),
                            PRECIO = Convert.ToDouble(reader["PRECIO"]),
                            UNIDADMEDIDA = reader.GetString(3),
                            DESCRIPCION = reader.GetString(4)
                        };
                        ListaOpciones.Add(opcion);
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return ListaOpciones;

        }

        public void ActualizarOpciones(Opciones opciones)

        {

            try
            {
                //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();


                    SqlCommand cmd = new SqlCommand("UPDATE OPCIONES SET NOMBRE = @NOMBRE, PRECIO = @PRECIO, DESCRIPCION = @DESCRIPCION,UNIDADMEDIDA = @UNIDADMEDIDA WHERE ID_OPCIONES = @ID_OPCIONES", connection);
                    cmd.Parameters.AddWithValue("@ID_OPCIONES", opciones.ID_OPCIONES);
                    cmd.Parameters.AddWithValue("@NOMBRE", opciones.NOMBRE_OPCION);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", opciones.DESCRIPCION);
                    cmd.Parameters.AddWithValue("@PRECIO", opciones.PRECIO);
                    cmd.Parameters.AddWithValue("@UNIDADMEDIDA", opciones.UNIDADMEDIDA);


                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }


        }


        public void EliminarOpciones(int ID_OPCIONES)

        {
            try
            {
                //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("delete from OPCIONES where ID_OPCIONES = @ID", connection);


                    cmd.Parameters.AddWithValue("@ID", ID_OPCIONES);

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






