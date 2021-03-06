﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CityQuest.Pages;
using CityQuest.ViewModels;


namespace CityQuest.Droid
{
    [Activity(Label = "CityQuest", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
         
            global::Xamarin.Forms.Forms.Init(this, bundle);

#if !GORILLA
            LoadApplication(new App());

#else
              LoadApplication(UXDivers.Gorilla.Droid.Player.CreateApplication(ApplicationContext,
              new UXDivers.Gorilla.Config("Good Gorilla")
              .RegisterAssemblyFromType<BasePage>()
              .RegisterAssemblyFromType<BaseViewModel>()
              .RegisterAssemblyFromType<UXDivers.Artina.Shared.CircleImage>()
              ));
#endif
        }
    }
}

