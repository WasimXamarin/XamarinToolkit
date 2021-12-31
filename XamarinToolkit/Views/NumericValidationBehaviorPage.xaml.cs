using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;

namespace XamarinToolkit.Views
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
