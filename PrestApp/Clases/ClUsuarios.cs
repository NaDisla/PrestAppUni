using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SQLite;

namespace PrestApp.Clases
{
    public class ClUsuarios
    {
        [PrimaryKey, AutoIncrement]
        public int Usu_ID { get; set; }

        public int Rol_ID { get; set; }

        [ForeignKey("Rol_ID")]
        public ClRoles Rol { get; set; }

        [Required]
        [SQLite.MaxLength(80)]
        public string Usu_NombreReal { get; set; }

        [Required]
        [SQLite.MaxLength(30)]
        public string Usu_Nombre { get; set; }

        [Required]
        [SQLite.MaxLength(30)]
        [DataType(DataType.Password)]
        public string Usu_Pass { get; set; }
    }
}
