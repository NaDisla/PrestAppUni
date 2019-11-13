using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PrestApp.Clases
{
    public class ClRoles
    {
        private int idRol;
        [PrimaryKey, AutoIncrement]
        public int IDRol
        {
            get { return idRol; }
            set { idRol = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /*public override string ToString()
        {
            return string.Format("{0} {1}", IDRol, Nombre);
        }*/
    }
}
