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
        private int ocu_ID;
        [Key]
        [Column("Ocu_ID")]
        public int IDOcu
        {
            get {return ocu_ID; }
            set {ocu_ID = value; }
        }
        [NotMapped]
        private string ocu_Nombre;

        [Column("Ocu_Nombre")]
        public string Nombre
        {
            get { return ocu_Nombre; }
            set { ocu_Nombre = value; }
        }
    }
}
