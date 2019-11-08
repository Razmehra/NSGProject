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
	public partial class ReviewEMBInspection_Building : ContentPage
	{
        private AssignedWorks works { get; set; }
        public EMBInspactionDetailsModel eMBInspaction { get; set; }

        public ReviewEMBInspection_Building ()
		{
			InitializeComponent ();
		}

        public void InitializePage(EMBInspactionDetailsModel inspectionDetails = null)
        {
            works = inspectionDetails.assignedWorks;
            eMBInspaction = inspectionDetails;
            // InitializeComponent();
            this.BindingContext = eMBInspaction;//.assignedWorks.WorkOrder;
            this.pkrFloorNo.SelectedItem = eMBInspaction.FloorNo;
            txtActivityName.Text = eMBInspaction.ActivityName;
            txtWorkOrder.Text = eMBInspaction.assignedWorks.WorkOrder.ToString();
            txtWorkName.Text = eMBInspaction.assignedWorks.WorkName;
            txtM_S.Text = eMBInspaction.assignedWorks.M_S;
            txtFBPInfo.Text = eMBInspaction.assignedWorks.FBPInfo;
            pkrInspectionStatus.SelectedItem = eMBInspaction.InspectionStatus;
        }

        private void OnFloorNoTappped(object sender, EventArgs e)
        {
            pkrFloorNo.Focus();
        }

        private void OnInspectionStatusTapped(object sender, EventArgs e)
        {
            pkrInspectionStatus.Focus();
        }
        private void OnPickerClicked(object sender, EventArgs e)
        {
            ((Picker)sender).Focus();
        }

        private void MeasurmentDateTapped(object sender, EventArgs e)
        {
            DtPkrMeasurmentDate.Focus();
        }


    }
}