using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;


namespace PrestApp.Clases
{
    public class ClUsuarios
    {
        public int RolID
        {
            get;
            set;
        }
        public string UsuNombreReal
        {
            get;
            set;
        }
        public string UsuNombre
        {
            get;
            set;
        }
        public byte[] UsuPass
        {
            get;
            set;
        }

    }
}
