using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrestApp.Views.Informations;
using PrestApp.ViewModels;

namespace PrestApp.Views.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroUsuarioPage : ContentPage
    { 
        public RegistroUsuarioPage()
        {
            InitializeComponent();
            //BindingContext = new MainViewModel(Navigation);
        }

        private void BtnRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistroInformationPage());
        }
    }
}