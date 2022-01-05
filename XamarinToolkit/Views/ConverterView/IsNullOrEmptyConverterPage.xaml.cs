using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class IsNullOrEmptyConverterPage : ContentPage
    {
        IsNullOrEmptyConverterViewModel isNullOrEmptyConverterViewModel;
        public IsNullOrEmptyConverterPage()
        {
            InitializeComponent();
            BindingContext = isNullOrEmptyConverterViewModel = new IsNullOrEmptyConverterViewModel();
        }
    }
}
