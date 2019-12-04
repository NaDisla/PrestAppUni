using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PrestApp.Api.DataManagement.Database.Models
{
    [Table("Clientes")]
    public class ClClientes
    {
        [NotMapped]
        private int idCliente;
        [Key]
        [Column("Cli_ID")]
        public int IDCli
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        [NotMapped]
        private int idTítuloAcdm;
        [ForeignKey("TitAcdm_ID")]
        public int IDTitAcdm
        {
            get { return idTítuloAcdm; }
            set { idTítuloAcdm = value; }
        }
        [NotMapped]
        private int idOcupación;
        [ForeignKey("Ocu_ID")]
        public int IDOcu
        {
            get { return idOcupación; }
            set { idOcupación = value; }
        }
        private string nombres;
        [Column("Cli_Nombres")]
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        [NotMapped]
        private string apellidos;
        [Column("Cli_Apellidos")]
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        [NotMapped]
        private char género;
        [Column("Cli_Genero")]
        public char Genero
        {
            get { return género; }
            set { género = value; }
        }
        [NotMapped]
        private string cédula;
        [Column("Cli_Cédula")]
        public string Cli_Cedula
        {
            get { return cédula; }
            set { cédula = value; }
        }
        [NotMapped]
        private DateTime fechaNacimiento;
        [Column("Cli_FechaNacimiento")]
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        [NotMapped]
        private string telCasa;
        [Column("Cli_TelCasa")]
        public string TelCasa
        {
            get { return telCasa; }
            set { telCasa = value; }
        }
        [NotMapped]
        private string telCelular;
        [Column("Cli_TelCelular")]
        public string TelCelular
        {
            get { return telCelular; }
            set { telCelular = value; }
        }
        [NotMapped]
        private string estadoCivil;
        [Column("Cli_EstadoCivil")]
        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }
        [NotMapped]
        private int dependientes;
        [Column("Cli_Dependientes")]
        public int Dependientes
        {
            get { return dependientes; }
            set { dependientes = value; }
        }
        [NotMapped]
        private decimal ingresos;
        [Column("Cli_Ingresos")]
        public decimal Ingresos
        {
            get { return ingresos; }
            set { ingresos = value; }
        }
        [NotMapped]
        private string dirección;
        [Column("Cli_Dirección")]
        public string Dirección
        {
            get { return dirección; }
            set { dirección = value; }
        }
        [NotMapped]
        private string correo;
        [Column("Cli_Correo")]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

    }
}
