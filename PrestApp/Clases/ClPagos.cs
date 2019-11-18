using System;
using System.Collections.Generic;
using System.Text;

namespace PrestApp.Clases
{
    public class ClPagos
    {
        public int Pag_ID { get; set; }
        public int Cli_ID{ get; set; }
        public DateTime Pag_Fecha { get; set; }
        public double Pag_BalanceInicial { get; set; }
        public double Pag_CuotaPrestamo { get; set; }
        public double Pag_Interes { get; set; }
        public double Pag_CapitalPendiente { get; set; }
        public double Pag_MontoFinal { get; set; }
        public double Pag_InteresAcumulado { get; set; }
    }
}
