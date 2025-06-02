using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PasteleriaSoto.DAL
{
    public class BDConection
    {
        //Campo donde se define la cadena de conexion a la BD
        private static string connectionString = "Server=DIOSESTODO\\SQLEXPRESS;Database=IMPULSOPASTELERO;Trusted_Connection=true;TrustServerCertificate=true ";

        //Metodo para retornar la cadena de conexion en tipo SqlConnection
        public static SqlConnection connect()
        {
            return new SqlConnection(connectionString);
        }


    }


}
