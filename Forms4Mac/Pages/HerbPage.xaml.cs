using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Forms4Mac
{
    public partial class HerbPage : ContentPage
    {
        void cilantro_Clicked(object sender, EventArgs args)
        {
            var cilantro = new Plant
            {
                Name = "Cilantro",
                Quantity = 1,
                WikipediaUrl = "https://en.wikipedia.org/wiki/Coriander"
            };

            GardenCenter.PlantThePlant(cilantro);
        }

        void basil_Clicked(object sender, EventArgs args)
        {
            var basil = new Plant
            {
                Name = "Basil",
                Quantity = 1,
                WikipediaUrl = "https://en.wikipedia.org/wiki/Basil"
            };

            GardenCenter.PlantThePlant(basil);
        }

        public HerbPage()
        {
            InitializeComponent();
            Title = "Add Herbs";
        }
    }
}
