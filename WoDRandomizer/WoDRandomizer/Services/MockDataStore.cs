using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WoDRandomizer.Models;

namespace WoDRandomizer.Services
{
    public class MockDataStore : IDataStore<Exercise>
    {
        readonly List<Exercise> exercises = new List<Exercise>();

        public MockDataStore()
        {
            var o = File.ReadAllText(@"D:\WoDRandomizer\WoDRandomizer\WoDRandomizer\exercises.json").ToString();
            exercises.Add(JsonConvert.DeserializeObject<Exercise>(o));
        }

        public async Task<bool> AddItemAsync(Exercise exercise)
        {
            exercises.Add(exercise);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Exercise exercise)
        {
            var oldItem = exercises.Where((Exercise arg) => arg.Id == exercise.Id).FirstOrDefault();
            exercises.Remove(oldItem);
            exercises.Add(exercise);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = exercises.Where((Exercise arg) => arg.Id == id).FirstOrDefault();
            exercises.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Exercise> GetItemAsync(string id)
        {
            return await Task.FromResult(exercises.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Exercise>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(exercises);
        }
    }
}