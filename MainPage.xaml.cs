using Microsoft.Maui.Controls;

namespace zadanie1
{
    public partial class MainPage : ContentPage
    {
        private Label label1;
        private Label label2;

        public MainPage()
        {
            InitializeComponent();

            label1 = new Label
            {
                Text = "Przykładowy tekst 1",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            label2 = new Label
            {
                Text = "Przykładowy tekst 2",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            var changeTextButton = new Button
            {
                Text = "Zmień tekst",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            changeTextButton.Clicked += (sender, e) =>
            {
                label1.Text = label2.Text = "Przykładowy tekst dla 2 labelów";
            };

            var coloredButton = new Button
            {
                Text = "Zmień kolor tła przycisku",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };

            coloredButton.Clicked += (sender, e) =>
            {

                coloredButton.BackgroundColor = Color.FromRgb(225,000,000);
            };



            Content = new StackLayout
            {
                Children = { label1, label2, changeTextButton, coloredButton },
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
        }
    }
}
