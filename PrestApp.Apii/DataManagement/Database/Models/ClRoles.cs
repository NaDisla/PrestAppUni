using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrestApp.Api.DataManagement.Database.Models
{
    public class ClRoles
    {
        private int idRol;
        [Key]
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
