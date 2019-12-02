using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrestApp.Views.Usuarios;
using Microsoft.WindowsAzure.MobileServices;
using System.Net.Http;

namespace PrestApp
{
    public partial class App : Application
    {
        //public static MobileServiceClient client = new MobileServiceClient("https://prestappapi.azurewebsites.windows.net");

        public static MasterDetailPage MasterD { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new GeneralLoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
