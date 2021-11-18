using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen2PM02
{
    public partial class App : Application
    {
        public static string ruta;
        public App()
        {
            InitializeComponent();
            ruta = "https://softapphn.com/";
            MainPage = new NavigationPage(new MainPage());
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
