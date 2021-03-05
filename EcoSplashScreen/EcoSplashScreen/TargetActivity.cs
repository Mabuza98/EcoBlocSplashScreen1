using Android.App;
using Android.OS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;

namespace EcoSplashScreen
{
    [Activity(Label = "TargetActivity",  Theme = "@style/MainTheme.AppCompat.Light.NoActionBar")]
    public class TargetActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Target);
        }
    }
}
