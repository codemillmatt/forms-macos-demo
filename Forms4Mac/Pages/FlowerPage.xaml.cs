using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Forms4Mac
{
    public partial class FlowerPage : ContentPage
    {
        void zinnia_clicked(object sender, EventArgs args)
        {
            var zinnia = new Plant
            {
                Name = "Zinnia",
                Quantity = 1,
                WikipediaUrl = "https://en.wikipedia.org/wiki/Zinnia"
            };

            GardenCenter.PlantThePlant(zinnia);
        }

        void daisy_clicked(object sender, EventArgs args)
        {
            var daisy = new Plant
            {
                Name = "Daisy",
                Quantity = 1,
                WikipediaUrl = "https://en.wikipedia.org/wiki/Bellis_perennis"
            };

            GardenCenter.PlantThePlant(daisy);
        }

        void marigold_clicked(object sender, EventArgs args)
        {
            var marigold = new Plant
            {
                Name = "Marigold",
                Quantity = 1,
                WikipediaUrl = "https://en.wikipedia.org/wiki/Tagetes_erecta"
            };

            GardenCenter.PlantThePlant(marigold);
        }

        public FlowerPage()
        {
            InitializeComponent();
            Title = "Add Flowers";
        }
    }
}
