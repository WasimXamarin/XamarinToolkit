using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class DateTimeOffsetConverterPage : ContentPage
    {
        DateTimeOffsetConverterViewModel dateTimeOffsetConverterViewModel;
        public DateTimeOffsetConverterPage()
        {
            InitializeComponent();
            BindingContext = dateTimeOffsetConverterViewModel = new DateTimeOffsetConverterViewModel();
        }
    }
}
