using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrestApp.Clases
{
    [SQLite.Table("Pagos")]
    public class ClPagos
    {
        [PrimaryKey, AutoIncrement]
        public int Pag_ID { get; set; }

        public int Cli_ID{ get; set; }
        [ForeignKey("Cli_ID")]
        public clClientes ClCliente { get; set; }

        public DateTime Pag_Fecha { get; set; }

        public double Pag_BalanceInicial { get; set; }

        public double Pag_CuotaPrestamo { get; set; }

        public double Pag_Interes { get; set; }

        public double Pag_CapitalPendiente { get; set; }

        public double Pag_MontoFinal { get; set; }

        public double Pag_InteresAcumulado { get; set; }
    }
}
