using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Linq;
namespace Forms4Mac
{
    public class GardenCenter
    {
        static void Initialize()
        {
            if (!App.Current.Properties.ContainsKey("alive"))
            {
                var seedlings = new List<Plant>() { new Plant { Name = "Tomato", Quantity = 1, WikipediaUrl = "https://en.wikipedia.org/wiki/Tomato" } };
                App.Current.Properties.Add("alive", JsonConvert.SerializeObject(seedlings));
            }

			if (!App.Current.Properties.ContainsKey("dead"))
			{
				var seedlings = new List<Plant>() { new Plant { Name = "Eggplant", Quantity = 1, WikipediaUrl = "https://en.wikipedia.org/wiki/Eggplant" } };
				App.Current.Properties.Add("dead", JsonConvert.SerializeObject(seedlings));
			}

		}

        public static List<Plant> GetPlanted()
        {
            Initialize();

            var aliveJson = App.Current.Properties["alive"].ToString();

            return JsonConvert.DeserializeObject<List<Plant>>(aliveJson);
        }

        public static List<Plant> GetDead()
        {
            Initialize();

            var deadJson = App.Current.Properties["dead"].ToString();

            return JsonConvert.DeserializeObject<List<Plant>>(deadJson);
        }

        public static List<Plant> PlantThePlant(Plant plant)
        {
            Initialize();

            var aliveJson = App.Current.Properties["alive"].ToString();

            var alivePlants = JsonConvert.DeserializeObject<List<Plant>>(aliveJson);

            var plantType = alivePlants.FirstOrDefault((arg) => arg.Name == plant.Name);

            if (plantType != null)
            {
                plant.Quantity += plantType.Quantity;

                alivePlants.Remove(plantType);
            }

            alivePlants.Add(plant);

            App.Current.Properties["alive"] = JsonConvert.SerializeObject(alivePlants);

            return alivePlants;
        }

        public static List<Plant> ThePlantDied(Plant plant)
        {
            Initialize();

            RemoveTheAlivePlant(plant);

            var deadJson = App.Current.Properties["dead"].ToString();

            var deadPlants = JsonConvert.DeserializeObject<List<Plant>>(deadJson);

            deadPlants.Add(plant);

            App.Current.Properties["dead"] = JsonConvert.SerializeObject(deadPlants);

            return deadPlants;
        }

        private static void RemoveTheAlivePlant(Plant plant)
        {
			var aliveJson = App.Current.Properties["alive"].ToString();

			var alivePlants = JsonConvert.DeserializeObject<List<Plant>>(aliveJson);

			alivePlants.RemoveAll((arg) => arg.Name == plant.Name);

            App.Current.Properties["alive"] = JsonConvert.SerializeObject(alivePlants);
        }
    }
}
