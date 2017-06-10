using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Forms4Mac
{
    public partial class DeadPlantListPage : ContentPage
    {
        public DeadPlantListPage()
        {
            InitializeComponent();

            BindingContext = new DeadPlantListViewModel();
        }
    }
}
