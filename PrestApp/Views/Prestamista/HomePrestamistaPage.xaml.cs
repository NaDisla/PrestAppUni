using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestApp.Views.Prestamista.MenuItems;
using PrestApp.Views.Prestamista.Préstamos;
using PrestApp.Views.Prestamista.Pagos;
using PrestApp.Views.Prestamista.Clientes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrestApp.Views.Prestamista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePrestamistaPage : ContentPage
    {


        public HomePrestamistaPage()
        {
            InitializeComponent();
        }
    }
}