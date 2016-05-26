using Xamarin.Forms;

namespace FeedViewer
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
