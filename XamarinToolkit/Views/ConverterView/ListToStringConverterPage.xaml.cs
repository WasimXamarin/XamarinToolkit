using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class ListToStringConverterPage : ContentPage
    {
        ListToStringConverterViewModel listToStringConverterViewModel;
        public ListToStringConverterPage()
        {
            InitializeComponent();
            BindingContext = listToStringConverterViewModel = new ListToStringConverterViewModel();
        }
    }
}
