using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestApp.Clases;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroRolesPage : ContentPage
    {
        public RegistroRolesPage()
        {
            InitializeComponent();
        }

        private void BtnRegistroRol_Clicked(object sender, EventArgs e)
        {
            Roles nuevoRol = new Roles()
            {
                Nombre = txtNombre.Text
            };

            using (var conn = new SQLiteConnection(App._rutaBD))
            {
                conn.CreateTable<Roles>();
                conn.Insert(nuevoRol);
            }
        }

        private void BtnMostrarRoles_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaRolesPage());
        }
    }
}