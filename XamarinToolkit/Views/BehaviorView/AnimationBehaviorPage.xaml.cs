using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
{
    public partial class AnimationBehaviorPage : ContentPage
    {
        AnimationBehaviorViewModel animationBehaviorViewModel;
        public AnimationBehaviorPage()
        {
            InitializeComponent();
            BindingContext = animationBehaviorViewModel = new AnimationBehaviorViewModel();
        }
    }
}
