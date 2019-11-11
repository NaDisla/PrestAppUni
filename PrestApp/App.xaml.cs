using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrestApp.Views.Forms;
namespace PrestApp
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
        public static string _rutaBD;
        public App(string rutaBD)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

            _rutaBD = rutaBD;
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
