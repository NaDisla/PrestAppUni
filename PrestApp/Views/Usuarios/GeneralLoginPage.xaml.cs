using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PrestApp.Clases;
using Xamarin.Forms.Xaml;
using PrestApp.Views.Prestamista;
using PrestApp.Views.Administrador;
using PrestApp.Views.Usuarios;
using System.Net.Http;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace PrestApp.Views.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneralLoginPage : ContentPage
    {
        private const string Url = "https://prestappapi.azurewebsites.net/api/Usuarios/Get";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<ClUsuarios> _usuarios;

        public GeneralLoginPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            ListaUsuariosPage listUsers = new ListaUsuariosPage();

            string content = await client.GetStringAsync(Url);
            List<ClUsuarios> user = JsonConvert.DeserializeObject<List<ClUsuarios>>(content);
            _usuarios = new ObservableCollection<ClUsuarios>(user);
            //liItemsSource = _usuarios;

            base.OnAppearing();
        }
        private void BtnRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistroUsuarioPage());
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            if(txtUsuarioLogin.Text == "admin" && txtClaveLogin.Text == "1234")
            {
                Navigation.PushAsync(new MasterAdministradorPage());
                DisplayAlert("Inicio de sesión satisfactorio", "Bienvenido(a) " + txtUsuarioLogin.Text, "Continuar");
            }
            else if(txtUsuarioLogin.Text == "nadisla" && txtClaveLogin.Text == "1908")
            {
                Navigation.PushAsync(new MasterPrestamistaPage());
                DisplayAlert("Inicio de sesión satisfactorio", "Bienvenido(a) " + txtUsuarioLogin.Text, "Continuar");
            }
        }
    }
}