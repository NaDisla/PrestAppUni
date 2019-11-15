using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrestApp.Api.DataManagement.Database.Models
{
    public class ClClientes
    {
        private int idCliente;

        [Key]
        public int IDCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        private int idTítuloAcdm;

        public int IDTítuloAcdm
        {
            get { return idTítuloAcdm; }
            set { idTítuloAcdm = value; }
        }

        private int idOcupación;

        public int IDOcupación
        {
            get { return idOcupación; }
            set { idOcupación = value; }
        }

        private string nombres;

        public string  Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private char género;

        public char Género
        {
            get { return género; }
            set { género = value; }
        }

        private string cédula;

        public string Cédula
        {
            get { return cédula; }
            set { cédula = value; }
        }
        private string fechaNacimiento;

        public string FechaNacimiento
        {
            get { return string.Format("{0:dd-MM-yy}",fechaNacimiento); }
            set { fechaNacimiento = value; }
        }

        private string telCasa;

        public string TelCasa
        {
            get { return telCasa; }
            set { telCasa = value; }
        }

        private string telCelular;

        public string TelCelular
        {
            get { return telCelular; }
            set { telCelular = value; }
        }

        private string estadoCivil;

        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        private int dependientes;

        public int Dependientes
        {
            get { return dependientes; }
            set { dependientes = value; }
        }

        private decimal ingresos;

        public decimal Ingresos
        {
            get { return ingresos; }
            set { ingresos = value; }
        }

        private string dirección;

        public string Dirección
        {
            get { return dirección; }
            set { dirección = value; }
        }

        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

    }
}
