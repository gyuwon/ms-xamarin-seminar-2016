using System;
using System.Net.Http;
using FeedViewer.DataContract;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace FeedViewer
{
    public partial class MainPage : ContentPage
    {
        // API 인스턴스는 세미나 종료후 삭제될 예정입니다. 예제를 실행하려면
        // FeedViewer.Api 프로젝트 배포 후 ApiBaseAddress를 수정해주세요.
        public const string ApiBaseAddress = "http://ms-xamarin-seminar-2016.azurewebsites.net/";

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(ApiBaseAddress);
            HttpResponseMessage response =
                await httpClient.GetAsync("api/feed");
            string json = await response.Content.ReadAsStringAsync();
            _feed.ItemsSource = JsonConvert.DeserializeObject<FeedItem[]>(json);
        }

        private void OnUserNameTapped(object sender, EventArgs e)
        {
            if (new Random().Next() % 5 == 0)
                throw new InvalidOperationException("This should be tracked.");

            var userName = (Label)sender;
            var feedItem = (FeedItem)userName.BindingContext;
            Navigation.PushAsync(new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Image
                        {
                            Source = new UriImageSource
                            {
                                Uri = new Uri(feedItem.ProfilePictureUri)
                            }
                        },
                        new Label { Text = feedItem.UserName }
                    }
                }
            });
        }
    }
}
