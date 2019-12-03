using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrestApp.Api.DataManagement.Database.Models
{
    [Table("Ocupaciones")]
    public class ClOcupaciones
    {
        [NotMapped]
        private int idOcu;
        [Key]
        [Column("Ocu_ID")]
        public int IDOcu
        {
            get {return idOcu; }
            set {idOcu = value; }
        }
        [NotMapped]
        private string nombre;

        [Column("Ocu_Nombre")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
