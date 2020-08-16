﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFApp.Services;
using XFApp.Views;

namespace XFApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            // MainPage = new ItemDetailPage(); revert back to AppShell()
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
