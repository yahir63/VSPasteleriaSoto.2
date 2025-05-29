using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PasteleriaSoto.DAL
{
    public class MetodosBano
    {
        public void RegistrarBano(List<Bano> ListaNuevoBano)
        {
            foreach (var Bano in ListaNuevoBano)
            {
                try
                {

                    using (SqlConnection connection = BDConection.connect())
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO BANO(NOMBREBANO, DESCRIPCION, PRECIO) VALUES(@NOMBREBANO, @DESCRIPCION, @PRECIO) ", connection);

                        cmd.Parameters.AddWithValue("@NOMBREBANO", Bano.NOMBREBANO);
                        cmd.Parameters.AddWithValue("@DESCRIPCION", Bano.DESCRIPCION);
                        cmd.Parameters.AddWithValue("@PRECIO", Bano.PRECIO);

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

        public List<Bano> ObtenerListaBano()
        {
            List<Bano> ListaBano = new List<Bano>();

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();


                    SqlCommand cmd = new SqlCommand("Select ID_BANO,NOMBREBANO,DESCRIPCION, PRECIO FROM BANO", connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var bano = new Bano()
                        {

                            NOMBREBANO = reader["NOMBREBANO"].ToString(),
                            DESCRIPCION = reader["DESCRIPCION"].ToString(),
                            PRECIO = reader["PRECIO"].ToString(),
                            ID_BANO = Convert.ToInt32(reader["ID_BANO"].ToString())

                        };

                        ListaBano.Add(bano);
                    }

                    connection.Close();

                    return ListaBano;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void ActualizarBano(Bano bano)

        {

            try
            {

                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(("UPDATE BANO SET NOMBREBANO =@NOMBREBANO, DESCRIPCION=@DESCRIPCION, PRECIO=@PRECIO WHERE ID_BANO = @ID_BANO"), connection);

                    cmd.Parameters.AddWithValue("@ID_BANO", bano.ID_BANO);
                    cmd.Parameters.AddWithValue("@NOMBREBANO", bano.NOMBREBANO);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", bano.DESCRIPCION);
                    cmd.Parameters.AddWithValue("@PRECIO", bano.PRECIO);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void EliminarBano(int ID_BANO)
        {

            try
            {

                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("delete from BANO where ID_BANO = @ID_BANO", connection);


                    cmd.Parameters.AddWithValue("@ID_BANO", ID_BANO);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }



        }


        public void EditarBano(int ID_BANO, string NuevoNombreBano, string NuevaDescripcionBano)
        {

            try
            {

                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE BANO SET NOMBREBANO = @NOMBREBANO, DESCRIPCION = @DESCRIPCION WHERE ID_BANO = @ID_BANO", connection);

                    cmd.Parameters.AddWithValue("@NOMBREBANO", NuevoNombreBano);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", NuevaDescripcionBano);
                    cmd.Parameters.AddWithValue("@ID_BANO", ID_BANO);


                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }



        }

        public decimal ObtenerPrecioBano(int idBano)
        {
            decimal preciobano = 0;

            using (SqlConnection connection = BDConection.connect())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SP_OBTENER_PRECIO_BANO", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_BANO", idBano);

                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        preciobano = Convert.ToDecimal(resultado);
                    }
                }
            }

            return preciobano;
        }
    }
}
