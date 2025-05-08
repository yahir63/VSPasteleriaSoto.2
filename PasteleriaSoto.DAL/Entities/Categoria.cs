using System;
using System.Collections.Generic;
using System.Text;

namespace PantallasProyecto.DAL
{
    public class Categoria
    {
      public int ID_CATEGORIA { get; set; }
      public string NOMBRECATEGORIA { get; set; }
      public string DESCRIPCION { get; set; }  
      public bool ESTADO { get; set; }
    }
}
