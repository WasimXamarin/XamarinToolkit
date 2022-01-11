using System;

using Xamarin.Forms;

namespace XamarinToolkit.Views.MarkupView
{
    public class MarkupPage : ContentPage
    {
        public MarkupPage()
        {
            Title = "Markup";
            Grid grid = new Grid();

            Label label = new Label { Text = "Code: " };
            grid.Children.Add(label, 0, 1);

            Entry entry = new Entry
            {
                Placeholder = "Enter number",
                Keyboard = Keyboard.Numeric,
                BackgroundColor = Color.AliceBlue,
                TextColor = Color.Black,
                FontSize = 15,
                HeightRequest = 44
            };
            grid.Children.Add(entry, 0, 2);
            Grid.SetColumnSpan(entry, 2);
            entry.SetBinding(Entry.TextProperty, new Binding("RegistrationCode"));

            Content = grid;
        }
    }
}

