using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasteleriaSoto.DAL;
using PasteleriaSoto.DAL.Entities;

namespace PasteleriaSoto.BLL
{
    public class RepositoryProveedor
    {
        private MetodosProveedor _metodosProveedor = new MetodosProveedor();
        public void RegistrarProveedor(List<Proveedor> ListaNuevosProveedores)
        {
            _metodosProveedor.RegistrarProveedor(ListaNuevosProveedores);
        }
        public void ActualizarProveedor(Proveedor proveedor)
        {
            _metodosProveedor.ActualizarProveedor(proveedor);
        }

        public List<Proveedor> ObtenerListaProveedores()
        {
            return _metodosProveedor.ObtenerListProveedores();
        }

        public void EliminarProveedor(int idProveedor)
        {
            _metodosProveedor.EliminarProveedor(idProveedor);
        }
    }
}
