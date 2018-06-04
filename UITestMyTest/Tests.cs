using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestMyTest
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void WelcomeTextIsDisplayed()
		{
			AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
			app.Screenshot("Welcome screen.");

			Assert.IsTrue(results.Any());
		}

        [Test]
        public void ButtonConcatNamesClicked_UITest()
        {
            //Arrange
            app.EnterText("entryFirstName", "It");
            app.EnterText("entryLasttName", "Works");
            //Act
            app.Tap("buttonConcatNames");
            //Assert
            var result = app.Query("lableMergeResult").FirstOrDefault(oo => oo.Text == "It Works!");
            Assert.IsTrue(result != null, "not the expected concatenation of names");
        }

        public void ButtonConcatNamesClickedEmptyEntries_UITest()
        {
            //Arrange
            //app.EnterText("entryFirstName", "It");
            //app.EnterText("entryLasttName", "Works");
            //Act
            app.Tap("buttonConcatNames");
            //Assert
            var result = app.Query("lableMergeResult").FirstOrDefault(oo => oo.Text == "!");
            Assert.IsTrue(result != null, "not the expected concatenation of names");
        }
    }
}
