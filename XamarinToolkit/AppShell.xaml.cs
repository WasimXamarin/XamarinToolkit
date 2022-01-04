﻿using System;
using System.Collections.Generic;
using XamarinToolkit.ViewModels;
using XamarinToolkit.Views;
using Xamarin.Forms;
using XamarinToolkit.Views.BehaviorView;
using XamarinToolkit.Views.ConverterView;

namespace XamarinToolkit
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(AnimationBehaviorPage), typeof(AnimationBehaviorPage));
            Routing.RegisterRoute(nameof(CharactersValidationBehaviorPage), typeof(CharactersValidationBehaviorPage));
            Routing.RegisterRoute(nameof(EmailValidationBehaviorPage), typeof(EmailValidationBehaviorPage));
            Routing.RegisterRoute(nameof(EventToCommandBehaviorPage), typeof(EventToCommandBehaviorPage));
            Routing.RegisterRoute(nameof(ImpliedOrderGridBehaviorPage), typeof(ImpliedOrderGridBehaviorPage));
            Routing.RegisterRoute(nameof(MaskedBehaviorPage), typeof(MaskedBehaviorPage));
            Routing.RegisterRoute(nameof(MaxLengthReachedBehaviorPage), typeof(MaxLengthReachedBehaviorPage));
            Routing.RegisterRoute(nameof(MultiValidationBehaviorPage), typeof(MultiValidationBehaviorPage));
            Routing.RegisterRoute(nameof(NumericValidationBehaviorPage), typeof(NumericValidationBehaviorPage));
            Routing.RegisterRoute(nameof(RequiredStringValidationBehaviorPage), typeof(RequiredStringValidationBehaviorPage));
            Routing.RegisterRoute(nameof(SetFocusedOnEntryCompletedBehaviorPage), typeof(SetFocusedOnEntryCompletedBehaviorPage));
            Routing.RegisterRoute(nameof(TextValidationBehaviorPage), typeof(TextValidationBehaviorPage));
            Routing.RegisterRoute(nameof(UriValidationBehaviorPage), typeof(UriValidationBehaviorPage));
            Routing.RegisterRoute(nameof(UserStoppedTypingBehaviorPage), typeof(UserStoppedTypingBehaviorPage));
            Routing.RegisterRoute(nameof(BoolToObjectConverterPage), typeof(BoolToObjectConverterPage));
            Routing.RegisterRoute(nameof(ByteArrayToImageSourceConverterPage), typeof(ByteArrayToImageSourceConverterPage));
            Routing.RegisterRoute(nameof(CompareConverterPage), typeof(CompareConverterPage));
            Routing.RegisterRoute(nameof(DateTimeOffsetConverterPage), typeof(DateTimeOffsetConverterPage));
            Routing.RegisterRoute(nameof(DoubleToIntConverterPage), typeof(DoubleToIntConverterPage));
            Routing.RegisterRoute(nameof(EnumToBoolConverterPage), typeof(EnumToBoolConverterPage));
            Routing.RegisterRoute(nameof(EqualConverterPage), typeof(EqualConverterPage));
            Routing.RegisterRoute(nameof(IndexToArrayItemConverterPage), typeof(IndexToArrayItemConverterPage));
            Routing.RegisterRoute(nameof(InvertedBoolConverterPage), typeof(InvertedBoolConverterPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
