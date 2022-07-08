using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using WoDRandomizer.Models;
using Xamarin.Forms;

namespace WoDRandomizer.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string name;
        private string category;
        private List<string> musclegroups;
        private List<string> equipment;
        private string skill;

        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
