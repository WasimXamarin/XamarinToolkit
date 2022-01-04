using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class EqualConverterPage : ContentPage
    {
        EqualConverterViewModel equalConverterViewModel;
        public EqualConverterPage()
        {
            InitializeComponent();
            BindingContext = equalConverterViewModel = new EqualConverterViewModel();
        }
    }
}
