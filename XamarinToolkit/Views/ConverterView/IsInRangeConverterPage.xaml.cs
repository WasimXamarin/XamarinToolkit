using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class IsInRangeConverterPage : ContentPage
    {
        IsInRangeConverterViewModel isInRangeConverterViewModel;
        public IsInRangeConverterPage()
        {
            InitializeComponent();
            BindingContext = isInRangeConverterViewModel = new IsInRangeConverterViewModel();
        }
    }
}
