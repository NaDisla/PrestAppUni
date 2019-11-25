using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrestApp.Api.DataManagement.Database.Models
{
    [Table("Roles")]
    public class ClRoles
    {
        [NotMapped]
        private int idRol;
        [Key]
        [Column("Rol_ID")]
        public int IDRol
        {
            get { return idRol; }
            set { idRol = value; }
        }
        [NotMapped]
        private string nombre;

        [Column("Rol_Nombre")]
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
