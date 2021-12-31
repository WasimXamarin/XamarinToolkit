using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
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
