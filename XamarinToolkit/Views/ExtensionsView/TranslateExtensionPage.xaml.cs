using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ExtensionsViewModel;

namespace XamarinToolkit.Views.ExtensionsView
{
    public partial class TranslateExtensionPage : ContentPage
    {
        TranslateExtensionViewModel translateExtensionViewModel;
        public TranslateExtensionPage()
        {
            InitializeComponent();
            BindingContext = translateExtensionViewModel = new TranslateExtensionViewModel();
        }

        async void OnCloseClicked(object? sender, EventArgs e) => await Navigation.PopModalAsync();
    }
}
