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
    public class RepositorioSabor
    {

        public MetodoSabor metodoSabor = new MetodoSabor();

        // Obtener todos los sabores
        public List<Sabor> ObtenerSabores()
        {
            return metodoSabor.ObtenerSabores();
        }

        // Agregar un nuevo sabor
        public void AgregarNuevoSabor(Sabor sabor)
        {
            metodoSabor.AgregarSabor(sabor);
        }

        // Registrar varios sabores
        public void RegistrarSabor(List<Sabor> lista)
        {
            metodoSabor.RegistrarSabor(lista);
        }

        // Actualizar un sabor existente
        public void ActualizarSabor(Sabor sabor)
        {
            metodoSabor.ActualizarSabor(sabor);
        }

        // Eliminar un sabor por ID
        public void EliminarSabor(int id)
        {
            metodoSabor.EliminarSabor(id);
        }



    } 
}

