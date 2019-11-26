using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrestApp.Api.DataManagement.Database.Models
{
    [Table("Prestamos")]
    public class ClPrestamos
    {
        [Key]
        public int Prest_ID { get; set; }

        public int Cli_ID { get; set; }
        [ForeignKey("Cli_ID")]
        public ClClientes Cliente { get; set; }

        public decimal Prest_Monto { get; set; }

        public decimal Prest_Interes { get; set; }

        public byte Prest_Cuotas { get; set; }

        public DateTime Prest_FechaCreacion { get; set; }

        public DateTime Prest_FechaPrimerPago { get; set; }

    }
}
