using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
{
    public partial class SetFocusedOnEntryCompletedBehaviorPage : ContentPage
    {
        SetFocusedOnEntryCompletedBehaviorViewModel setFocusedOnEntryCompletedBehaviorViewModel;
        public SetFocusedOnEntryCompletedBehaviorPage()
        {
            InitializeComponent();
            BindingContext = setFocusedOnEntryCompletedBehaviorViewModel = new SetFocusedOnEntryCompletedBehaviorViewModel();
        }
    }
}
