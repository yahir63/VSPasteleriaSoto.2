using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Clientes.DAL;
using PasteleriaSoto.DAL;

using System.Data.Common;
using PantallasProyecto.DAL;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Identity.Client;
using System.Data;


namespace PasteleriaSoto.BLL
{

    public class RegistroRepositoryCliente
    {
        private MetodosCliente _registroRepositorioCliente = new MetodosCliente();
        public void RegistrarClientes(List<Cliente> ListaNuevosClientes)
        {
            _registroRepositorioCliente.RegistrarClientes(ListaNuevosClientes);    
        }

        public List<Cliente> ObtenerListaCliente()
        {
            return _registroRepositorioCliente.ObtenerListaCliente();
        }

        public void ActualizarCliente(Cliente cliente)
        {
            _registroRepositorioCliente.ActualizarCliente(cliente);
        }

        public void Eliminar(string CEDULA)
        {
            _registroRepositorioCliente.Eliminar(CEDULA);
        }
    }
}
        


