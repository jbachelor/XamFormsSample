using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamFormsSample.Droid
{
    [Activity(Label = "XamFormsSample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnCreate)}");
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnDestroy)}");
        }

        protected override void OnPause()
        {
            base.OnPause();
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnPause)}");
        }

        protected override void OnRestart()
        {
            base.OnRestart();
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnRestart)}");
        }

        protected override void OnResume()
        {
            base.OnResume();
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnResume)}");
        }

        protected override void OnStart()
        {
            base.OnStart();
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnStart)}");
        }

        protected override void OnStop()
        {
            base.OnStop();
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnStop)}");
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnRequestPermissionsResult)}");
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}