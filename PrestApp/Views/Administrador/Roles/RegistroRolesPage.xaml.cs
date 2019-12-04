using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestApp.Clases;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrestApp.Views.Administrador.Roles;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace PrestApp.Views.Administrador.Roles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroRolesPage : ContentPage
    {
        public RegistroRolesPage()
        {
            InitializeComponent();
        }

        private async void BtnRegistroRol_Clicked(object sender, EventArgs e)
        {
            ClRoles rol = new ClRoles
            {
                Nombre = txtNombre.Text
            };

            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(rol);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await client.PostAsync(String.Format("https://prestappapi.azurewebsites.net/api/Roles/Insert"), httpContent);

            await DisplayAlert("Registro correcto", "Se ha registrado el rol en PrestApp", "OK");
        }

        private void BtnMostrarRoles_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaRolesPage());
        }
    }
}