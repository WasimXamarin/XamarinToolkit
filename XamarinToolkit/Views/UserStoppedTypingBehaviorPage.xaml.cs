using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;

namespace XamarinToolkit.Views
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
