using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsSample
{
    public partial class App : Application
    {
        public App()
        {
            Debug.WriteLine($"**** {this.GetType().Name}:  ctor");
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnStart)}");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnSleep)}");
        }

        protected override void OnResume()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnResume)}");
        }
    }
}
