﻿using System;
using System.Collections.Generic;
using System.Linq;
using CityQuest.Pages;
using Foundation;
using UIKit;
using UXDivers.Gorilla;
using UXDivers.Gorilla.iOS;
using CityQuest.ViewModels;


namespace CityQuest.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
      
#if !GORILLA
         LoadApplication(new App());  
#else
            LoadApplication(UXDivers.Gorilla.iOS.Player.CreateApplication(
                new UXDivers.Gorilla.Config("Good Gorilla")
                    .RegisterAssemblyFromType<BasePage>()
                    .RegisterAssemblyFromType<BaseViewModel>()
                    .RegisterAssemblyFromType<UXDivers.Artina.Shared.CircleImage>()

                ));
#endif
            return base.FinishedLaunching(app, options);
        }
    }
}
