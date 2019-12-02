using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrestApp.Views.Informations;
using PrestApp.ViewModels;
using System.Net.Http;
using System.Collections.ObjectModel;
using PrestApp.Clases;
using Newtonsoft.Json;

namespace PrestApp.Views.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroUsuarioPage : ContentPage
    {
        private const string Url = "https://prestappapi.azurewebsites.net/api/usuarios/insert";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<ClUsuarios> _usuarios;
        //ClUsuarios nuevoUsuario = new ClUsuarios();
        public RegistroUsuarioPage()
        {
            InitializeComponent();
        }

        private async void BtnRegistro_Clicked(object sender, EventArgs e)
        {
                if (txtClaveRegistro.Text == txtConfirmarClave.Text)
                {

                    ClUsuarios usuario = new ClUsuarios
                    {
                        Rol_ID = 2,
                        Usu_NombreReal = txtNombreRealUsuario.Text,
                        Usu_Nombre = txtNombreUsuario.Text,
                        Usu_Pass = Encoding.UTF8.GetBytes(txtClaveRegistro.Text)
                    };
                HttpResponseMessage response = await client.GetAsync(Url);
                dynamic likesResult = await response.Content.ReadAsStringAsync();
                string content = JsonConvert.SerializeObject(usuario);
                await client.PostAsync(Url, new StringContent(content, Encoding.UTF8, "application/json"));
                 var users = (JsonConvert.DeserializeObject<IDictionary<string, object>>(likesResult.ToString()))["ClUsuarios"]["rolID"];
                //var users = JsonConvert.DeserializeObject<IDictionary<string, ClUsuarios>>(content);
                _usuarios = new ObservableCollection<ClUsuarios>(users);
                _usuarios.Insert(0, usuario);
                }
                else
                {
                    await DisplayAlert("Revisar contraseña", "Las contraseñas no coinciden. Intente nuevamente.", "OK");
                }
            //Navigation.PushAsync(new RegistroInformationPage());
        }
    }
}