using System;
using WoDRandomizer.Models;
using WoDRandomizer.Services;
using WoDRandomizer.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WoDRandomizer
{
    public partial class App : Application
    {
        public static Athlete athleteUser { get; set; }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<ExerciseDataStore>();
            athleteUser = new Athlete();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
