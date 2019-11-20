using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrestApp.Api.DataManagement.Database.Models
{
    [Table("TitulosAcademicos")]
    public class ClTitulosAcademicos
    {
        [Key]
        public int TitAcdm_ID { get; set; }
        public string TitAcdm_Nombre { get; set; }
    }
}
