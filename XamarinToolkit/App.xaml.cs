using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinToolkit.Services;
using XamarinToolkit.Views;

namespace XamarinToolkit
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
