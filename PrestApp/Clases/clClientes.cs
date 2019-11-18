using System;
using System.Collections.Generic;
using System.Text;

namespace PrestApp.Clases
{
    public class ClClientes
    {
        public int IDCliente { get; set; }
        public int IDTituloAcdm { get; set; }
        public int IDOcupacion { get; set; }
        public string  Nombres { get; set; }
        public string Apellidos { get; set; }
        public char Genero { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TelCasa { get; set; }
        public string TelCelular { get; set; }
        public string EstadoCivil { get; set; }
        public int Dependientes { get; set; }
        public decimal Ingresos { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
    }
}
