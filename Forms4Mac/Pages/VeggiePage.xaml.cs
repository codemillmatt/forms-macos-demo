using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Forms4Mac
{
    public partial class VeggiePage : ContentPage
    {
        void AddPepper(object sender, EventArgs args)
        {
            var jalapeno = new Plant
            {
                Name = "Jalapeno Pepper",
                Quantity = 1,
                WikipediaUrl = "https://en.wikipedia.org/wiki/Jalape%C3%B1o"
            };

            GardenCenter.PlantThePlant(jalapeno);
        }

        void AddSquash(object sender, EventArgs args)
        {
            var squash = new Plant
            {
                Name = "Spaghetti Squash",
                Quantity = 1,
                WikipediaUrl = "https://en.wikipedia.org/wiki/Spaghetti_squash"
            };

            GardenCenter.PlantThePlant(squash);
        }

        void AddKale(object sender, EventArgs args)
        {
            var kale = new Plant
            {
                Name = "Kale",
                Quantity = 1,
                WikipediaUrl = "https://en.wikipedia.org/wiki/Kale"
            };

            GardenCenter.PlantThePlant(kale);
        }

        void AddEggplant(object sender, EventArgs args)
        {
            var eggplant = new Plant
            {
                Name = "Eggplant",
                Quantity = 1,
                WikipediaUrl = "https://en.wikipedia.org/wiki/Eggplant"
            };

            GardenCenter.PlantThePlant(eggplant);
        }

        void AddTomato(object sender, EventArgs args)
        {
            var tomato = new Plant
            {
                Name = "Tomato",
                Quantity = 1,
                WikipediaUrl = "https://en.wikipedia.org/wiki/Tomato"
            };

            GardenCenter.PlantThePlant(tomato);
        }

        public VeggiePage()
        {
            InitializeComponent();
            Title = "Add Vegetables!";
        }
    }
}
