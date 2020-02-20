using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pokus.Services;
using Pokus.Views;

namespace Pokus
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
