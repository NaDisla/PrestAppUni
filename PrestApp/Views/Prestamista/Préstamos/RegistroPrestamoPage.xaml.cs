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


namespace PrestApp.Views.Prestamista.Préstamos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroPrestamoPage : ContentPage
    {
        public RegistroPrestamoPage()
        {
            InitializeComponent();
        }
        private async void BtnRegistroPrestamo_Clicked(object sender, EventArgs e)
        {
            ClPrestamos prestamo = new ClPrestamos
            {
                Cli_ID = 1,
                Prest_Monto = double.Parse(txtMonto.Text),
                Prest_Interes = double.Parse(txtInteres.Text),
                Prest_Cuotas = int.Parse(txtCuotas.Text),
                Prest_FechaCreacion = DateTime.Parse(txtFechaC.Text),
                Prest_FechaPrimerPago = DateTime.Parse(txtFechaP.Text)
            };

            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(prestamo);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            await client.PostAsync(String.Format("https://prestappapi.azurewebsites.net/api/prestamos/insert"), httpContent);
            await DisplayAlert("Registro correcto", "Se ha registrado el préstamo en PrestApp", "OK");

        }
    }
}