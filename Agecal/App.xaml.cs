using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agecal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WebBrowser();
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
