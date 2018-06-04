using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
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
                        "android=a6951d9e-bdcb-47f3-8197-213d74bd59f9;" +
                            "ios=dc8be123-41b5-4576-b260-f63e5d7d3936;",
                  typeof(Analytics), typeof(Crashes));
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
