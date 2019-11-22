﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrestApp.Views.Usuarios;

namespace PrestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new GeneralLoginPage());
        }
        public static string _rutaBD;
        public App(string rutaBD)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

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
