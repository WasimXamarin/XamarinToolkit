using System;

using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.CommunityToolkit;

namespace XamarinToolkit.ViewModels.ViewsViewModel
{
    public class AvatarViewViewModel : BaseViewModel
    {
        public AvatarViewViewModel()
        {
            Title = "Avatar View";
            UserName = "Wasim Alam";
            AvatarSource = "SalmanImage.jpeg";
           //AvatarSource = "";
        }

        private string _UserName;
        public string UserName
        {
            get => _UserName;
            set => SetProperty(ref _UserName, value);
        }

        public ImageSource _AvatarSource;
        public ImageSource AvatarSource
        {
            get => _AvatarSource;
            set => SetProperty(ref _AvatarSource, value);
        }
    }
}
