using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrestApp.Views.Prestamista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePrestamistaPage : MasterDetailPage
    {
        public HomePrestamistaPage()
        {
            InitializeComponent();
            this.Master = new MasterPrestamistaPage();
            this.Detail = new NavigationPage(new DetailPrestamistaPage());

            App.MasterD = this;
        }
    }
}