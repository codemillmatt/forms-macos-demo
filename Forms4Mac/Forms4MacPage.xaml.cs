using Xamarin.Forms;
using System.Runtime.Serialization.Formatters;


namespace Forms4Mac
{
    public partial class Forms4MacPage : ContentPage
    {
        void GardenCenter_Clicked(object sender, System.EventArgs args)
        {
            var md = App.Current.MainPage as MasterDetailPage;

            var tp = new TabbedPage();
            tp.Children.Add(new NavigationPage(new VeggiePage()) { Title = "Veggies" });
            tp.Children.Add(new NavigationPage(new HerbPage()) { Title = "Herbs" });
            tp.Children.Add(new NavigationPage(new FlowerPage()) { Title = "Flowers" });
            md.Detail = tp;

            md.IsPresented = false;
        }

        void Dead_Clicked(object sender, System.EventArgs args)
        {
            var md = App.Current.MainPage as MasterDetailPage;

            md.Detail = new NavigationPage(new DeadPlantListPage());
            md.IsPresented = false;
        }

        void InTheGarden_Clicked(object sender, System.EventArgs e)
        {
            var md = App.Current.MainPage as MasterDetailPage;

            md.Detail = new NavigationPage(new PlantedListPage());
            md.IsPresented = false;
        }

        public Forms4MacPage()
        {
            InitializeComponent();
        }
    }
}
