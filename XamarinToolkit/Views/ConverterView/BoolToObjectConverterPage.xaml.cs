using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class BoolToObjectConverterPage : ContentPage
    {
        BoolToObjectConverterViewModel boolToObjectConverterViewModelp;
        public BoolToObjectConverterPage()
        {
            InitializeComponent();
            BindingContext = boolToObjectConverterViewModelp = new BoolToObjectConverterViewModel();
        }
    }
}
