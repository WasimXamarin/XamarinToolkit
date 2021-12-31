using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
{
    public partial class TextValidationBehaviorPage : ContentPage
    {
        TextValidationBehaviorViewModel textValidationBehaviorViewModel;
        public TextValidationBehaviorPage()
        {
            InitializeComponent();
            BindingContext = textValidationBehaviorViewModel = new TextValidationBehaviorViewModel();
        }
    }
}
