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
        [Key]
        public int Ocu_ID { get; set; }

        [MaxLength(50)]
        public string Ocu_Nombre { get; set; }
    }
}
