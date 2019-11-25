using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using PrestApp.Views.Informations;
using PrestApp.Views.Usuarios;
using Rg.Plugins.Popup.Pages;
using System.Threading.Tasks;

namespace PrestApp.ViewModels
{
    public class MainViewModel : PopupPage
    {
#pragma warning disable IDE0044 // Add readonly modifier
        private INavigation _navigation;
#pragma warning restore IDE0044 // Add readonly modifier

        public MainViewModel()
        {

        }

        public MainViewModel(INavigation navigation)
        {
            _navigation = navigation;


            #region Execution MainPages

            RegistroCommand =
            new Command(async () =>
            await GetRegistro());

            OlvidarClaveCommnand =
            new Command(async () =>
            await GetOlvidarClave());

            ResetClaveCommand =
            new Command(async () =>
            await GetResetClave());

            #endregion

            #region Execution InformationPages

            /*InformationMainCommand =
            new Command(async () =>
            await GetInformationMain());*/

            RegistroInformationCommand =
            new Command(async () =>
            await GetRegistroInformation());

            /*OlvidarClaveInformationCommand =
            new Command(async () =>
            await GetOlvidarClaveInformation());*/

            ResetClaveInformationCommnad =
            new Command(async () =>
            await GetResetClaveInformation());

            #endregion
        }


        #region Commands MainPages
        public Command RegistroCommand { get; set; }
        public Command OlvidarClaveCommnand { get; set; }
        public Command ResetClaveCommand { get; set; }
        #endregion

        #region Tasks MainPages
        private async Task GetRegistro()
        {
            await _navigation.PushAsync(new RegistroUsuarioPage());

        }
        private async Task GetOlvidarClave()
        {
            await _navigation.PushAsync(new OlvidarClavePage());
        }
        private async Task GetResetClave()
        {
            await _navigation.PushAsync(new ResetClavePage());
        }
        #endregion


        #region Commands InformationPages
        public Command InformationMainCommand { get; set; }
        public Command RegistroInformationCommand { get; set; }
        public Command OlvidarClaveInformationCommand { get; set; }
        public Command ResetClaveInformationCommnad { get; set; }
        #endregion

        #region Tasks InformationPages
        /*private async Task GetInformationMain()
        {
            await PopupNavigation.Instance.PushAsync(new InformationMainPage());
        }*/
        private async Task GetRegistroInformation()
        {
            await PopupNavigation.Instance.PushAsync(new RegistroInformationPage());
        }
        /*private async Task GetOlvidarClaveInformation()
        {
            await PopupNavigation.Instance.PushAsync(new ForgotInformationPage());
            //BackgroundClicked += (sender, e) =>
            //{
            //    Navigation.PushAsync(new ResetPasswordPage(), true);
            //};
        }*/

        private async Task GetResetClaveInformation()
        {
            await PopupNavigation.Instance.PushAsync(new ResetClaveInformationPage());
        }
        #endregion

    }
}
