using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
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
