using System;
using System.Collections.Generic;
using XamarinToolkit.ViewModels;

using Xamarin.Forms;

namespace XamarinToolkit.Views
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
