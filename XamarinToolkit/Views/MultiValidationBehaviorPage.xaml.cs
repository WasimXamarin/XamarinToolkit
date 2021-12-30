using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;

namespace XamarinToolkit.Views
{
    public partial class MultiValidationBehaviorPage : ContentPage
    {
        MultiValidationBehaviorViewModel multiValidationBehaviorViewModel;
        public MultiValidationBehaviorPage()
        {
            InitializeComponent();
            BindingContext = multiValidationBehaviorViewModel = new MultiValidationBehaviorViewModel();
        }
    }
}
