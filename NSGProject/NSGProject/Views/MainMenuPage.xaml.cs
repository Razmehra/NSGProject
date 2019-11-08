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
                    await Navigation.PushAsync(new NavigationPage(new AssignedWorkListView()) { Title = "Assigned Work List" });
                    break;
                case 2:
                    var mPage = new EMB_InspectionActivityPage { };
                    await Navigation.PushModalAsync(new NavigationPage(mPage));
                    mPage.InitializePage(new AssignedWorks { WorkID = 1, WorkOrder = 132, WorkName = "Construction of DoiT Building", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 1, FBPInfo = "", AssetName = "Building", Weightage = 0 });

                    break;
                case 3:
                    var mPage1 = new EMB_InspectionActivityPage { };
                    await Navigation.PushModalAsync(new NavigationPage(mPage1));
                    mPage1.InitializePage(new AssignedWorks { WorkID = 3, WorkOrder = 134, WorkName = "Construction of Bypass Road", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 3, FBPInfo = "", AssetName = "Road", Weightage = 0 }, true);
                    break;
                case 4:
                    var mPage2 = new EMBInspection_Building { };
                    await Navigation.PushModalAsync(new NavigationPage(mPage2));
                    mPage2.InitializePage(new EMBInspactionDetailsModel()
                    {
                        assignedWorks = new AssignedWorks { WorkID = 1, WorkOrder = 132, WorkName = "Construction of DoiT Building", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 1, FBPInfo = "", AssetName = "Building", Weightage = 0 },
                        ActivityID = 0,
                        ActivityName = "Earth Work",
                        BuildingID = "JP123412",
                        IndivisualWeightage = 15,
                        FloorNo = 2,
                        MeasurmentDate = DateTime.Parse("03-10-2019"),
                        EMBRemark = "Test eMB remark",
                        InspectionDate = DateTime.Now.Date,
                        PlannedArea = 2400,
                        CompletedArea = 1005,
                        InspectionStatus = "Not Started",
                        InspectionRemarks = "Test Inspection Remark",
                        InspectionType = "Contractor",
                        RoadID = "RJP123412",
                        PlannedLength = 4,
                        CompletedLength = 1,
                    });

                    break;
                case 5:
                    var mPage3 = new EMBInspection_Road { };
                    await Navigation.PushModalAsync(new NavigationPage(mPage3));
                    mPage3.InitializePage(new EMBInspactionDetailsModel()
                    {
                        assignedWorks = new AssignedWorks { WorkID = 3, WorkOrder = 134, WorkName = "Construction of Bypass Road", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 3, FBPInfo = "", AssetName = "Road", Weightage = 0 },
                        ActivityID = 0,
                        ActivityName = "Earth Work",
                        BuildingID = "JP123412",
                        IndivisualWeightage = 15,
                        FloorNo = 2,
                        MeasurmentDate = DateTime.Parse("03-10-2019"),
                        EMBRemark = "Test eMB remark",
                        InspectionDate = DateTime.Now.Date,
                        PlannedArea = 2400,
                        CompletedArea = 1005,
                        InspectionStatus = "Not Started",
                        InspectionRemarks = "Test Inspection Remark",
                        InspectionType = "Contractor",
                        RoadID = "RJP123412",
                        PlannedLength = 4,
                        CompletedLength = 1,
                    });

                    break;
                case 6:
                    var mPage4 = new ReviewEMBInspection_Building { };
                    await Navigation.PushModalAsync(new NavigationPage(mPage4));
                    mPage4.InitializePage(new EMBInspactionDetailsModel()
                    {
                        assignedWorks = new AssignedWorks { WorkID = 1, WorkOrder = 132, WorkName = "Construction of DoiT Building", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 1, FBPInfo = "", AssetName = "Building", Weightage = 0 },
                        ActivityID = 0,
                        ActivityName = "Earth Work",
                        BuildingID = "JP123412",
                        IndivisualWeightage = 15,
                        FloorNo = 2,
                        MeasurmentDate = DateTime.Parse("03-10-2019"),
                        EMBRemark = "Test eMB remark",
                        InspectionDate = DateTime.Now.Date,
                        PlannedArea = 2400,
                        CompletedArea = 1005,
                        InspectionStatus = "Not Started",
                        InspectionRemarks = "Test Inspection Remark",
                        InspectionType = "JEN",
                        RoadID = "RJP123412",
                        PlannedLength = 4,
                        CompletedLength = 1,
                    });
                    break;
                case 7:
                    var mPage5 = new ReviewEMBInspection_Road { };
                    await Navigation.PushModalAsync(new NavigationPage(mPage5));
                    mPage5.InitializePage(new EMBInspactionDetailsModel()
                    {
                        assignedWorks = new AssignedWorks { WorkID = 3, WorkOrder = 134, WorkName = "Construction of Bypass Road", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 3, FBPInfo = "", AssetName = "Road", Weightage = 0 },
                        ActivityID = 0,
                        ActivityName = "Earth Work",
                        BuildingID = "JP123412",
                        IndivisualWeightage = 15,
                        FloorNo = 2,
                        MeasurmentDate = DateTime.Parse("03-10-2019"),
                        EMBRemark = "Test eMB remark",
                        InspectionDate = DateTime.Now.Date,
                        PlannedArea = 2400,
                        CompletedArea = 1005,
                        InspectionStatus = "Not Started",
                        InspectionRemarks = "Test Inspection Remark",
                        InspectionType = "JEN",
                        RoadID = "RJP123412",
                        PlannedLength = 4,
                        CompletedLength = 1,
                    });


                    break;
                case 8:
                    await Navigation.PushModalAsync(new NavigationPage(new AOIPage() { Title = "Select AoI" }));
                    break;
                case 9:
                    await Navigation.PushModalAsync(new NavigationPage(new PendingSyncPage() { Title = "Pending Sync Work List" }));

                    break;
                case 10:
                    await Navigation.PushModalAsync(new NavigationPage(new ProfileDetailPage() { Title = "Profile Details" }));

                    break;
                case 11:
                    //var mPage6 = new NotificationTabbedPage { };
                    //await Navigation.PushModalAsync(new NavigationPage(mPage6));
                    //mPage6.InitializePage(new AssignedWorks { WorkID = 3, WorkOrder = 134, WorkName = "Construction of Bypass Road", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 3, FBPInfo = "", AssetName = "Road", Weightage = 0 });
                    NavigationPage xpage = new NavigationPage(new NotificationTabbedPage(new AssignedWorks { WorkID = 3, WorkOrder = 134, WorkName = "Construction of Bypass Road", M_S = "MS test1", Fin = 22, BoQ = 30, Phy = 30, WorkIndicator = 3, FBPInfo = "", AssetName = "Road", Weightage = 0 }));
                    await Navigation.PushAsync(xpage);
                    xpage.Title = "   Notifications List";

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