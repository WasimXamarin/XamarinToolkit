using System;
using System.Collections.Generic;
using XamarinToolkit.ViewModels.ExtensionsViewModel;

using Xamarin.Forms;

namespace XamarinToolkit.Views.ExtensionsView
{
    public partial class ImageResourceExtensionPage : ContentPage
    {
        ImageResourceExtensionViewModel imageResourceExtensionViewModel;
        public ImageResourceExtensionPage()
        {
            InitializeComponent();
            BindingContext = imageResourceExtensionViewModel = new ImageResourceExtensionViewModel();
        }
    }
}
