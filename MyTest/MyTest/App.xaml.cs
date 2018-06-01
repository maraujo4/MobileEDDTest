using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;

using Xamarin.Forms;

namespace MyTest
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new Pages.MainPage());
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start("uwp=9f26981d-c7d1-4712-854e-5ac160e877e5;" +
                        "android=d651a9ad-0aa4-4a6e-8bb4-885d1a87a2e7;" +
                            "ios=dc8be123-41b5-4576-b260-f63e5d7d3936;",
                  typeof(Analytics));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
