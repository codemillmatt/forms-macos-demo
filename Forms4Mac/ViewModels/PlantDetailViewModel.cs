using System;
using MvvmHelpers;
namespace Forms4Mac
{
    public class PlantDetailViewModel : BaseViewModel
    {
        public PlantDetailViewModel()
        {
        }

        Plant thePlant;
        public Plant ThePlant { get => thePlant; set => SetProperty(ref thePlant, value); }
    }
}
