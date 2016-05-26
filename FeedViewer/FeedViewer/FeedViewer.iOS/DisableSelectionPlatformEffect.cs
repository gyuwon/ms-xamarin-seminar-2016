using FeedViewer.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("FeedView")]
[assembly: ExportEffect(typeof(DisableSelectionPlatformEffect), "DisableSelection")]

namespace FeedViewer.iOS
{
    public class DisableSelectionPlatformEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var tableView = (UITableView)Control;
            tableView.AllowsSelection = false;
        }

        protected override void OnDetached()
        {
        }
    }
}
