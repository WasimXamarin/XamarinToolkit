using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class ByteArrayToImageSourceConverterPage : ContentPage
    {
        ByteArrayToImageSourceConverterViewModel byteArrayToImageSourceConverterViewModel;
        public ByteArrayToImageSourceConverterPage()
        {
            InitializeComponent();
            BindingContext = byteArrayToImageSourceConverterViewModel = new ByteArrayToImageSourceConverterViewModel();
        }
    }
}
