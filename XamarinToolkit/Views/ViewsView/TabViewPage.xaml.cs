using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ViewsViewModel;

namespace XamarinToolkit.Views.ViewsView
{
    public partial class TabViewPage : ContentPage
    {
        TabViewViewModel tabViewViewModel;
        public TabViewPage()
        {
            InitializeComponent();
            BindingContext = tabViewViewModel = new TabViewViewModel();
        }
    }
}
