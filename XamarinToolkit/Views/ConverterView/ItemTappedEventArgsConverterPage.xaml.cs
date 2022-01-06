using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ConverterViewModel;

namespace XamarinToolkit.Views.ConverterView
{
    public partial class ItemTappedEventArgsConverterPage : ContentPage
    {
        ItemTappedEventArgsConverterViewModel itemTappedEventArgsConverterViewModel;
        public ItemTappedEventArgsConverterPage()
        {
            InitializeComponent();
            BindingContext = itemTappedEventArgsConverterViewModel = new ItemTappedEventArgsConverterViewModel();
        }
    }
}
