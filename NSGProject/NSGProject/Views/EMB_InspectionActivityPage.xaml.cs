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

        public void InitializePage(AssignedWorks assignedWork)
        {
            workitem = assignedWork;
            txtWorkOrder.Text = workitem.WorkOrder.ToString();
            txtWorkName.Text = workitem.WorkName;
            txtM_S.Text = workitem.M_S;
            txtFBPInfo.Text = $"Fin. P: {workitem.Fin}% | BoQ P: {workitem.BoQ}% | Phy. P: {workitem.Phy}%";
            txtAssetName.Text = workitem.AssetName;
            txtWeightage.Text = workitem.Weightage.ToString();

            buildingActivities.Add(new BuildingActivitiesModel { ActivityID = 1, ActivityName = "Earth Work" });
            buildingActivities.Add(new BuildingActivitiesModel { ActivityID = 2, ActivityName = "PCC" });
            buildingActivities.Add(new BuildingActivitiesModel { ActivityID = 3, ActivityName = "RCC Work upto P/L" });
            lstActivities.BindingContext = buildingActivities;
            lstActivities.ItemsSource = buildingActivities;
        }

        private void BTN_Ex_Col_Clicked(object sender, EventArgs e)
        {
            BTN_Ex_Col.Rotation = BTN_Ex_Col.Rotation == 0 ? 180 : 0;
            ActionPanel.IsVisible = BTN_Ex_Col.Rotation == 0 ? true : false;
        }

        private async void EMBInspectionButton_Clicked(object sender, EventArgs e)
        {
            var mPage = new EMBInspection_Building { };
            await Navigation.PushModalAsync(new NavigationPage(mPage));
            mPage.InitializePage();

        }
    }
}