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
    public partial class EMBInspection_Building : ContentPage
    {
        private AssignedWorks works { get; set; }
        private EMBInspactionDetailsModel eMBInspaction = new EMBInspactionDetailsModel();
        public EMBInspection_Building()
        {
            InitializeComponent();
        }

        public void InitializePage(AssignedWorks assignedWorks=null)
        {
            works = assignedWorks;
            
        }

        private void OnFloorNoTappped(object sender, EventArgs e)
        {
            pkrFloorNo.Focus();
        }

        private void OnInspectionStatusTapped(object sender, EventArgs e)
        {
            // ((Picker)sender).Focus();
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