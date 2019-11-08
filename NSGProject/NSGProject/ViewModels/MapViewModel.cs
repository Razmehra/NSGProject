using Esri.ArcGISRuntime.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSGProject.ViewModels
{
    public class MapViewModel : BaseViewModel
    {
        public MapViewModel()
        {

        }

        //  private Map _map = new Map(Basemap.CreateStreets());
       // private Map _map = new Map(BasemapType.Topographic, 23.2324, 77.4310400000001, 16);
        private Map _map = new Map(BasemapType.Topographic, 28.616552, 77.032572, 16);

        //28.616552
        public Map Map

        {
            get { return _map; }
            set { _map = value; OnPropertyChanged(); }
        }

    }
}
