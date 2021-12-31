using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;

namespace XamarinToolkit.Views
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
