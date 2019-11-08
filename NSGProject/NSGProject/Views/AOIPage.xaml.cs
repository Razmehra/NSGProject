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
	public partial class AOIPage : ContentPage
	{
        private List<AOIModel> AOIList = new List<AOIModel>
        {
            new AOIModel{ID=1,Title="Jaipur"},
            new AOIModel{ID=2,Title="Ajmer"},
            new AOIModel{ID=3,Title="Jodhpur"},
            new AOIModel{ID=4,Title="Pali"},
            new AOIModel{ID=5,Title="Jhunjhunu"},
            new AOIModel{ID=6,Title="Churu"},
            new AOIModel{ID=7,Title="Bikaner"},
            new AOIModel{ID=8,Title="Ganganagar"},
            new AOIModel{ID=9,Title="Rajsamand"},
            new AOIModel{ID=10,Title="Sikar"},
            new AOIModel{ID=11,Title="Hanumangarh"},
            new AOIModel{ID=12,Title="Dousa"}
        };
		public AOIPage ()
		{
			InitializeComponent ();
            this.BindingContext = AOIList.OrderBy(x => x.Title);
            lstAOI.BindingContext = AOIList.OrderBy(x => x.Title);
            lstAOI.ItemsSource = AOIList.OrderBy(x => x.Title);

		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var SelectedAOIs = AOIList.Where(w=> w.IsSelected==true).OrderBy(x=> x.Title);
            string aois = "";
            foreach (var aoi in SelectedAOIs)
            {
                aois = aois + "\n" + aoi.Title;
            }
            await DisplayAlert("Selected AoI", aois==""?"No AoI selected.": aois, "Ok");
        }
    }
}