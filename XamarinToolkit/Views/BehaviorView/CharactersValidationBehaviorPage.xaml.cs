using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinToolkit.ViewModels.BehaviorViewModel;

namespace XamarinToolkit.Views.BehaviorView
{
    public partial class CharactersValidationBehaviorPage : ContentPage
    {
        CharactersValidationBehaviorViewModel charactersValidationBehaviorViewModel;
        public CharactersValidationBehaviorPage()
        {
            InitializeComponent();
            BindingContext = charactersValidationBehaviorViewModel = new CharactersValidationBehaviorViewModel();
        }
    }
}
