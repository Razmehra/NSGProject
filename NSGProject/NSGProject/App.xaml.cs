using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NSGProject.Views;
using Esri.ArcGISRuntime;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NSGProject
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            ArcGISRuntimeEnvironment.Initialize();

            //GetConnect();
            MainPage = new NavigationPage(  new MainPage());//new MainMenuPage();  //
        }

        private async void GetConnect()
        {
            var json = "{Key=0}";


            HttpClient client = new HttpClient();
            string BaseUrl = "http://ssotest.rajasthan.gov.in:8888/SSOREST/SSOAuthenticationMobileJSON";
            client.BaseAddress = new Uri(BaseUrl);

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", "text/html, application/xhtml+xml, */*");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.8,sv-SE;q=0.5,sv;q=0.3");
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");


            var Dic = new Dictionary<string, string>
                {
                   {"Application", "mobile" },
                   {"UserName", "rohitr" },
                   {"password", "MTIzNDU2Nzg=" }
                   
                };


            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Content = new FormUrlEncodedContent(Dic);
            var value4 = new FormUrlEncodedContent(Dic);

            HttpResponseMessage response = await client.PostAsync(client.BaseAddress.ToString(), value4);

            string result = await response.Content.ReadAsStringAsync();



            //WebClient wClient = new WebClient();
            //wClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            //string response = wClient.UploadString(new Uri("http://ssotest.rajasthan.gov.in:8888/SSOREST/SSOAuthenticationMobileJSON"), "POST", json);

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
