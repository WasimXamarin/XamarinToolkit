using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
{
    public partial class NumericValidationBehaviorPage : ContentPage
    {
        NumericValidationBehaviorViewModel numericValidationBehaviorViewModel;
        public NumericValidationBehaviorPage()
        {
            InitializeComponent();
            BindingContext = numericValidationBehaviorViewModel = new NumericValidationBehaviorViewModel();
        }
    }
}
