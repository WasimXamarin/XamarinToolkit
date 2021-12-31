using System;
using System.Collections.Generic;
using XamarinToolkit.ViewModels;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
{
    public partial class UriValidationBehaviorPage : ContentPage
    {
        UriValidationBehaviorViewModel uriValidationBehaviorViewModel;
        public UriValidationBehaviorPage()
        {
            InitializeComponent();
            BindingContext = uriValidationBehaviorViewModel = new UriValidationBehaviorViewModel();
        }
    }
}
