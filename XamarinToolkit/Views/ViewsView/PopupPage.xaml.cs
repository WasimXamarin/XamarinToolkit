using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ViewsViewModel;

namespace XamarinToolkit.Views.ViewsView
{
    public partial class PopupPage : ContentPage
    {
        PopupViewModel popupViewModel;
        public PopupPage()
        {
            InitializeComponent();
            BindingContext = popupViewModel = new PopupViewModel();
        }
    }
}
