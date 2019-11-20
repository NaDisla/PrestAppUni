using System;
using System.Collections.Generic;
using System.Text;

namespace PrestApp.Clases
{
    public class ClUsuarios
    {
        public int Usu_ID { get; set; }
        public int Rol_ID { get; set; }
        public string Usu_NombreReal { get; set; }
        public string Usu_Nombre { get; set; }
        public byte[] Usu_Pass { get; set; }
    }
}
