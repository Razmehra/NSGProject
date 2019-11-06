using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.UI;
using Esri.ArcGISRuntime.Xamarin.Forms;
using NSGProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NSGProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPageBuilding : ContentPage
    {
        public AssignedWorks workitem { get; set; }
        private GraphicsOverlay overlay { get; set; }

        public MapPageBuilding()
        {
            InitializeComponent();
            Initialize();

        }

        private async void Initialize()
        {
            // Create overlay to where graphics are shown
            overlay = new GraphicsOverlay();

            // Add created overlay to the MapView
            MapView.GraphicsOverlays.Add(overlay);

            // Add graphics using different source types
            // CreatePictureMarkerSymbolFromUrl(overlay);
            await CreatePictureMarkerSymbolFromResources(overlay);

            MapView.GeoViewTapped += MapView_GeoViewTapped;

        }

        private async void MapView_GeoViewTapped(object sender, GeoViewInputEventArgs e)
        {
            //await CreatePictureMarkerSymbolFromResources(overlay);
            IdentifyGraphicsOverlayResult identifyResults = await MapView.IdentifyGraphicsOverlayAsync(
                    overlay,
                    e.Position,
                    10,
                    false,
                    1);
            if (identifyResults.Graphics.Count() > 0)
            {
                identifyResults.Graphics[0].IsSelected = !identifyResults.Graphics[0].IsSelected;
                if (identifyResults.Graphics[0].IsSelected)
                {
                    var mPage = new EMB_InspectionActivityPage { };
                    await Navigation.PushModalAsync(new NavigationPage(mPage));
                    mPage.InitializePage(workitem);
                }
                // if (identifyResults.Graphics[0].IsSelected) await Navigation.PushAsync(new NavigationPage(new EMB_InspectionActivityPage()));// await Navigation.PushModalAsync(new NavigationPage(new AboutPage()));
            }

        }

        private async Task CreatePictureMarkerSymbolFromResources(GraphicsOverlay overlay)
        {
            Assembly currentAssembly = null;
#if WINDOWS_UWP
            // Get current assembly that contains the image
            currentAssembly = GetType().GetTypeInfo().Assembly;
#else
            // Get current assembly that contains the image
            currentAssembly = Assembly.GetExecutingAssembly();
#endif

            var imgsource = currentAssembly.GetManifestResourceNames();
            // Get image as a stream from the resources
            // Picture is defined as EmbeddedResource and DoNotCopy
            var resourceStream = currentAssembly.GetManifestResourceStream(imgsource[0]);// "pin_star_blue.png");

            // Create new symbol using asynchronous factory method from stream
            PictureMarkerSymbol pinSymbol = await PictureMarkerSymbol.CreateAsync(resourceStream);
            pinSymbol.Height = 50;
            pinSymbol.Width = 50;

            // Create location for the pint
            MapPoint pinPoint = new MapPoint(8619529.22253879, 2660417.48642509, SpatialReferences.WebMercator);

            // Create graphic with the location and symbol
            Graphic pinGraphic = new Graphic(pinPoint, pinSymbol);

            // Add graphic to the graphics overlay
            overlay.Graphics.Add(pinGraphic);
        }

        public void RefreshPage(AssignedWorks assignedWork)
        {
            workitem = assignedWork;
            txtWorkOrder.Text = workitem.WorkOrder.ToString();
            txtWorkName.Text = workitem.WorkName;
            txtM_S.Text = workitem.M_S;
            txtFBPInfo.Text = $"Fin. P: {workitem.Fin}% | BoQ P: {workitem.BoQ}% | Phy. P: {workitem.Phy}%";
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new NavigationPage(new AboutPage()));
        //}

        private void BTN_Ex_Col_Clicked(object sender, EventArgs e)
        {
            BTN_Ex_Col.Rotation = BTN_Ex_Col.Rotation == 0 ? 180 : 0;
            ActionPanel.IsVisible = BTN_Ex_Col.Rotation == 0 ? true : false;
        }
    }
}