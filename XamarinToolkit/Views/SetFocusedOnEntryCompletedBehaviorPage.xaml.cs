using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;

namespace XamarinToolkit.Views
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
