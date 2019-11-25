using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestApp.Clases;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrestApp.Views.Roles;

namespace PrestApp.Views.Roles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroRolesPage : ContentPage
    {
        public RegistroRolesPage()
        {
            InitializeComponent();
        }

        private void BtnRegistroRol_Clicked(object sender, EventArgs e)
        {
            
        }

        private void BtnMostrarRoles_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaRolesPage());
        }
    }
}