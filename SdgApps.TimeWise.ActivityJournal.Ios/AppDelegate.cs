﻿// <copyright file="AppDelegate.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.Ios
{
    using Foundation;
    using UIKit;

    /// <summary>
    /// The UIApplicationDelegate for the application. This class is responsible for launching the
    /// User Interface of the application, as well as listening (and optionally responding) to
    /// application events from iOS.
    /// </summary>
    [Register("AppDelegate")]
    public partial class AppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        /// <inheritdoc/>
        /// <remarks>
        /// This method is invoked when the application has loaded and is ready to run. In this
        /// method you should instantiate the window, load the UI into it and then make the window
        /// visible.
        ///
        /// You have 17 seconds to return from this method, or iOS will terminate your application.
        /// </remarks>
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            Xamarin.Forms.Forms.Init();
            this.LoadApplication(new App());

            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
