using Xamarin.Forms;

namespace XamarinListViewTut
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new Tabbed();

            MainPage = new NavigationPage(new Tabbed());

            //MainPage = new MainPage();
            //MainPage = new XamarinListViewTut.EmployeeeListPage();
            //MainPage = new XamarinListViewTut.PlayerListPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
