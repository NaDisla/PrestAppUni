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

namespace PrestApp.Views.Roles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaRolesPage : ContentPage
    {
        private const string Url = "https://prestappapi.azurewebsites.net/api/roles/get";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<ClRoles> _roles;

        public ListaRolesPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(Url);
            List<ClRoles> roles = JsonConvert.DeserializeObject<List<ClRoles>>(content);
            _roles = new ObservableCollection<ClRoles>(roles);
            rolesListView.ItemsSource = _roles;

            base.OnAppearing();
        }
    }
}