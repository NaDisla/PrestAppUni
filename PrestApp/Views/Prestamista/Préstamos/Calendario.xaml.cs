using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrestApp.Views.Prestamista.Préstamos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calendario : ContentPage
    {
        public Calendario()
        {
            InitializeComponent();
            SfCalendar calendario = new SfCalendar();
            this.Content = calendario;
        }
    }
}