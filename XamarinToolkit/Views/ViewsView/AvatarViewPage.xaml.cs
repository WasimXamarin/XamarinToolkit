using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.ViewsViewModel;

namespace XamarinToolkit.Views.ViewsView
{
    public partial class AvatarViewPage : ContentPage
    {
        AvatarViewViewModel avatarViewViewModel;
        public AvatarViewPage()
        {
            InitializeComponent();
            BindingContext = avatarViewViewModel = new AvatarViewViewModel();
        }
    }
}
