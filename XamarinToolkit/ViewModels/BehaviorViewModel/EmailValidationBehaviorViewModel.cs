using System;

using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.CommunityToolkit;

namespace XamarinToolkit.ViewModels.BehaviorViewModel
{
    public class EmailValidationBehaviorViewModel : BaseViewModel
    {
        public Command LoadSendRegistrationCommand { get; }
        public EmailValidationBehaviorViewModel()
        {
            Title = "Email Validation Behavior Page";
            LoadSendRegistrationCommand = new Command(OnLoadSendRegistrationClicked);
        }


        private void OnLoadSendRegistrationClicked(object obj)
        {
            throw new NotImplementedException();
        }

        private bool _EmailValid;
        public bool EmailValid
        {
            get { return _EmailValid; }
            set { SetProperty(ref _EmailValid, value); }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
        }
    }
}
