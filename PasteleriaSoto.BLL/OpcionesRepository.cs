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
}

}



