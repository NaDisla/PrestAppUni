using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrestApp.Clases;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace PrestApp.Views.Administrador.Ocupaciones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroOcupacionesPage : ContentPage
    {
        public RegistroOcupacionesPage()
        {
            InitializeComponent();
        }

        private async void BtnRegistroOcupacion_Clicked(object sender, EventArgs e)
        {
            ClOcupaciones ocupacion = new ClOcupaciones
            {
                ocu_Nombre = txtNombre.Text
            };

            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(ocupacion);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            await client.PostAsync(String.Format("https://prestappapi.azurewebsites.net/api/ocupaciones/insert"), httpContent);
            await DisplayAlert("Registro correcto", "Se ha registrado la ocupación en PrestApp", "OK");

        }
    }
}