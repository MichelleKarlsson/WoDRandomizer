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

        public AthleteCurrentStatusPage()
        {
            InitializeComponent();
            InitializeMusclegroups();
        }

        private void InitializeMusclegroups() //TODO: refactor
        {
            MusclegroupsToAvoid.Add("");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            greetingLabel.Text = "Welcome back, " + App.athleteUser.Name;

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