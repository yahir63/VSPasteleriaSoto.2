using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PantallasProyecto.DAL;
using PasteleriaSoto.DAL;

namespace PasteleriaSoto.BLL
{
    
        public class RegistroRepositoryRelleno
        {
            public void RegistrarRelleno(List<Relleno> ListaNuevosRellenos)
            {
                foreach (var Relleno in ListaNuevosRellenos)
                {
                    try
                    {
                        //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                        using (SqlConnection connection = BDConection.connect())
                        {
                            connection.Open();

                            SqlCommand cmd = new SqlCommand(("INSERT INTO RELLENO(NOMBRERELLENO, DESCRIPCION) VALUES(@NOMBRERELLENO, @DESCRIPCION) "), connection);

                            cmd.Parameters.AddWithValue("@NOMBRERELLENO", Relleno.NOMBRERELLENO);
                            cmd.Parameters.AddWithValue("@DESCRIPCION", Relleno.DESCRIPCION);


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

            public List<Relleno> ObtenerListaRelleno()
            {
                List<Relleno> ListaRellenos = new List<Relleno>();

                try
                {
                    using (SqlConnection connection = BDConection.connect())
                    {
                        connection.Open();

                        //Personalizar comando para Consultar datos del Estudiante
                        SqlCommand cmd = new SqlCommand("Select ID_RELLENO,NOMBRERELLENO,DESCRIPCION FROM RELLENO", connection);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            var relleno = new Relleno()
                            {

                                NOMBRERELLENO = reader["NOMBRERELLENO"].ToString(),
                                DESCRIPCION = reader["DESCRIPCION"].ToString(),
                                ID_RELLENO = Convert.ToInt32(reader["ID_RELLENO"].ToString())

                            };

                            ListaRellenos.Add(relleno);
                        }

                        connection.Close();

                        return ListaRellenos;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }


            public void ActualizarRelleno(Relleno relleno)

            {

                try
                {
                    //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                    using (SqlConnection connection = BDConection.connect())
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand(("UPDATE RELLENO SET NOMBRERELLENO =@NOMBRERELLENO, DESCRIPCION=@DESCRIPCION WHERE ID_RELLENO = @IdRelleno"), connection);

                        cmd.Parameters.AddWithValue("@NOMBRERELLENO", relleno.NOMBRERELLENO);
                        cmd.Parameters.AddWithValue("@DESCRIPCION", relleno.DESCRIPCION);

                        cmd.ExecuteNonQuery();

                        connection.Close();
                    }
                }
                catch (Exception)
                {

                    throw;
                }


            }

            public void EliminarRelleno(int ID_RELLENO)
            {

                try
                {

                    using (SqlConnection connection = BDConection.connect())
                    {
                        connection.Open();
                        //Aqui ejecutamos la consulta para eliminar el producto segun su id
                        SqlCommand cmd = new SqlCommand("delete from RELLENO where ID_RELLENO = @ID_RELLENO", connection);


                        cmd.Parameters.AddWithValue("@ID_RELLENO", ID_RELLENO);

                        cmd.ExecuteNonQuery();

                        connection.Close();
                    }
                }
                catch (Exception)
                {

                    throw;
                }



            }


            public void EditarRelleno(int ID_RELLENO, string NuevoNombre, string NuevaDescripcion)
            {

                try
                {

                    using (SqlConnection connection = BDConection.connect())
                    {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE RELLENO SET NOMBRERELLENO = @NOMBRERELLENO, DESCRIPCION = @DESCRIPCION WHERE ID_RELLENO = @ID_RELLENO", connection);
                       
                        cmd.Parameters.AddWithValue("@NOMBRERELLENO", NuevoNombre);
                        cmd.Parameters.AddWithValue("@DESCRIPCION", NuevaDescripcion);
                        cmd.Parameters.AddWithValue("@ID_RELLENO", ID_RELLENO);

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
