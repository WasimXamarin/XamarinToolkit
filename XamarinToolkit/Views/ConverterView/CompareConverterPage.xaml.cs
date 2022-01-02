using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class CompareConverterPage : ContentPage
    {
        CompareConverterViewModel compareConverterViewModel;
        public CompareConverterPage()
        {
            InitializeComponent();
            BindingContext = compareConverterViewModel = new CompareConverterViewModel();
        }
    }
}
