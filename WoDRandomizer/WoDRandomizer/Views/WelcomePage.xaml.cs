using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WoDRandomizer.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        public async void NewWorkoutClicked(Object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new ItemsPage());
        }

        public async void SavedWorkoutsClicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemDetailPage());
        }
    }
}