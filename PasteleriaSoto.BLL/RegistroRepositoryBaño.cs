using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PasteleriaSoto.DAL;

namespace PasteleriaSoto.BLL
{
    public class RegistroRepositoryBaño
    {
      MetodosBano registroRepositoryBano = new MetodosBano();
        public void RegistrarBano(List<Bano> ListaNuevoBano)
        {
            registroRepositoryBano.RegistrarBano(ListaNuevoBano);
        }
        public List<Bano> ObtenerListaBano()
        {
            return registroRepositoryBano.ObtenerListaBano();

        }

        public void ActualizarBano(Bano bano)
        {

            registroRepositoryBano.ActualizarBano(bano);
        }
        public void EliminarBano(int ID_BANO)
        {
            registroRepositoryBano.EliminarBano(ID_BANO);
        }
        public void EditarBano(int ID_BANO, string NuevoNombre, string NuevaDescripcion)
        {
            registroRepositoryBano.EditarBano(ID_BANO, NuevoNombre, NuevaDescripcion);
        }

    }
}
