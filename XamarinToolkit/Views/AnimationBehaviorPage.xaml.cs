using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;

namespace XamarinToolkit.Views
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
