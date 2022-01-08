using System;
using System.Collections.Generic;
using XamarinToolkit.ViewModels.ConverterViewModel;

using Xamarin.Forms;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class NotEqualConverterPage : ContentPage
    {
        NotEqualConverterViewModel notEqualConverterViewModel;
        public NotEqualConverterPage()
        {
            InitializeComponent();
            BindingContext = notEqualConverterViewModel = new NotEqualConverterViewModel();
        }
    }
}
