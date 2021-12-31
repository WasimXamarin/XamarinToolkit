using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
{
    public partial class UserStoppedTypingBehaviorPage : ContentPage
    {
        UserStoppedTypingBehaviorViewModel userStoppedTypingBehaviorViewModel;
        public UserStoppedTypingBehaviorPage()
        {
            InitializeComponent();
            BindingContext = userStoppedTypingBehaviorViewModel = new UserStoppedTypingBehaviorViewModel();
        }
    }
}
