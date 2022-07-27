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
    public class WorkoutDataStore : IDataStore<Exercise>
    {
        readonly List<Exercise> workouts = new List<Exercise>();

        public WorkoutDataStore()
        {
            //var o = File.ReadAllText(@"D:\WoDRandomizer\WoDRandomizer\WoDRandomizer\exercises.json").ToString();
            //workouts.Add(JsonConvert.DeserializeObject<Exercise>(o));
        }

        public async Task<bool> AddItemAsync(Exercise exercise)
        {
            workouts.Add(exercise);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Exercise exercise)
        {
            var oldItem = workouts.Where((Exercise arg) => arg.Id == exercise.Id).FirstOrDefault();
            workouts.Remove(oldItem);
            workouts.Add(exercise);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = workouts.Where((Exercise arg) => arg.Id == id).FirstOrDefault();
            workouts.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Exercise> GetItemAsync(string id)
        {
            return await Task.FromResult(workouts.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Exercise>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(workouts);
        }
    }
}