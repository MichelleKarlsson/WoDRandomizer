using System.ComponentModel;
using WoDRandomizer.ViewModels;
using Xamarin.Forms;

namespace WoDRandomizer.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}