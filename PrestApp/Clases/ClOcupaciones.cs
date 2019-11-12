using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestApp.Clases
{
    [Table("Ocupaciones")]
    public class ClOcupaciones
    {
        [PrimaryKey, AutoIncrement]
        public int Ocu_ID { get; set; }

        [Unique]
        [MaxLength(50)]
        public string Ocu_Nombre { get; set; }
    }
}
