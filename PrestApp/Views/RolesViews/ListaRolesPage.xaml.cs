using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestApp.Clases;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace PrestApp.Views.RolesViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaRolesPage : ContentPage
    {
        List<Roles> roles;

        //List<Roles> listaRoles;
        //private const string Url = "https://prestapp.azurewebsites.net";
        private readonly HttpClient client = new HttpClient();

        private ObservableCollection<Roles> _roles;

        public ListaRolesPage()
        {
            InitializeComponent();
            //listaRoles = new List<Roles>();
            _roles = new ObservableCollection<Roles>();
            roles = new List<Roles>();
        }
        protected override async void OnAppearing()
        {
            /*listaRoles = await App.client.GetTable<Roles>().ToListAsync();
            rolesListView.ItemsSource = listaRoles;*/

            /*string content = await client.GetStringAsync(Url);
            List<Roles> roles = JsonConvert.DeserializeObject<List<Roles>>(content);
            _roles = new ObservableCollection<Roles>(roles);
            rolesListView.ItemsSource = _roles;*/

            var url = new Uri("https://prestapp.azurewebsites.net");

            client.BaseAddress = url;
            var resp = await client.GetAsync("api/Roles/Get");
            if (resp.IsSuccessStatusCode)
            {
                var repStr = resp.Content.ReadAsStringAsync();
                roles = JsonConvert.DeserializeObject<List<Roles>>(repStr.Result.ToString());
                _roles = new ObservableCollection<Roles>(roles);
                rolesListView.ItemsSource = _roles;
            }
            base.OnAppearing();
        }
    }
}