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
using PrestApp.Views.Prestamista.MenuItems;
using PrestApp.Views.Roles;
using PrestApp.Views.Usuarios;
using PrestApp.Clases;
namespace PrestApp.Views.Prestamista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPrestamistaPage : MasterDetailPage
    {
        public List<MasterPrestamistaItem> ListadoMenu
        {
            get;
            set;
        }
        public MasterPrestamistaPage()
        {
            InitializeComponent();

            ListadoMenu = new List<MasterPrestamistaItem>();
            // Añadiendo elementos del menú al listado del menú 
            MasterPrestamistaItem pag1 = new MasterPrestamistaItem()
            {
                Title = "Inicio",
                Icon = "inicio.png",
                TargetType = typeof(HomePrestamistaPage)
            };
            ListadoMenu.Add(pag1);
            MasterPrestamistaItem pag2 = new MasterPrestamistaItem()
            {
                Title = "Préstamos",
                Icon = "prestamos.png",
                TargetType = typeof(HomePrestamosPage)
            };
            ListadoMenu.Add(pag2);
            MasterPrestamistaItem pag3 = new MasterPrestamistaItem()
            {
                Title = "Pagos",
                Icon = "pagos.png",
                TargetType = typeof(HomePagosPage)
            };
            ListadoMenu.Add(pag3);
            MasterPrestamistaItem pag4 = new MasterPrestamistaItem()
            {
                Title = "Clientes",
                Icon = "clientes.png",
                TargetType = typeof(HomeClientesPage)
            };
            ListadoMenu.Add(pag4);
            MasterPrestamistaItem pag5 = new MasterPrestamistaItem()
            {
                Title = "Calculadora de Préstamos",
                Icon = "calculadora.png",
                TargetType = typeof(CalculadoraPrestamos)
            };
            ListadoMenu.Add(pag5);
            MasterPrestamistaItem pag6 = new MasterPrestamistaItem()
            {
                Title = "Calendario",
                Icon = "calendario.png",
                TargetType = typeof(Calendario)
            };
            ListadoMenu.Add(pag6);
            MasterPrestamistaItem pag7 = new MasterPrestamistaItem()
            {
                Title = "Acerca de PrestApp",
                Icon = "informacion.png",
                TargetType = typeof(AcercaDePrestApp)
            };
            ListadoMenu.Add(pag7);
            MasterPrestamistaItem pag8 = new MasterPrestamistaItem()
            {
                Title = "Prueba de Roles",
                Icon = "clientes.png",
                TargetType = typeof(ListaRolesPage)
            };
            ListadoMenu.Add(pag8);
            MasterPrestamistaItem pag9 = new MasterPrestamistaItem()
            {
                Title = "Prueba de Usuarios",
                Icon = "clientes.png",
                TargetType = typeof(ListaUsuariosPage)
            };
            ListadoMenu.Add(pag9);
            this.navigationDrawerList.ItemsSource = ListadoMenu;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePrestamistaPage)));
            this.navigationDrawerList.ItemSelected += NavigationDrawerList_ItemSelected;
            /*ListadoMenu.Add(new MasterPrestamistaItem()
            {
                Title = "Inicio",
                Icon = "inicio.png",
                TargetType = typeof(HomePrestamistaPage)
            });*/
            /*ListadoMenu.Add(new MasterPrestamistaItem()
            {
                Title = "Préstamos",
                Icon = "prestamos.png",
                TargetType = typeof(HomePrestamosPage)
            });
            ListadoMenu.Add(new MasterPrestamistaItem()
            {
                Title = "Pagos",
                Icon = "pagos.png",
                TargetType = typeof(HomePagosPage)
            });
            ListadoMenu.Add(new MasterPrestamistaItem()
            {
                Title = "Clientes",
                Icon = "clientes.png",
                TargetType = typeof(HomeClientesPage)
            });*/

            // Navegación inicial, para la página de inicio 

            /*this.Master = new MasterPrestamistaPage();
            this.Detail = new NavigationPage(new DetailPrestamistaPage());

            App.MasterD = this*/
            ;
        }
        // Event for Menu Item selection, here we are going to handle navigation based  
        // on user selection in menu ListView  
        private void NavigationDrawerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MasterPrestamistaItem pagina = e.SelectedItem as MasterPrestamistaItem;
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina.TargetType));
            IsPresented = false;
        }

        /*private async void BtnPrestamos_Clicked(object sender, EventArgs e)
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

        private async void BtnPruebaRoles_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new ListaRolesPage());
        }*/
    }
}