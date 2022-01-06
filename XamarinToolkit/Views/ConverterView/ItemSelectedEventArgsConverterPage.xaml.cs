using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class ItemSelectedEventArgsConverterPage : ContentPage
    {
        ItemSelectedEventArgsConverterViewModel itemSelectedEventArgsConverterViewModel;
        public ItemSelectedEventArgsConverterPage()
        {
            InitializeComponent();
            BindingContext = itemSelectedEventArgsConverterViewModel = new ItemSelectedEventArgsConverterViewModel();
        }
    }
}
