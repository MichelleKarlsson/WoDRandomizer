using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WoDRandomizer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AthleteCurrentStatusPage : ContentPage
    {
        List<string> MusclegroupsToAvoid { get; set; }
        List<string> Musclegroups = new List<string> { "chest", "biceps", "triceps", "shoulders", "glutes", "hamstrings", "hip flexors", "back", "quads", "core", "lats", "upper back", "lower back", "calves" };

        public AthleteCurrentStatusPage()
        {
            InitializeComponent();
            MusclegroupsToAvoid = new List<string>();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            greetingLabel.Text = "Welcome back, " + App.athleteUser.Name;
            populateMuscleGroupsView();

        }

        public void populateMuscleGroupsView()
        {
            var indexRow = 0;
            var indexColumn = 0;

            foreach (var s in Musclegroups)
            {
                var button = new Button
                {
                    Text = s,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    
                };

                MusclegroupsToAvoidView.Children.Add(button, indexColumn, indexRow);

                if (indexColumn == 3)
                {
                    indexColumn = 0;
                    indexRow += 1;
                } else
                {
                    indexColumn += 1;
                }
                

            }

        }

        public void OnEnergyValueChanged(Object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            displayEnergy.Text = value.ToString();

        }
        public void OnTimeValueChanged(Object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            displayTime.Text = value.ToString();

        }

        public async void OnContinueClicked(Object sender, EventArgs e)
        {
            App.athleteUser.Energy = (int) athleteEnergy.Value;
            App.athleteUser.Time = (int) athleteTime.Value;

            await Navigation.PushAsync(new AthleteEquipmentStatusPage());
        }
    }
}