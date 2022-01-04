using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class EnumToBoolConverterPage : ContentPage
    {
        EnumToBoolConverterViewModel enumToBoolConverterViewModel;
        public EnumToBoolConverterPage()
        {
            InitializeComponent();
            BindingContext = enumToBoolConverterViewModel = new EnumToBoolConverterViewModel();
        }
    }
}
