using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;

namespace XamarinToolkit.Views
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
