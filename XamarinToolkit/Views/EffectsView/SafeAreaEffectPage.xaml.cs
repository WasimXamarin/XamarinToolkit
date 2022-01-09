using System;
using System.Collections.Generic;
using Xamarin.CommunityToolkit.Effects;
using Xamarin.Forms;
using XamarinToolkit.ViewModels.EffectsViewModel;

namespace XamarinToolkit.Views.EffectsView
{
    public partial class SafeAreaEffectPage : ContentPage
    {
        SafeAreaEffectViewModel safeAreaEffectViewModel;
        public SafeAreaEffectPage()
        {
            InitializeComponent();
            BindingContext = safeAreaEffectViewModel = new SafeAreaEffectViewModel();
        }

        public void ActivationToggle_Toggled(object? sender, Xamarin.Forms.ToggledEventArgs e) =>
            SafeAreaEffect.SetSafeArea(stack, e.Value);
    }
}
