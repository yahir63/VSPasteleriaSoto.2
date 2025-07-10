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
    public class RegistroRepositoryCAT
    {
        public MetodosCategoria _registroRepositorioCAT = new MetodosCategoria();

        public List<Categoria> MostrarCategorias()
        {
            return _registroRepositorioCAT.MostrarCategorias();
        }

        public void RegistrarCategorias(List<Categoria> ListaNuevasCategorias)
        {
            _registroRepositorioCAT.RegistrarCategorias(ListaNuevasCategorias);
        }

        public void ActualizarCategoria(Categoria categoria)
        {
            _registroRepositorioCAT.ActualizarCategoria(categoria);
        }

        public void EliminarCategoria(int ID_CATEGORIA)
        {
            _registroRepositorioCAT.EliminarCategoria( ID_CATEGORIA);
        }

    }
}

