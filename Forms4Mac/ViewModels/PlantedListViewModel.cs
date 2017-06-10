using System;
using MvvmHelpers;
using Xamarin.Forms;
using System.Windows.Input;
namespace Forms4Mac
{
    public class PlantedListViewModel : BaseViewModel
    {
        public PlantedListViewModel()
        {
            Title = "Alive Plants!!";
            this.Plants = new ObservableRangeCollection<Plant>(GardenCenter.GetPlanted());
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
    }
}
