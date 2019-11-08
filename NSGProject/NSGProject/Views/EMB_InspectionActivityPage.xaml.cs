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
	public partial class EMB_InspectionActivityPage : ContentPage
	{
        private AssignedWorks workitem { get; set; }
        private List<BuildingActivitiesModel> buildingActivities = new List<BuildingActivitiesModel>();
        public EMB_InspectionActivityPage ()
		{
			InitializeComponent ();
		}

        public void InitializePage(AssignedWorks assignedWork, bool ShowActionItemsPanel=false )
        {
            workitem = assignedWork;
            txtWorkOrder.Text = workitem.WorkOrder.ToString();
            txtWorkName.Text = workitem.WorkName;
            txtM_S.Text = workitem.M_S;
            txtFBPInfo.Text = $"Fin. P: {workitem.Fin}% | BoQ P: {workitem.BoQ}% | Phy. P: {workitem.Phy}%";
            txtAssetName.Text = workitem.AssetName;
            txtWeightage.Text = workitem.Weightage.ToString();
            if (workitem.AssetName.Contains("Building"))
            {
                buildingActivities.Add(new BuildingActivitiesModel { ActivityID = 1, ActivityName = "Earth Work" });
                buildingActivities.Add(new BuildingActivitiesModel { ActivityID = 2, ActivityName = "PCC" });
                buildingActivities.Add(new BuildingActivitiesModel { ActivityID = 3, ActivityName = "RCC Work upto P/L" });
            }
            else
            {
                buildingActivities.Add(new BuildingActivitiesModel { ActivityID = 1, ActivityName = "Earth Work" });
                buildingActivities.Add(new BuildingActivitiesModel { ActivityID = 2, ActivityName = "GSB" });
                buildingActivities.Add(new BuildingActivitiesModel { ActivityID = 3, ActivityName = "WBM" });
                buildingActivities.Add(new BuildingActivitiesModel { ActivityID = 3, ActivityName = "BT Work" });
                buildingActivities.Add(new BuildingActivitiesModel { ActivityID = 3, ActivityName = "CC Work" });
            }
            lstActivities.BindingContext = buildingActivities;
            lstActivities.ItemsSource = buildingActivities;
            if (ShowActionItemsPanel) BTN_Ex_Col_Clicked();
        }

        private void BTN_Ex_Col_Clicked(object sender=null, EventArgs e=null)
        {
            BTN_Ex_Col.Rotation = BTN_Ex_Col.Rotation == 0 ? 180 : 0;
            ActionPanel.IsVisible = BTN_Ex_Col.Rotation == 0 ? true : false;
        }

        private async void EMBInspectionButton_Clicked(object sender, EventArgs e)
        {
            //Prepair mock data for inspection
            // var xx = (lstActivities.SelectedItem as BuildingActivitiesModel).ActivityID;
            EMBInspactionDetailsModel eMBInspaction = new EMBInspactionDetailsModel()
            {
                assignedWorks = workitem,
                ActivityID = (lstActivities.SelectedItem as BuildingActivitiesModel).ActivityID,
                ActivityName = (lstActivities.SelectedItem as BuildingActivitiesModel).ActivityName,
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
            };
            // Page mPage = null;
            var mmPage = workitem.AssetName.Contains("Building")? new EMBInspection_Building { }:null;

            if (workitem.AssetName.Contains("Building")) {
                var mPage = new EMBInspection_Building { };
                await Navigation.PushModalAsync(new NavigationPage(mPage));
                mPage.InitializePage(eMBInspaction);

            }
            else {
                var  mPage = new EMBInspection_Road { };
                await Navigation.PushModalAsync(new NavigationPage(mPage));
                mPage.InitializePage(eMBInspaction);

            }
            //await Navigation.PushModalAsync(new NavigationPage(mPage));
            //mPage.InitializePage(eMBInspaction);

        }
    }
}