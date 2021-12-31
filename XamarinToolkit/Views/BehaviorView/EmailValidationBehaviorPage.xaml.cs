using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
{
    public partial class EmailValidationBehaviorPage : ContentPage
    {
        EmailValidationBehaviorViewModel emailValidationBehaviorViewModel;
        public EmailValidationBehaviorPage()
        {
            InitializeComponent();
            BindingContext = emailValidationBehaviorViewModel = new EmailValidationBehaviorViewModel();
        }
    }
}
