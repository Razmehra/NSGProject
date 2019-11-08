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
	public partial class ProfileDetailPage : ContentPage
	{
        private ProfileDetailModel profile = new ProfileDetailModel()
        {
            ID=1,
            FirstName="Rajendra",
            Surname="Mehra",
            PhoneNo="1234567898",
            MobileNo="4678944585",
            District="Delhi",
            Address="Dwarka mor, New Delhi",
            Designation="AEN",
            Designation_Additional="JEN",
            JENChowki="",
            JENChowki_Additional="ABC",
            SubDivision="CVC",
            SubDivision_Additional="CVC",
            Division="CVC",
            Division_Additional="CVC",
            Circle="XYZ",
            Circle_Additional="XYZ"
            
        };
		public ProfileDetailPage ()
		{
			InitializeComponent ();
            this.BindingContext = profile;
		}
	}
}