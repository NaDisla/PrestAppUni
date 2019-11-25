using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrestApp.Views.Prestamista.Préstamos;
using PrestApp.Views.Prestamista.Clientes;
using PrestApp.Views.Prestamista.Pagos;

namespace PrestApp.Views.Prestamista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPrestamistaPage : ContentPage
    {
        public MasterPrestamistaPage()
        {
            InitializeComponent();
        }

        private async void BtnPrestamos_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new HomePrestamosPage());
        }

        private async void BtnPagos_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new HomePagosPage());
        }

        private async void BtnClientes_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new HomeClientesPage());
        }
    }
}