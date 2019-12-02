using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;


namespace PrestApp.Clases
{
    public class ClUsuarios : INotifyPropertyChanged
    {
        public int Rol_ID { get; set; }

        private string _usuNombreReal;
        [JsonProperty("nombreReal")]
        public string Usu_NombreReal
        {
            get => _usuNombreReal;
            set
            {
                _usuNombreReal = value;
                OnPropertyChanged();
            }
        }

        private string _usuNombre;
        [JsonProperty("nombre")]
        public string Usu_Nombre
        {
            get => _usuNombre;
            set
            {
                _usuNombre = value;
                OnPropertyChanged();
            }
        }

        private byte[] _usuPass;
        [JsonProperty("password")]
        public byte[] Usu_Pass
        {
            get => _usuPass;
            set
            {
                _usuPass = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
