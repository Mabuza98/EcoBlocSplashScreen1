using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Drawing;
using EcoSplashScreen.Droid;

namespace EcoSplashScreen
{
    [Activity(Label = "EcoSplashScreen", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MainTheme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {


            base.OnCreate(bundle);

            //Show Splash Screen
            var config = new EcoSplashScreen(this)
                .WithFullScreen()
                .WithTargetActivity(Java.Lang.Class.FromType(typeof(TargetActivity)))
                .WithSplashTimeOut(5000) // 5 sec                
                .WithBackgroundColor(Color.LawnGreen)
                .WithLogo(Resource.Drawable.logo)
                .WithHeaderText("Welcome Guest !!!")
                .WithFooterText("Copyright 2021")
                .WithBeforLogoText("EcoBloc")
                .WithAfterLogoText("welcome to EcoBloc");


                // text color
            object p = config.HeaderTextView.SetTextColor(Color.Green);
            config.FooterTextView.SetTextColor(Color.Green);
            config.BeforeLogoTextView.SetTextColor(Color.Green);
            config.AfterLogoTextView.SetTextColor(Color.Green);

            // view
            View view = config.Create();

            // Content View
            SetContentView(view);
        }

    }
}