using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrestApp.Views.Prestamista.Clientes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeClientesPage : ContentPage
    {
        public HomeClientesPage()
        {
            InitializeComponent();
        }

        private void BtnAgregarCliente_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistroClientesPage());
        }
    }
}