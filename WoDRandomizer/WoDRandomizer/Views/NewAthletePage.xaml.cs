using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoDRandomizer.Models;
using WoDRandomizer.ViewModels;
using WoDRandomizer.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WoDRandomizer.Views
{
    public partial class NewAthletePage : ContentPage
    {
        NewAthleteViewModel _viewModel;

        public NewAthletePage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new NewAthleteViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        public async void SaveAthleteClicked(Object sender, EventArgs e)
        {
            App.athleteUser.Name = athleteName.Text;
            App.athleteUser.Age = athleteAge.Value.ToString();
            App.athleteUser.Sex = athleteMale.IsChecked ? "M" : "F";
            App.athleteUser.Level = (athleteBeginner.IsChecked) ? "Beginner" : (athleteIntermediate.IsChecked) ? "Intermediate" : (athleteExpert.IsChecked) ? "Expert" : "";

            await Navigation.PushAsync(new AthleteCurrentStatusPage());
        }

        public void OnSliderValueChanged(Object sender, ValueChangedEventArgs e)
        {
            int value = (int) e.NewValue;
            displayAge.Text = value.ToString();

        }

        
    }
}