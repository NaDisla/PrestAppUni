using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrestApp.Api.DataManagement.Database.Models
{
    [Table("Usuarios")]
    public class ClUsuarios
    {
        [Key]
        public int Usu_ID { get; set; }

        public int Rol_ID { get; set; }

        [ForeignKey("Rol_ID")]
        public ClRoles Rol { get; set; }

        [Required]
        [MaxLength(80)]
        public string Usu_NombreReal { get; set; }

        [Required]
        [MaxLength(30)]
        public string Usu_Nombre { get; set; }

        public byte[] Usu_Clave { get; set; }

        [NotMapped]
        public string Clave { get; set; }
    }
}
