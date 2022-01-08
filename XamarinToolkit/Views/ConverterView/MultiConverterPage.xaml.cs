using System;
using System.Collections.Generic;
using XamarinToolkit.ViewModels.ConverterViewModel;

using Xamarin.Forms;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class MultiConverterPage : ContentPage
    {
        MultiConverterViewModel multiConverterViewModel;
        public MultiConverterPage()
        {
            InitializeComponent();
            BindingContext = multiConverterViewModel = new MultiConverterViewModel();
        }
    }
}
