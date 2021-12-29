using System;

using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.CommunityToolkit;

namespace XamarinToolkit.ViewModels
{
    public class EventToCommandBehaviorViewModel : BaseViewModel
    {
        public Command MyCustomCommand { get; }
        public EventToCommandBehaviorViewModel()
        {
            Title = "Event To Command Behavior";
            MyCustomCommand = new Command(OnMyCustomClicked);
        }

        private void OnMyCustomClicked(object obj)
        {
            ClickCount++;
        }

        private int _ClickCount;
        public int ClickCount
        {
            get { return _ClickCount; }
            set { SetProperty(ref _ClickCount, value); }
        }
    }
}
