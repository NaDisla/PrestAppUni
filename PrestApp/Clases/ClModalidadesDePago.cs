using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestApp.Clases
{
    [Table("ModalidadesDePago")]
    public class ClModalidadesDePago
    {
        [PrimaryKey, AutoIncrement]
        public int ModPag_ID { get; set; }

        [MaxLength(30)]
        [Unique]
        public string ModPag_Nombre { get; set; }
    }
}
