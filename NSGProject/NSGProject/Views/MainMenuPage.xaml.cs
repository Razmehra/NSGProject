using NSGProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NSGProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuPage : ContentPage
    {
        private List<MainMenuItem> mainMenuItems = new MainMenuItem().GetMainMenuItems();

        public MainMenuPage()
        {
            // mainMenuItems = new MainMenuItem().GetMainMenuItems();

            InitializeComponent();
            MenuListView.ItemsSource = mainMenuItems;
            BindingContext = mainMenuItems;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            int MenuID = int.Parse(((Button)sender).CommandParameter.ToString());
            switch (MenuID)
            {
                case 1:
                    await  Navigation.PushAsync(new NavigationPage(new AssignedWorkListView()) {  Title= "Assigned Work List" });
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                default:
                    break;
            }

        }
    }
}