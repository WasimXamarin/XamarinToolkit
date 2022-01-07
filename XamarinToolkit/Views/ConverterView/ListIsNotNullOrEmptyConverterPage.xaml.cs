using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class ListIsNotNullOrEmptyConverterPage : ContentPage
    {
        ListIsNotNullOrEmptyConverterViewModel listIsNotNullOrEmptyConverterViewModel;
        public ListIsNotNullOrEmptyConverterPage()
        {
            InitializeComponent();
            BindingContext = listIsNotNullOrEmptyConverterViewModel = new ListIsNotNullOrEmptyConverterViewModel();
        }
    }
}
