using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrestApp.Clases
{
    [SQLite.Table("Amortizaciones")]
    public class ClAmortizaciones
    {
        [PrimaryKey, AutoIncrement]
        public int Amort_ID { get; set; }

        public int Prest_ID { get; set; }

        public int Cli_ID { get; set; }
        [ForeignKey("Cli_ID")]
        public ClClientes Clientes { get; set; }

        public int ModPag_ID { get; set; }
        [ForeignKey("ModPag_ID")]
        public ClModalidadesDePago ClModalidadesDePago { get; set; }
    }
}
