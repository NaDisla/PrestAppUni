using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestApp.Clases;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace PrestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaRolesPage : ContentPage
    {
        List<Roles> listaRoles;
        public ListaRolesPage()
        {
            InitializeComponent();
            listaRoles = new List<Roles>();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using(var conn = new SQLiteConnection(App._rutaBD))
            {
                conn.CreateTable<Roles>();
                listaRoles = conn.Table<Roles>().ToList();

                rolesListView.ItemsSource = listaRoles;
            }
        }
    }
}