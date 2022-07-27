using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WoDRandomizer.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        public async void NewWorkoutClicked(Object sender, EventArgs e)
        {
            if (App.athleteUser.Name != null)
            {
                await Navigation.PushAsync(new AthleteCurrentStatusPage());
            } else
            {
                await Navigation.PushAsync(new NewAthletePage());
            }
        }

        public async void SavedWorkoutsClicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemDetailPage());
        }
    }
}