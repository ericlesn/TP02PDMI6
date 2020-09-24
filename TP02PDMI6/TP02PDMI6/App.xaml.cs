using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02PDMI6
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new View.Principal());
            InitializeComponent();
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
