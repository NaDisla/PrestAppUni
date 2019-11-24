using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrestApp.Views.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneralLoginPage : ContentPage
    {
        public GeneralLoginPage()
        {
            InitializeComponent();
        }

        private void BtnRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistroUsuarioPage());
        }
    }
}