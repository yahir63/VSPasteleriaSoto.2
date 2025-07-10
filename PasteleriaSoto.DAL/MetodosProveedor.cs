using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clientes.DAL;
using Microsoft.Data.SqlClient;
using PasteleriaSoto.DAL.Entities;

namespace PasteleriaSoto.DAL
{
    public class MetodosProveedor
    {
        public void RegistrarProveedor(List<Proveedor> ListaNuevosProveedores)
        {
           foreach (var proveedor in ListaNuevosProveedores)
            {
                try
                {
                    using (SqlConnection connection = BDConection.connect())
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("InsertarProveedor", connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                      
                        cmd.Parameters.AddWithValue("@NOMBREPROVEEDOR", proveedor.NOMBREPROVEEDOR);
                        cmd.Parameters.AddWithValue("@UBICACION", proveedor.UBICACION);
                        cmd.Parameters.AddWithValue("@TELEFONO", proveedor.TELEFONO);

                        cmd.ExecuteNonQuery();

                        connection.Close();
                    }


                }

                catch (Exception ex)
                {
                    
                    throw new Exception("Error al registrar proveedor: " + ex.Message);
                }
            }
        }

        public void ActualizarProveedor(Proveedor proveedor)
        {
            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("ActualizarProveedor", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_PROVEEDOR", proveedor.ID_PROVEEDOR);
                    cmd.Parameters.AddWithValue("@NOMBREPROVEEDOR", proveedor.NOMBREPROVEEDOR);
                    cmd.Parameters.AddWithValue("@UBICACION", proveedor.UBICACION);
                    cmd.Parameters.AddWithValue("@TELEFONO", proveedor.TELEFONO);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar proveedor: " + ex.Message);
            }
        }

        public List<Proveedor> ObtenerListProveedores()
        {
            List<Proveedor> ListaProveedores = new List<Proveedor>();
            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("ObtenerProveedores", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Proveedor proveedor = new Proveedor
                        {
                            ID_PROVEEDOR = Convert.ToInt32(reader["ID_PROVEEDOR"]),
                            NOMBREPROVEEDOR = reader["NOMBREPROVEEDOR"].ToString(),
                            UBICACION = reader["UBICACION"].ToString(),
                            TELEFONO = reader["TELÉFONO"].ToString(),
                        };
                        ListaProveedores.Add(proveedor);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lista de proveedores: " + ex.Message);
            }
            return ListaProveedores;
        }


        public void EliminarProveedor(int idProveedor)
        {
            try
            {
                using (SqlConnection connection = BDConection.connect())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("EliminarProveedor", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_PROVEEDOR", idProveedor);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar proveedor: " + ex.Message);
            }
        }
    }
}
