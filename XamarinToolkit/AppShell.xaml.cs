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
            Routing.RegisterRoute(nameof(EventToCommandBehaviorPage), typeof(EventToCommandBehaviorPage));
            Routing.RegisterRoute(nameof(ImpliedOrderGridBehaviorPage), typeof(ImpliedOrderGridBehaviorPage));
            Routing.RegisterRoute(nameof(MaskedBehaviorPage), typeof(MaskedBehaviorPage));
            Routing.RegisterRoute(nameof(MaxLengthReachedBehaviorPage), typeof(MaxLengthReachedBehaviorPage));
            Routing.RegisterRoute(nameof(MultiValidationBehaviorPage), typeof(MultiValidationBehaviorPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
