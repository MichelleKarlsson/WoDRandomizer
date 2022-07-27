using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using WoDRandomizer.Models;
using WoDRandomizer.Views;
using Xamarin.Forms;

namespace WoDRandomizer.ViewModels
{
    public class NewAthleteViewModel : BaseViewModel
    {
        
        public NewAthleteViewModel()
        {
            Title = "Who are you?";
        }


        public void OnAppearing()
        {
            IsBusy = true;
        }



        
    }
}