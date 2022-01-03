using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class DoubleToIntConverterPage : ContentPage
    {
        DoubleToIntConverterViewModel doubleToIntConverterViewModel;
        public DoubleToIntConverterPage()
        {
            InitializeComponent();
            BindingContext = doubleToIntConverterViewModel = new DoubleToIntConverterViewModel();
        }
    }
}
