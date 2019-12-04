using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrestApp.Views.Prestamista.Préstamos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePrestamosPage : ContentPage
    {
        public HomePrestamosPage()
        {
            InitializeComponent();
        }

        private void BtnCrearPrestamo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistroPrestamoPage());
        }
    }
}