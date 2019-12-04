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
    public partial class CalculadoraPrestamos : ContentPage
    {
        public CalculadoraPrestamos()
        {
            InitializeComponent();
        }

        private async void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            decimal cuotas;
            decimal monto = decimal.Parse(txtMonto.Text);
            int meses = int.Parse(txtTiempo.Text);
            decimal interes = decimal.Parse(txtInteres.Text);
            decimal ganancia = monto * interes;
            cuotas = (monto / meses) + (ganancia/meses);
            cuotas = Math.Round(cuotas, 2);
            await DisplayAlert("Cálculo de cuotas", "La cuota para este préstamo será de RD$" + cuotas + " durante " + meses+" meses.", "OK");
        }
    }
}