using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Telerik.XamarinForms.Common.Android;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControlsRenderer.Android;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(RadListView), typeof(ListViewRenderer))]
[assembly: ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadCartesianChart), typeof(Telerik.XamarinForms.ChartRenderer.Android.CartesianChartRenderer))]
namespace TelRepro.Droid
{
    [Activity(Label = "TelRepro", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            TelerikForms.Init();
            LoadApplication(new App());
        }
    }
}

