using System;
using UIExamples.ToggleSwitchExample;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UIExamples
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ToggleSwitchUI();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
