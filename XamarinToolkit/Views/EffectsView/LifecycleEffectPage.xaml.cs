using System;
using System.Collections.Generic;
using XamarinToolkit.ViewModels.EffectsViewModel;

using Xamarin.Forms;

namespace XamarinToolkit.Views.EffectsView
{
    public partial class LifecycleEffectPage : ContentPage
    {
        LifecycleEffectViewModel lifecycleEffectViewModel;
        public LifecycleEffectPage()
        {
            InitializeComponent();
            BindingContext = lifecycleEffectViewModel = new LifecycleEffectViewModel();
        }

		void LifeCycleEffect_Loaded(object? sender, EventArgs e)
		{
			if (sender is Button)
				lbl.Text += "Button loaded \n";
			if (sender is Image)
				lbl.Text += "Image loaded \n";
			if (sender is Label)
				lbl.Text += "Label loaded \n";
			if (sender is StackLayout)
				lbl.Text += "StackLayout loaded \n";
		}

		void LifeCycleEffect_Unloaded(object? sender, EventArgs e)
		{
			if (sender is Button)
				lbl.Text += "Button unloaded \n";
			if (sender is Image)
				lbl.Text += "Image unloaded \n";
			if (sender is Label)
				lbl.Text += "Label unloaded \n";
			if (sender is StackLayout)
				lbl.Text += "StackLayout unloaded \n";
		}

		void Button_Clicked(object? sender, EventArgs e)
		{
			img.IsVisible = !img.IsVisible;
			Device.StartTimer(TimeSpan.FromSeconds(3), () =>
			{
				stack.Children.Remove(img);
				return false;
			});
		}
	}
}
