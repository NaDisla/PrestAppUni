using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrestApp.Api.DataManagement.Database.Models
{
    [Table("ModalidadesDePago")]
    public class ClModalidadesDePago
    {
        [Key]
        public int ModPag_ID { get; set; }

        [MaxLength(30)]        
        public string ModPag_Nombre { get; set; }
    }
}
