using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestApp.Views.Administrador.MenuItems;
using PrestApp.Views.Prestamista.Préstamos;
using PrestApp.Views.Prestamista.Clientes;
using PrestApp.Views.Prestamista.Pagos;
using PrestApp.Views.Prestamista.MenuItems;
using PrestApp.Views.Administrador.Ocupaciones;
using PrestApp.Views.Administrador.Roles;
using PrestApp.Views.Usuarios;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrestApp.Views.Administrador
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterAdministradorPage : MasterDetailPage
    {
        public List<MasterAdministradorItem> ListadoMenu
        {
            get;
            set;
        }
        public MasterAdministradorPage()
        {
            InitializeComponent();
            ListadoMenu = new List<MasterAdministradorItem>();
            // Añadiendo elementos del menú al listado del menú 
            MasterAdministradorItem pag1 = new MasterAdministradorItem()
            {
                Title = "Inicio",
                Icon = "inicio.png",
                TargetType = typeof(AdministradorHomePage)
            };
            ListadoMenu.Add(pag1);
            MasterAdministradorItem pag2 = new MasterAdministradorItem()
            {
                Title = "Préstamos",
                Icon = "prestamos.png",
                TargetType = typeof(HomePrestamosPage)
            };
            ListadoMenu.Add(pag2);
            MasterAdministradorItem pag3 = new MasterAdministradorItem()
            {
                Title = "Pagos",
                Icon = "pagos.png",
                TargetType = typeof(HomePagosPage)
            };
            ListadoMenu.Add(pag3);
            MasterAdministradorItem pag4 = new MasterAdministradorItem()
            {
                Title = "Clientes",
                Icon = "clientes.png",
                TargetType = typeof(HomeClientesPage)
            };
            ListadoMenu.Add(pag4);
            MasterAdministradorItem pag5 = new MasterAdministradorItem()
            {
                Title = "Amortizaciones",
                Icon = "amortizacion.png",
                TargetType = typeof(ListaUsuariosPage)
            };
            ListadoMenu.Add(pag5);
            MasterAdministradorItem pag6 = new MasterAdministradorItem()
            {
                Title = "Calculadora de Préstamos",
                Icon = "calculadora.png",
                TargetType = typeof(CalculadoraPrestamos)
            };
            ListadoMenu.Add(pag6);
            MasterAdministradorItem pag7 = new MasterAdministradorItem()
            {
                Title = "Calendario",
                Icon = "calendario.png",
                TargetType = typeof(Calendario)
            };
            ListadoMenu.Add(pag7);
            MasterAdministradorItem pag8 = new MasterAdministradorItem()
            {
                Title = "Acerca de PrestApp",
                Icon = "informacion.png",
                TargetType = typeof(AcercaDePrestApp)
            };
            ListadoMenu.Add(pag8);
            MasterAdministradorItem pag9 = new MasterAdministradorItem()
            {
                Title = "Roles",
                Icon = "roles.png",
                TargetType = typeof(ListaRolesPage)
            };
            ListadoMenu.Add(pag9);
            MasterAdministradorItem pag10 = new MasterAdministradorItem()
            {
                Title = "Usuarios",
                Icon = "usuarios.png",
                TargetType = typeof(ListaUsuariosPage)
            };
            ListadoMenu.Add(pag10);
            MasterAdministradorItem pag11 = new MasterAdministradorItem()
            {
                Title = "Ocupaciones",
                Icon = "ocupacion.png",
                TargetType = typeof(ListaOcupacionesPage)
            };
            ListadoMenu.Add(pag11);
            MasterAdministradorItem pag12 = new MasterAdministradorItem()
            {
                Title = "Modalidades de Pago",
                Icon = "modalidadpago.png",
                TargetType = typeof(ListaUsuariosPage)
            };
            ListadoMenu.Add(pag12);
            MasterAdministradorItem pag13 = new MasterAdministradorItem()
            {
                Title = "Títulos Académicos",
                Icon = "tituloacdm.png",
                TargetType = typeof(ListaUsuariosPage)
            };
            ListadoMenu.Add(pag13);

            this.listaAdministrador.ItemsSource = ListadoMenu;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(AdministradorHomePage)));
            this.listaAdministrador.ItemSelected += ListaAdministrador_ItemSelected;
        }

        private void ListaAdministrador_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MasterAdministradorItem pagina = e.SelectedItem as MasterAdministradorItem;
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina.TargetType));
            IsPresented = false;
        }
    }
}