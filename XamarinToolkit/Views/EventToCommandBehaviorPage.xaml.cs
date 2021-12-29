using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;

namespace XamarinToolkit.Views
{
    public partial class EventToCommandBehaviorPage : ContentPage
    {
        EventToCommandBehaviorViewModel eventToCommandBehaviorViewModel;
        public EventToCommandBehaviorPage()
        {
            InitializeComponent();
            BindingContext = eventToCommandBehaviorViewModel = new EventToCommandBehaviorViewModel();
        }
    }
}
