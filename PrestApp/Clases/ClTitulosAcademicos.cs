using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestApp.Clases
{
    [Table("TitulosAcademicos")]
    public class ClTitulosAcademicos
    {
        [PrimaryKey, AutoIncrement]
        public int TitAcdm_ID { get; set; }
        public string TitAcdm_Nombre { get; set; }
    }
}
