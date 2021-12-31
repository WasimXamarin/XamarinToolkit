using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
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
