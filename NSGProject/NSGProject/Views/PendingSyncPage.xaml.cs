using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSGProject.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NSGProject.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PendingSyncPage : ContentPage
	{
        private List<PendingSyncWorkModel> PendingSyncList = new List<PendingSyncWorkModel>
        {
           new PendingSyncWorkModel{SrNo=1, WorkModule="eMB & Inspection", PendingSince=DateTime.Now.AddDays(-1), WorkID="12100"},
           new PendingSyncWorkModel{SrNo=2, WorkModule="eMB & Inspection", PendingSince=DateTime.Now.AddDays(-2),WorkID="12200"},
           new PendingSyncWorkModel{SrNo=3, WorkModule="eMB & Inspection", PendingSince=DateTime.Now.AddDays(-3),WorkID="13100"},
           new PendingSyncWorkModel{SrNo=4, WorkModule="Validate ATR", PendingSince=DateTime.Now.AddDays(-4),WorkID="14100"},
           new PendingSyncWorkModel{SrNo=5, WorkModule="eMB & Inspection", PendingSince=DateTime.Now.AddDays(-5),WorkID="X52100"},
           new PendingSyncWorkModel{SrNo=6, WorkModule="Validate Handrance", PendingSince=DateTime.Now.AddDays(-6),WorkID="XY1510"},
           new PendingSyncWorkModel{SrNo=7, WorkModule="eMB & Inspection", PendingSince=DateTime.Now.AddDays(-7),WorkID="Y6100"},
           new PendingSyncWorkModel{SrNo=8, WorkModule="Validate ATR", PendingSince=DateTime.Now.AddDays(-8),WorkID="121"},
           new PendingSyncWorkModel{SrNo=9, WorkModule="Validate ATR", PendingSince=DateTime.Now.AddDays(-9),WorkID="1500"},
           new PendingSyncWorkModel{SrNo=10, WorkModule="eMB & Inspection", PendingSince=DateTime.Now.AddDays(-10),WorkID="XYZ510"},
           new PendingSyncWorkModel{SrNo=11, WorkModule="Validate Handrance", PendingSince=DateTime.Now.AddDays(-11),WorkID="TPR180"},
           new PendingSyncWorkModel{SrNo=12, WorkModule="Validate Handrance", PendingSince=DateTime.Now.AddDays(-12),WorkID="XMR1236"},
           new PendingSyncWorkModel{SrNo=13, WorkModule="eMB & Inspection", PendingSince=DateTime.Now.AddDays(-13),WorkID="LT12354"},
        };
		public PendingSyncPage ()
		{
			InitializeComponent ();
            this.BindingContext = PendingSyncList;
            LV_PendingSync.BindingContext = PendingSyncList;
            LV_PendingSync.ItemsSource = PendingSyncList;
            //HH:mm:ss
            lblLastSyncDate.Text = $"Last Sync Update : {DateTime.Now.AddDays(-20).ToString("dd/MM/yyyy HH:mm tt")}";

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}