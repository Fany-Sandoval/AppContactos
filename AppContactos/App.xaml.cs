using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppContactos
{
    public partial class App : Application
    {
        public static string RUTA_DB;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public App(string url_bd)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            RUTA_DB= url_bd;
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
