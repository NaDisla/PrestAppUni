using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrestApp.Clases
{
    [SQLite.Table("Prestamos")]
    public class ClPrestamos
    {
        [PrimaryKey, AutoIncrement]
        public int Prest_ID { get; set; }

        public int Cli_ID { get; set; }
        [ForeignKey("Cli_ID")]
        public clClientes cliente { get; set; }

        public double Prest_Monto { get; set; }

        public double Prest_Interes { get; set; }

        public int Prest_Cuotas { get; set; }

        public DateTime Prest_FechaCreacion { get; set; }

        public DateTime Prest_FechaPrimerPago { get; set; }

    }
}
