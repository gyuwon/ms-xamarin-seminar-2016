using FeedViewer.iOS;
using HockeyApp;
using Xamarin.Forms;

[assembly: Dependency(typeof(FeedbackCollector))]

namespace FeedViewer.iOS
{
    public class FeedbackCollector : IFeedbackCollector
    {
        public void ShowFeedbackView()
        {
            var manager = BITHockeyManager.SharedHockeyManager;
            BITFeedbackManager feedbackManager = manager.FeedbackManager;
            feedbackManager.ShowFeedbackComposeView();
        }
    }
}
