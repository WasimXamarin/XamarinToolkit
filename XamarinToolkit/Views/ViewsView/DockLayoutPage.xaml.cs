using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ViewsViewModel;

namespace XamarinToolkit.Views.ViewsView
{
    public partial class DockLayoutPage : ContentPage
    {
        DockLayoutViewModel dockLayoutViewModel;
        public DockLayoutPage()
        {
            InitializeComponent();
            BindingContext = dockLayoutViewModel = new DockLayoutViewModel();
        }
    }
}
