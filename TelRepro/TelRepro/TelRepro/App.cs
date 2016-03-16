using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Unity;
using TelRepro.Views;
using Xamarin.Forms;

namespace TelRepro
{
    public class App : PrismApplication
    {
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void OnInitialized()
        {
            NavigationService.Navigate("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
        }
    }
}
