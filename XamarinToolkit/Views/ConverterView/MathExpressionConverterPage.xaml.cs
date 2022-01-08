using System;
using System.Collections.Generic;
using XamarinToolkit.ViewModels.ConverterViewModel;

using Xamarin.Forms;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class MathExpressionConverterPage : ContentPage
    {
        MathExpressionConverterViewModel mathExpressionConverterViewModel;
        public MathExpressionConverterPage()
        {
            InitializeComponent();
            BindingContext = mathExpressionConverterViewModel = new MathExpressionConverterViewModel();
        }
    }
}
