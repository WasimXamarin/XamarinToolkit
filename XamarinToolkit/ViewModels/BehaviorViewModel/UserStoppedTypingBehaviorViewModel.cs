using System;

using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.CommunityToolkit;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;

namespace XamarinToolkit.ViewModels.BehaviorViewModel
{
    public class UserStoppedTypingBehaviorViewModel : BaseViewModel
    {
        public ICommand SearchCommand { get; }
        public UserStoppedTypingBehaviorViewModel()
        {
            Title = "User Stopped Typing Behavior";
            SearchCommand = CommandFactory.Create<string>(PerformSearch);
        }

        private void PerformSearch(string searchTerms)
        {
            PerformedSearches += string.Format("Performed search for '{0}'.", searchTerms) + Environment.NewLine;
        }

        private string _PerformedSearches;
        public string PerformedSearches
        {
            get { return _PerformedSearches; }
            set { SetProperty(ref _PerformedSearches, value); }
        }
    }
}
