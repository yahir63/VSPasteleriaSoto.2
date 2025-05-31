using Microsoft.Data.SqlClient;
using PantallasProyecto.DAL;
using PasteleriaSoto.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteleriaSoto.BLL
{
    public class RegistroRepositoryPRODUCTO
    {
        MetodosProductos RepositoryPRODUCTO = new MetodosProductos();
        public void RegistrarProductos(List<Producto> ListaNuevosProductos)
        {
            RepositoryPRODUCTO.RegistrarProductos(ListaNuevosProductos);
        }

        public List<Producto> ObtenerListProductosTemp()
        {
            return RepositoryPRODUCTO.ObtenerListProductos();
        }

        public void ActualizarProducto(Producto producto)
        {
            RepositoryPRODUCTO.ActualizarProducto(producto);
        }

        public void Eliminar(int ID_PRODUCTO)
        {
            RepositoryPRODUCTO.Eliminar(ID_PRODUCTO); 
        }

        


    }
}
