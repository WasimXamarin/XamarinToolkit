using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class TextCaseConverterPage : ContentPage
    {
        TextCaseConverterViewModel textCaseConverterViewModel;
        public TextCaseConverterPage()
        {
            InitializeComponent();
            BindingContext = textCaseConverterViewModel = new TextCaseConverterViewModel();
        }
    }
}
