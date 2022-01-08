using System;
using System.Collections.Generic;
using XamarinToolkit.ViewModels.ConverterViewModel;

using Xamarin.Forms;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class VariableMultiValueConverterPage : ContentPage
    {
        VariableMultiValueConverterViewModel variableMultiValueConverterViewModel;
        public VariableMultiValueConverterPage()
        {
            InitializeComponent();
            BindingContext = variableMultiValueConverterViewModel = new VariableMultiValueConverterViewModel();
        }
    }
}
