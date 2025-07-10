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
           MetodosRelleno _registroRepositorioRelleno = new MetodosRelleno();

        public void RegistrarRelleno(List<Relleno> ListaNuevosRellenos)
        {
            _registroRepositorioRelleno.RegistrarRelleno(ListaNuevosRellenos);
        }

        public List<Relleno> ObtenerListaRelleno()
        {
            return _registroRepositorioRelleno.ObtenerListaRelleno();
        }

        public void ActualizarRelleno(Relleno relleno)
        {
            _registroRepositorioRelleno.ActualizarRelleno(relleno);
        }

        public void EliminarRelleno(int ID_RELLENO)
        {
            _registroRepositorioRelleno.EliminarRelleno(ID_RELLENO);
        }

        public void EditarRelleno(int ID_RELLENO, string NuevoNombre, string NuevaDescripcion, string PrecioRelleno)
        {
            _registroRepositorioRelleno.EditarRelleno(ID_RELLENO, NuevoNombre, NuevaDescripcion , PrecioRelleno);
        }


        }

    
}
