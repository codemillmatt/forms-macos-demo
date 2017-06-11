using System;
using MvvmHelpers;
using Xamarin.Forms;
using System.Windows.Input;
namespace Forms4Mac
{
    public class PlantedListViewModel : BaseViewModel
    {
        INavigation nav;

        public PlantedListViewModel(INavigation nav)
        {
            Title = "Alive Plants!!";
            this.Plants = new ObservableRangeCollection<Plant>(GardenCenter.GetPlanted());

            this.nav = nav;
        }

        public ObservableRangeCollection<Plant> Plants { get; set; }

        ICommand plantDied;
        public ICommand PlantDiedCommand
        {
            get =>
            plantDied ?? (plantDied = new Command<Plant>((Plant pl) => { 
                GardenCenter.ThePlantDied(pl);
                this.Plants.Remove(pl);
            }));
        }

        ICommand viewPlantDetail;
        public ICommand ViewPlantDetailCommand
        {
            get =>
            viewPlantDetail ?? (viewPlantDetail = new Command(async (obj) =>
            {
                var plant = obj as Plant;

                await nav.PushAsync(new PlantDetailPage(plant));
            }));
        }
    }
}
