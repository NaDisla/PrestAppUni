using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrestApp.Api.DataManagement.Database.Models
{
    [Table("Pagos")]
    public class ClPagos
    {
        [Key]
        public int Pag_ID { get; set; }

        public int Cli_ID{ get; set; }
        [ForeignKey("Cli_ID")]
        public ClClientes ClCliente { get; set; }

        public DateTime Pag_Fecha { get; set; }

        public decimal Pag_BalanceInicial { get; set; }

        public decimal Pag_CuotaPrestamo { get; set; }

        public decimal Pag_Interes { get; set; }

        public decimal Pag_CapitalPendiente { get; set; }

        public decimal Pag_MontoFinal { get; set; }

        public decimal Pag_InteresAcumulado { get; set; }
    }
}
