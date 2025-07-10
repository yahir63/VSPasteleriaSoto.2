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
        MetodosUsuario _registroRepositorioUsuario = new MetodosUsuario();
        public void RegistrarUsuario(List<Usuario> ListaNuevosUsuarios)
        {
            _registroRepositorioUsuario.RegistrarUsuario(ListaNuevosUsuarios);
        }
    }
}
