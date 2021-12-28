using System;
using System.Collections.Generic;
using XamarinToolkit.ViewModels;
using XamarinToolkit.Views;
using Xamarin.Forms;

namespace XamarinToolkit
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(AnimationBehaviorPage), typeof(AnimationBehaviorPage));
            Routing.RegisterRoute(nameof(CharactersValidationBehaviorPage), typeof(CharactersValidationBehaviorPage));
            Routing.RegisterRoute(nameof(EmailValidationBehaviorPage), typeof(EmailValidationBehaviorPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
