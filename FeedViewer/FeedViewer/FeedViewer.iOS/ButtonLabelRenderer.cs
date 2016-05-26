using FeedViewer;
using FeedViewer.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ButtonLabel), typeof(ButtonLabelRenderer))]

namespace FeedViewer.iOS
{
    public class ButtonLabelRenderer : LabelRenderer
    {
        public ButtonLabelRenderer()
        {
            AddGestureRecognizer(new UITapGestureRecognizer(OnTapped));
        }

        private void OnTapped()
        {
            var element = Element as ButtonLabel;
            element?.RaiseTapped();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Label element = e.NewElement;
            UILabel control = Control;
            if (element != null && control != null)
            {
                control.AttributedText = new NSAttributedString(
                    element.Text, underlineStyle: NSUnderlineStyle.Single);
            }
        }
    }
}
