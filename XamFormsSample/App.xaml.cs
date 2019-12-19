using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamFormsSample.Views;

namespace XamFormsSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnStart)}");
            base.OnStart();
        }

        protected override void OnSleep()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnSleep)}");
            base.OnSleep();
        }

        protected override void OnResume()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnResume)}");
            base.OnResume();
        }
    }
}
