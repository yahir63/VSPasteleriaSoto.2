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
    public class MetodosRelleno
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

                        SqlCommand cmd = new SqlCommand(("INSERT INTO RELLENO(NOMBRERELLENO, DESCRIPCION, PRECIORELLENO) VALUES(@NOMBRERELLENO, @DESCRIPCION,@PRECIORELLENO) "), connection);

                        cmd.Parameters.AddWithValue("@NOMBRERELLENO", Relleno.NOMBRERELLENO);
                        cmd.Parameters.AddWithValue("@DESCRIPCION", Relleno.DESCRIPCION);
                        cmd.Parameters.AddWithValue("@PRECIORELLENO", Relleno.PRECIORELLENO);


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
                    SqlCommand cmd = new SqlCommand("Select ID_RELLENO,NOMBRERELLENO,DESCRIPCION,PRECIORELLENO FROM RELLENO", connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var relleno = new Relleno()
                        {

                            NOMBRERELLENO = reader["NOMBRERELLENO"].ToString(),
                            DESCRIPCION = reader["DESCRIPCION"].ToString(),
                            PRECIORELLENO = reader["PRECIORELLENO"].ToString(),
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

                    SqlCommand cmd = new SqlCommand(("UPDATE RELLENO SET NOMBRERELLENO =@NOMBRERELLENO, DESCRIPCION=@DESCRIPCION, PRECIORELLENO=@PRECIORELLENO WHERE ID_RELLENO = @ID_RELLENO"), connection);

                    cmd.Parameters.AddWithValue("@NOMBRERELLENO", relleno.NOMBRERELLENO);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", relleno.DESCRIPCION);
                    cmd.Parameters.AddWithValue("@PRECIORELLENO", relleno.PRECIORELLENO);
                    cmd.Parameters.AddWithValue("@ID_RELLENO", relleno.ID_RELLENO);

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


        public void EditarRelleno(int ID_RELLENO, string NuevoNombre, string NuevaDescripcion, string PrecioRelleno)
        {

            try
            {

                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE RELLENO SET NOMBRERELLENO = @NOMBRERELLENO, DESCRIPCION = @DESCRIPCION, PRECIORELLENO=@PRECIORELLENO WHERE ID_RELLENO = @ID_RELLENO", connection);

                    cmd.Parameters.AddWithValue("@NOMBRERELLENO", NuevoNombre);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", NuevaDescripcion);
                    cmd.Parameters.AddWithValue("@ID_RELLENO", ID_RELLENO);
                    cmd.Parameters.AddWithValue("@PRECIORELLENO", PrecioRelleno); 


                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }



        }

        public decimal ObtenerPrecioRelleno(int idRelleno)
        {
            decimal preciorelleno = 0;

            using (SqlConnection connection = BDConection.connect())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_OBTENER_PRECIO_RELLENO", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_RELLENO", idRelleno);

                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        preciorelleno = Convert.ToDecimal(resultado);
                    }
                }
            }

            return preciorelleno;
        }
    }
}
