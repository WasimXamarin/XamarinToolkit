using System;
using System.Collections.Generic;
using Xamarin.CommunityToolkit.Behaviors;
using Xamarin.Forms;
using XamarinToolkit.ViewModels;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
{
    public partial class MaxLengthReachedBehaviorPage : ContentPage
    {
        MaxLengthReachedBehaviorViewModel maxLengthReachedBehaviorViewModel;
        public MaxLengthReachedBehaviorPage()
        {
            InitializeComponent();
            BindingContext = maxLengthReachedBehaviorViewModel = new MaxLengthReachedBehaviorViewModel();
        }

        private void MaxLengthReachedBehavior_MaxLengthReached(System.Object sender, Xamarin.CommunityToolkit.Behaviors.MaxLengthReachedEventArgs e)
        {
            nextEntry.Focus();
        }
    }
}
