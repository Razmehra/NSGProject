using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Locations;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Android;
using static Android.Provider.Settings;
using System.Runtime.Remoting.Messaging;

using Android.Support.V4.View;
using Android.Support.V7.App;
using Xamarin.Forms;
using NSGProject.Droid.Implements;
using NSGProject.Services;

[assembly: Dependency(typeof(TestInterface))]
namespace NSGProject.Droid.Implements
{
    public class TestInterface : ITestInterface
    {
        

        public TestInterface() { }
        public void InvokeService()
        {

            
            //void GetLocSetting(){ }


            // LocationManager LM = (LocationManager)Forms.Context.GetSystemService(Context.LocationService);
            //LocationManager LM = (LocationManager)Android.App.Application.Context.GetSystemService(Context.LocationService);


            //if (LM.IsProviderEnabled(LocationManager.GpsProvider) == false)
            //{


            //    Context ctx = Android.App.Application.Context;
            //    ctx.StartActivity(new Intent(Android.Provider.Settings.ActionLocationSourceSettings));


            //}
            //else
            //{
            //    //this is handled in the PCL
            //}

            LocationManager LM = (LocationManager)Forms.Context.GetSystemService(Context.LocationService);


            if (LM.IsProviderEnabled(LocationManager.GpsProvider) == false)
            {


                Context ctx = Forms.Context;
                ctx.StartActivity(new Intent(Android.Provider.Settings.ActionLocationSourceSettings));


            }
            else
            {
                //this is handled in the PCL
            }

        }
    }
}