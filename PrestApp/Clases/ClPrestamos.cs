using System;
using System.Collections.Generic;
using System.Text;

namespace PrestApp.Clases
{
    public class ClPrestamos
    {
        public int Prest_ID { get; set; }
        public int Cli_ID { get; set; }
        public double Prest_Monto { get; set; }
        public double Prest_Interes { get; set; }
        public int Prest_Cuotas { get; set; }
        public DateTime Prest_FechaCreacion { get; set; }
        public DateTime Prest_FechaPrimerPago { get; set; }
    }
}
