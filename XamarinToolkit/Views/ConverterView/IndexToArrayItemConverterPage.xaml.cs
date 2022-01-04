using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class IndexToArrayItemConverterPage : ContentPage
    {
        IndexToArrayItemConverterViewModel indexToArrayItemConverterViewModel;
        public IndexToArrayItemConverterPage()
        {
            InitializeComponent();
            BindingContext = indexToArrayItemConverterViewModel = new IndexToArrayItemConverterViewModel();
        }
    }
}
