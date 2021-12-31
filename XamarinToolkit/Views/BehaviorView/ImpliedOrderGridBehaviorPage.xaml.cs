using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
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
