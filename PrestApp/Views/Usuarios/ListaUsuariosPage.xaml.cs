using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestApp.Clases;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace PrestApp.Views.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaUsuariosPage : ContentPage
    {
        private const string Url = "https://prestappapi.azurewebsites.net/api/usuarios/get";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<ClUsuarios> _usuarios;

        public ListaUsuariosPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(Url);
            List<ClUsuarios> usuarios = JsonConvert.DeserializeObject<List<ClUsuarios>>(content);
            _usuarios = new ObservableCollection<ClUsuarios>(usuarios);
            usuariosListView.ItemsSource = _usuarios;

            /*var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://prestappapi.azurewebsites.net/api/usuarios/get");
            var usuario = JsonConvert.DeserializeObject<List<ClUsuarios>>(response);
            usuariosListView.ItemsSource = usuario;*/

            base.OnAppearing();
        }
    }
}