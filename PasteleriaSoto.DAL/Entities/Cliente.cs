using System;
using System.Collections.Generic;
using System.Text;

namespace Clientes.DAL
{
    public class Cliente
    {
     public int ID_CLIENTE {  get; set; }
        public string NOMBRECLIENTE{ get; set; }
        public string DIRECCIONCLIENTE { get; set; }
        public string TELEFONOCLIENTE {  get; set; }
        public string CIUDAD { get; set; }
        public string? CEDULA { get; set; }
    }
}
