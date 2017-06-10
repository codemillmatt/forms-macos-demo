using System;
using MvvmHelpers;
namespace Forms4Mac
{
    public class DeadPlantListViewModel : BaseViewModel
    {
        public DeadPlantListViewModel()
        {
            DeadPlants = new ObservableRangeCollection<Plant>(GardenCenter.GetDead());
            Title = "Here lie the dead plants";
        }

        public ObservableRangeCollection<Plant> DeadPlants { get; set; }
    }
}
