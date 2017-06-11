using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Forms4Mac
{
    public partial class PlantDetailPage : ContentPage
    {
        public PlantDetailPage()
        {
            InitializeComponent();
        }

        public PlantDetailPage(Plant thePlant) 
        {
            InitializeComponent();

            BindingContext = thePlant;

            //web.Source = thePlant.WikipediaUrl;
        }
    }
}
