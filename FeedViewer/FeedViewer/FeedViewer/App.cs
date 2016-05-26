using Xamarin.Forms;

namespace FeedViewer
{
    public class App : Application
    {
        public App()
        {
            var mainPage = new MainPage
            {
                FeedbackCollector = DependencyService.Get<IFeedbackCollector>()
            };
            MainPage = new NavigationPage(mainPage);
        }
    }
}
