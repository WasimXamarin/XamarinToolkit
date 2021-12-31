using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
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
