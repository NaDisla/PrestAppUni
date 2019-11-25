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
        private int idCliente;

        [Key]
        public int Cli_ID
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        private int idTítuloAcdm;

        public int TitAcdm_ID
        {
            get { return idTítuloAcdm; }
            set { idTítuloAcdm = value; }
        }

        private int idOcupación;

        public int Ocu_ID
        {
            get { return idOcupación; }
            set { idOcupación = value; }
        }

        private string nombres;

        public string Cli_Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string apellidos;

        public string Cli_Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private char género;

        public char Cli_Genero
        {
            get { return género; }
            set { género = value; }
        }

        private string cédula;

        public string Cli_Cedula
        {
            get { return cédula; }
            set { cédula = value; }
        }
        private string fechaNacimiento;

        public string Cli_FechaNacimiento
        {
            get { return string.Format("{0:dd-MM-yy}",fechaNacimiento); }
            set { fechaNacimiento = value; }
        }

        private string telCasa;

        public string Cli_TelCasa
        {
            get { return telCasa; }
            set { telCasa = value; }
        }

        private string telCelular;

        public string Cli_TelCelular
        {
            get { return telCelular; }
            set { telCelular = value; }
        }

        private string estadoCivil;

        public string Cli_EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        private int dependientes;

        public int Cli_Dependientes
        {
            get { return dependientes; }
            set { dependientes = value; }
        }

        private decimal ingresos;

        public decimal Cli_Ingresos
        {
            get { return ingresos; }
            set { ingresos = value; }
        }

        private string dirección;

        public string Cli_Direccion
        {
            get { return dirección; }
            set { dirección = value; }
        }

        private string correo;

        public string Cli_Correo
        {
            get { return correo; }
            set { correo = value; }
        }

    }
}
