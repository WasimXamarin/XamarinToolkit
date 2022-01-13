using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ViewsViewModel;

namespace XamarinToolkit.Views.ViewsView
{
    public partial class BadgeViewPage : ContentPage
    {
        BadgeViewViewModel badgeViewViewModel;
        public BadgeViewPage()
        {
            InitializeComponent();
            BindingContext = badgeViewViewModel = new BadgeViewViewModel();
        }
    }
}
