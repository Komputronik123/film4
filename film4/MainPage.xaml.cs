using System;
using film4;
using Microsoft.Maui.Controls;

namespace YourNamespace
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnImageTapped1(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new MovieDetailPage("Recenzja dla filmu 1"));
        }

        private async void OnImageTapped2(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MovieDetailPage2("Recenzja dla filmu 2"));
        }

        private async void OnImageTapped3(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new MovieDetailPage3("Recenzja dla filmu 3"));
        }

        private async void OnImageTapped4(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new MovieDetailPage4("Recenzja dla filmu 4"));
        }

    }
}
