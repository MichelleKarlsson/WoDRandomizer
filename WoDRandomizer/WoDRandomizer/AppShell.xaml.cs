using System;
using System.Collections.Generic;
using WoDRandomizer.ViewModels;
using WoDRandomizer.Views;
using Xamarin.Forms;

namespace WoDRandomizer
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
        }

    }
}
