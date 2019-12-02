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
using System.Net.Http.Headers;

namespace PrestApp.Views.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroUsuarioPage : ContentPage
    {
        private const string Url = "https://prestappapi.azurewebsites.net/api/usuarios/insert";
        private readonly HttpClient client = new HttpClient();
        //private ObservableCollection<ClUsuarios> _usuarios;
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
                        RolID = 2,
                        UsuNombreReal = txtNombreRealUsuario.Text,
                        UsuNombre = txtNombreUsuario.Text,
                        UsuPass = Encoding.UTF8.GetBytes(txtClaveRegistro.Text)
                    };

                var client = new HttpClient();
                var json = JsonConvert.SerializeObject(usuario);
                HttpContent httpContent = new StringContent(json);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                await client.PostAsync(String.Format("https://prestappapi.azurewebsites.net/api/Usuarios/Insert"), httpContent);
                await DisplayAlert("Registro correcto", "Se ha registrado en PrestApp", "OK");

                /*HttpResponseMessage response = await client.GetAsync(Url);
                dynamic likesResult = await response.Content.ReadAsStringAsync();
                string content = JsonConvert.SerializeObject(usuario);
                await client.PostAsync(Url, new StringContent(content, Encoding.UTF8, "application/json"));
                 var users = (JsonConvert.DeserializeObject<IDictionary<string, object>>(likesResult.ToString()))["ClUsuarios"]["rolID"];
                //var users = JsonConvert.DeserializeObject<IDictionary<string, ClUsuarios>>(content);
                //_usuarios = new ObservableCollection<ClUsuarios>(users);
                //_usuarios.Insert(0, usuario);*/
            }
                else
                {
                    await DisplayAlert("Revisar contraseña", "Las contraseñas no coinciden. Intente nuevamente.", "OK");
                }
            //Navigation.PushAsync(new RegistroInformationPage());
        }
    }
}