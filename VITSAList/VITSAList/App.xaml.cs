﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace VITSAList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PlanetPage();
           
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            // This is empty
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
