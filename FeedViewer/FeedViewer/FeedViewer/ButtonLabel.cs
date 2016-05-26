using System;
using Xamarin.Forms;

namespace FeedViewer
{
    public class ButtonLabel : Label
    {
        public event EventHandler Tapped;

        public void RaiseTapped() => Tapped?.Invoke(this, EventArgs.Empty);
    }
}
