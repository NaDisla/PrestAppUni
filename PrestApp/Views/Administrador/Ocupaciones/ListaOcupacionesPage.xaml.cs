using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using PrestApp.Clases;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrestApp.Views.Administrador.Ocupaciones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaOcupacionesPage : ContentPage
    {
        private const string Url = "https://prestappapi.azurewebsites.net/api/ocupaciones/get";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<ClOcupaciones> _ocupaciones;

        public ListaOcupacionesPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(Url);
            List<ClOcupaciones> ocupaciones = JsonConvert.DeserializeObject<List<ClOcupaciones>>(content);
            _ocupaciones = new ObservableCollection<ClOcupaciones>(ocupaciones);
            ocupacionesListView.ItemsSource = _ocupaciones;

            base.OnAppearing();
        }

        private void BtnAgregarOcupacion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistroOcupacionesPage());
        }
    }
}