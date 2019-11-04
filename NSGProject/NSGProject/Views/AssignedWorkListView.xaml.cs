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
    public partial class AssignedWorkListView : ContentPage
    {
        public List<AssignedWorks> assignedWorks = new List<AssignedWorks>();
        public AssignedWorkListView()
        {
            PopulateDate();

            InitializeComponent();
            WorkListView.ItemsSource = assignedWorks;
            this.BindingContext = assignedWorks;
            NavigationPage.SetBackButtonTitle(this, "Back");
            //NavigationPage.

        }

        private void PopulateDate()
        {
            //$"Fin. P:{Fin}%|BoQ P:{BoQ}%|Phy. P:{Phy}%"
            assignedWorks.Add(new AssignedWorks { WorkID = 1, WorkOrder = 132, WorkName = "Construction of DoiT Building", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 1, FBPInfo="" });
            assignedWorks.Add(new AssignedWorks { WorkID = 2, WorkOrder = 133, WorkName = "Construction of Police Quarter", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 2, FBPInfo = "" });
            assignedWorks.Add(new AssignedWorks { WorkID = 3, WorkOrder = 134, WorkName = "Construction of Bypass Road", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 3, FBPInfo = "" });
            assignedWorks.Add(new AssignedWorks { WorkID = 4, WorkOrder = 135, WorkName = "Construction of Work1", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 5, FBPInfo = "" });
            assignedWorks.Add(new AssignedWorks { WorkID = 5, WorkOrder = 136, WorkName = "Construction of Work2", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 1 ,FBPInfo = "" });
            assignedWorks.Add(new AssignedWorks { WorkID = 6, WorkOrder = 137, WorkName = "Construction of Work3", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 3, FBPInfo = "" });
            assignedWorks.Add(new AssignedWorks { WorkID = 7, WorkOrder = 138, WorkName = "Construction of Work4", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 11, FBPInfo = "" });
            assignedWorks.Add(new AssignedWorks { WorkID = 8, WorkOrder = 139, WorkName = "Construction of Work5", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 15, FBPInfo = "" });
            assignedWorks.Add(new AssignedWorks { WorkID = 9, WorkOrder = 140, WorkName = "Construction of Work6", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 155, FBPInfo = "" });
            assignedWorks.Add(new AssignedWorks { WorkID = 10, WorkOrder = 12300, WorkName = "Construction of Work7", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 20 ,FBPInfo = "" });

        }

        private async void WorkListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = (AssignedWorks)e.SelectedItem;
            // NavigationPage newPage = new NavigationPage(new MapPageBuilding(selectedItem) );

            //  newPage.Title = "Hello World";
            //  await Navigation.PushModalAsync( new NavigationPage(newPage));
            var mPage = new MapPageBuilding { };
            // mPage.workitemID = 11;
            // var xpage = new NavigationPage(new MapPageBuilding { Title = "Raz" , workitemID=11});
            await Navigation.PushModalAsync(new NavigationPage(mPage));// new MapPageBuilding() { Title="Hello" }));
            //mPage.Title = "Rajendra";
            mPage.RefreshPage(selectedItem);
            // newPage.BarTextColor = Color.Green;

        }

    }
    //Nested ViewModel
}