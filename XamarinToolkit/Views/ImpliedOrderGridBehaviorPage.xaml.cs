using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;

namespace XamarinToolkit.Views
{
    public partial class ImpliedOrderGridBehaviorPage : ContentPage
    {
        ImpliedOrderGridBehaviorViewModel impliedOrderGridBehaviorViewModel;
        public ImpliedOrderGridBehaviorPage()
        {
            InitializeComponent();
            BindingContext = impliedOrderGridBehaviorViewModel = new ImpliedOrderGridBehaviorViewModel();
        }
    }
}
