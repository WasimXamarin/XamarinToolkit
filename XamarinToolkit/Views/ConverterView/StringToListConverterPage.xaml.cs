using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class StringToListConverterPage : ContentPage
    {
        StringToListConverterViewModel stringToListConverterViewModel;
        public StringToListConverterPage()
        {
            InitializeComponent();
            BindingContext = stringToListConverterViewModel = new StringToListConverterViewModel();
        }
    }
}
