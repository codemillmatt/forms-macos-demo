using Xamarin.Forms;

namespace Forms4Mac
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var md = new MasterDetailPage();
            md.Master = new Forms4MacPage();
            md.Detail = new NavigationPage(new PlantedListPage());
            MainPage = md;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
