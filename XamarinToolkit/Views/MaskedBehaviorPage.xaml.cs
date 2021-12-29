using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;

namespace XamarinToolkit.Views
{
    public partial class MaskedBehaviorPage : ContentPage
    {
        MaskedBehaviorViewModel maskedBehaviorViewModel;
        public MaskedBehaviorPage()
        {
            InitializeComponent();
            BindingContext = maskedBehaviorViewModel = new MaskedBehaviorViewModel();
        }
    }
}
