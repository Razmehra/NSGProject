using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NSGProject.Views;
using Esri.ArcGISRuntime;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NSGProject
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            ArcGISRuntimeEnvironment.Initialize();
            MainPage = new NavigationPage(  new MainPage());//new MainMenuPage();  //
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
