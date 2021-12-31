using System;
namespace XamarinToolkit.ViewModels
{
    public class RequiredStringValidationBehaviorViewModel : BaseViewModel
    {
        public RequiredStringValidationBehaviorViewModel()
        {
            Title = "Required String Validation Behavior";
        }

        private string _PasswordEntry;
        public string PasswordEntry
        {
            get { return _PasswordEntry; }
            set
            {
                SetProperty(ref _PasswordEntry, value);
            }
        }

    }
}
