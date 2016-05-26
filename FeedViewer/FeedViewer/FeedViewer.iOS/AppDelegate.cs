using Foundation;
using HockeyApp;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace FeedViewer.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        // HockeyApp 인스턴스는 세미나 종료후 삭제될 예정입니다. 예제를 실행하려면
        // HockeyApp 인스턴스 생성 후 HockeyAppId를 수정해주세요.
        public const string HockeyAppId = "c3ab6d4a68284700b45b393a3ce0d571";

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            var manager = BITHockeyManager.SharedHockeyManager;
            manager.Configure(appIdentifier: HockeyAppId);
            manager.StartManager();

            return base.FinishedLaunching(app, options);
        }
    }
}
