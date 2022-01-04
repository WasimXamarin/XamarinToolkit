using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class InvertedBoolConverterPage : ContentPage
    {
        InvertedBoolConverterViewModel invertedBoolConverterViewModel;
        public InvertedBoolConverterPage()
        {
            InitializeComponent();
            BindingContext = invertedBoolConverterViewModel = new InvertedBoolConverterViewModel();
        }
    }
}
