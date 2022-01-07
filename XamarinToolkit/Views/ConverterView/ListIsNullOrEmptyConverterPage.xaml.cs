using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class ListIsNullOrEmptyConverterPage : ContentPage
    {
        ListIsNullOrEmptyConverterPageViewModel listIsNullOrEmptyConverterPageViewModel;
        public ListIsNullOrEmptyConverterPage()
        {
            InitializeComponent();
            BindingContext = listIsNullOrEmptyConverterPageViewModel = new ListIsNullOrEmptyConverterPageViewModel();
        }
    }
}
