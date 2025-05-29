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
    public class MetodoSabor
    {
        //Metodo para obtener la lista de sabores
        public List<Sabor> ObtenerSabores()
        {
            List<Sabor> ListaSabores = new List<Sabor>();

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();


                    SqlCommand cmd = new SqlCommand("Select ID_SABOR,NOMBRESABOR,DESCRIPCION, PRECIOSABOR FROM SABOR", connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var Sabor = new Sabor()
                        {

                            NOMBRESABOR = reader["NOMBRESABOR"].ToString(),
                            DESCRIPCION = reader["DESCRIPCION"].ToString(),
                            PRECIOSABOR = reader["PRECIOSABOR"].ToString(),
                            ID_SABOR = Convert.ToInt32(reader["ID_SABOR"].ToString()),

                        };

                        ListaSabores.Add(Sabor);
                    }

                    connection.Close();

                    return ListaSabores;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Metodo para agregar sabor
        public void AgregarSabor(Sabor sabor)
        {
            using (var con = BDConection.connect())
            {
                con.Open();
                using (var cmd = new SqlCommand("INSERT INTO SABOR (NOMBRESABOR, DESCRIPCION, PRECIOSABOR) VALUES (@nombre, @descripcion,@preciosabor)", con))
                {
                    cmd.Parameters.AddWithValue("@nombre", sabor.NOMBRESABOR);
                    cmd.Parameters.AddWithValue("@descripcion", sabor.DESCRIPCION);
                    cmd.Parameters.AddWithValue("@preciosabor", sabor.PRECIOSABOR);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //Metodo para Registrar  Sabor
        public void RegistrarSabor(List<Sabor> ListaNuevosSabores)
        {
            foreach (var sabor in ListaNuevosSabores)
            {
                try
                {
                    //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                    using (SqlConnection connection = BDConection.connect())
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand(("INSERT INTO SABOR(NOMBRESABOR,DESCRIPCION, PRECIOSABOR) VALUES(@NOMBRESABOR,@DESCRIPCION,@PRECIOSABOR) "), connection);

                        cmd.Parameters.AddWithValue("@NOMBRESABOR", sabor.NOMBRESABOR);
                        cmd.Parameters.AddWithValue("@DESCRIPCION", sabor.DESCRIPCION);
                        cmd.Parameters.AddWithValue("@PRECIOSABOR", sabor.PRECIOSABOR);




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


        //Metodo para actualizar sabor

        public void ActualizarSabor(Sabor sabor)
        {
            try
            {
                // Conectamos a la base de datos
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    // Definimos la consulta SQL con parámetros
                    string query = "UPDATE SABOR SET NOMBRESABOR = @NOMBRESABOR, DESCRIPCION = @DESCRIPCION, PRECIOSABOR= @PRECIOSABOR WHERE ID_SABOR = @ID_SABOR";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Asignamos valores a los parámetros para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@ID_SABOR", sabor.ID_SABOR);
                        cmd.Parameters.AddWithValue("@NOMBRESABOR", sabor.NOMBRESABOR);
                        cmd.Parameters.AddWithValue("@DESCRIPCION", sabor.DESCRIPCION);
                        cmd.Parameters.AddWithValue("@PRECIOSABOR", sabor.PRECIOSABOR);


                        // Ejecutamos la consulta
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejamos la excepción adecuadamente
                throw new Exception("Error al actualizar el sabor: " + ex.Message);
            }
        }




        //Metodo para eliminar Sabor


        public void EliminarSabor(int ID_SABOR)
        {
            try
            {
                // Usamos la conexión a la BD para eliminar el sabor
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM SABOR WHERE ID_SABOR = @ID_SABOR", connection);
                    cmd.Parameters.AddWithValue("@ID_SABOR", ID_SABOR);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public decimal ObtenerPrecioSaborPorId(int idSabor)
        {
            decimal precio = 0;

            using (SqlConnection connection = BDConection.connect())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_OBTENER_PRECIO_SABOR", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_SABOR", idSabor);

                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        precio = Convert.ToDecimal(resultado);
                    }
                }
            }

            return precio;
        }

    }
}
