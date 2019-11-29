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
        List<Roles> listaRoles;
        //private const string Url = "";
        //private readonly HttpClient client = new HttpClient();
        //private ObservableCollection<ClRoles> _roles;

        public ListaRolesPage()
        {
            InitializeComponent();
            listaRoles = new List<Roles>();
            //_roles = new ObservableCollection<ClRoles>();
        }
        protected override async void OnAppearing()
        {
            listaRoles = await App.client.GetTable<Roles>().ToListAsync();
            rolesListView.ItemsSource = listaRoles;

            /*string content = await client.GetStringAsync(Url);
            List<Roles> roles = JsonConvert.DeserializeObject<List<Roles>>(content);
            listaRoles = new ObservableCollection<Roles>(roles);
            rolesListView.ItemsSource = listaRoles;*/

            //var url = new Uri("");
            //var roles = new List<ClRoles>();

            //client.BaseAddress = url;
            //var resp = await client.GetAsync("api/Roles/Get");
            //if (resp.IsSuccessStatusCode)
            //{
            //    var repStr = resp.Content.ReadAsStringAsync();
            //    roles = JsonConvert.DeserializeObject<List<ClRoles>>(repStr.Result.ToString());
            //    _roles = new ObservableCollection<ClRoles>(roles);

            //}
            base.OnAppearing();
        }
    }
}