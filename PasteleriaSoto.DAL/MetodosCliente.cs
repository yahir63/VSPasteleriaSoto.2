using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clientes.DAL;
using Microsoft.Data.SqlClient;

namespace PasteleriaSoto.DAL
{
    public class MetodosCliente
    {
        public void RegistrarClientes(List<Cliente> ListaNuevosClientes)
        {
            foreach (var cliente in ListaNuevosClientes)
            {
                try
                {
                    //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                    using (SqlConnection connection = BDConection.connect())
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand(("INSERT INTO CLIENTE(NOMBRECLIENTE,DIRECCIONCLIENTE,TELEFONOCLIENTE,CIUDAD,CEDULA) VALUES(@NOMBRECLIENTE,@DIRECCIONCLIENTE,@TELEFONOCLIENTE,@CIUDAD,@CEDULA) "), connection);

                        cmd.Parameters.AddWithValue("@NOMBRECLIENTE", cliente.NOMBRECLIENTE);
                        cmd.Parameters.AddWithValue("@DIRECCIONCLIENTE", cliente.DIRECCIONCLIENTE);
                        cmd.Parameters.AddWithValue("@TELEFONOCLIENTE", cliente.TELEFONOCLIENTE);
                        cmd.Parameters.AddWithValue("@CIUDAD", cliente.CIUDAD);
                        cmd.Parameters.AddWithValue("@CEDULA", cliente.CEDULA);

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

        public List<Cliente> ObtenerListaCliente()
        {
            List<Cliente> ListaClientes = new List<Cliente>();

            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    //Personalizar comando para Consultar datos del Estudiante
                    SqlCommand cmd = new SqlCommand("Select ID_CLIENTE,NOMBRECLIENTE,DIRECCIONCLIENTE,TELEFONOCLIENTE,CEDULA,CIUDAD FROM CLIENTE", connection);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var cliente = new Cliente()
                        {
                            ID_CLIENTE = Convert.ToInt32(reader["ID_CLIENTE"]),
                            NOMBRECLIENTE = reader["NOMBRECLIENTE"].ToString(),
                            DIRECCIONCLIENTE = reader["DIRECCIONCLIENTE"].ToString(),
                            TELEFONOCLIENTE = reader["TELEFONOCLIENTE"].ToString(),
                            CIUDAD = reader["CIUDAD"].ToString(),
                            CEDULA = reader["CEDULA"].ToString(),
                        };

                        ListaClientes.Add(cliente);
                    }

                    connection.Close();

                    return ListaClientes;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void ActualizarCliente(Cliente cliente)

        {

            try
            {
                //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(("UPDATE CLIENTE SET NOMBRECLIENTE =@NOMBRECLIENTE, DIRECCIONCLIENTE=@DIRECCIONCLIENTE, TELEFONOCLIENTE =@TELEFONOCLIENTE, CIUDAD = @CIUDAD WHERE CEDULA = @CEDULA"), connection);

                    cmd.Parameters.AddWithValue("@NOMBRECLIENTE", cliente.NOMBRECLIENTE);
                    cmd.Parameters.AddWithValue("@DIRECCIONCLIENTE", cliente.DIRECCIONCLIENTE);
                    cmd.Parameters.AddWithValue("@TELEFONOCLIENTE", cliente.TELEFONOCLIENTE);
                    cmd.Parameters.AddWithValue("@CIUDAD", cliente.CIUDAD);
                    cmd.Parameters.AddWithValue("@CEDULA", cliente.CEDULA);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void Eliminar(string CEDULA)

        {
            try
            {
                //Vamos a usar la conexion a la BD para el registro de nuevos pedidos
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("delete from CLIENTE where CEDULA = @CEDULA", connection);


                    cmd.Parameters.AddWithValue("@CEDULA", CEDULA);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }



        }


        public Cliente ObtenerClientePorCedula(string cedula)
        {
            Cliente cliente = null;
            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SP_BUSCAR_CLIENTE", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CEDULA", cedula);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        cliente = new Cliente()
                        {
                            ID_CLIENTE = Convert.ToInt32(reader["ID_CLIENTE"]),
                            NOMBRECLIENTE = reader["NOMBRECLIENTE"].ToString(),
                            DIRECCIONCLIENTE = reader["DIRECCIONCLIENTE"].ToString(),
                            TELEFONOCLIENTE = reader["TELEFONOCLIENTE"].ToString(),
                            CIUDAD = reader["CIUDAD"].ToString(),
                            CEDULA = reader["CEDULA"].ToString()
                        };
                    }
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return cliente;
        }





    }
}
