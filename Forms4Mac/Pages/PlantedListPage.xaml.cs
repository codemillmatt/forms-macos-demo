using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Forms4Mac
{
    public partial class PlantedListPage : ContentPage
    {
        PlantedListViewModel vm;

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var mi = (MenuItem)sender;

            vm.PlantDiedCommand.Execute(mi.CommandParameter);
        }

        public PlantedListPage()
        {
            InitializeComponent();

            vm = new PlantedListViewModel(Navigation);
            BindingContext = vm;
        }
    }
}
