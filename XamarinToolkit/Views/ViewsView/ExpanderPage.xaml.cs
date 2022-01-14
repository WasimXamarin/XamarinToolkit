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
    }
}
