﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using Xamarin.Forms;
using Xamarin;
using Xamarin.Forms.Platform.iOS;

namespace HoustonForms.iOS
{
    [Register("AppDelegate")]
	public partial class AppDelegate : FormsApplicationDelegate
    {
        UIWindow window;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

			LoadApplication (new App());

			return base.FinishedLaunching (app, options);
        }
    }
}

