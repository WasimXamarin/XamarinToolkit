using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;

namespace XamarinToolkit.Views
{
    public partial class RequiredStringValidationBehaviorPage : ContentPage
    {
        RequiredStringValidationBehaviorViewModel requiredStringValidationBehaviorViewModel;
        public RequiredStringValidationBehaviorPage()
        {
            InitializeComponent();
            BindingContext = requiredStringValidationBehaviorViewModel = new RequiredStringValidationBehaviorViewModel();
        }
    }
}
