using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ViewsViewModel;

namespace XamarinToolkit.Views.ViewsView
{
    public partial class ExpanderPage : ContentPage
    {
        ExpanderViewModel expanderViewModel;
        public ExpanderPage()
        {
            InitializeComponent();
            BindingContext = expanderViewModel = new ExpanderViewModel();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PopupPage());
        }
    }
}
