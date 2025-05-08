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
    public class RegistroRepositoryNuevoUsuario
    {
        public void RegistrarUsuario(List<Usuario> ListaNuevosUsuarios)
        {
            foreach (var Usuario in ListaNuevosUsuarios)
            {
                try
                {
                    //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                    using (SqlConnection connection = BDConection.connect())
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand(("INSERT INTO USUARIO(NOMBREUSUARIO,CLAVE) VALUES(@NOMBREUSUARIO,@CLAVE) "), connection);

                        cmd.Parameters.AddWithValue("@NOMBREUSUARIO", Usuario.NOMBREUSUARIO);
                        cmd.Parameters.AddWithValue("@CLAVE", Usuario.CLAVE);



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
}
