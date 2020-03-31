using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShellAppSample.Services;
using ShellAppSample.Views;
using ShellAppSample.Helpers;

namespace ShellAppSample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            SetMainPage();
        }
        private void SetMainPage()
        {
            if (!string.IsNullOrEmpty(Settings.AccessToken))
            {
                MainPage = new NavigationPage(new HomePage());
            }
            else if (!string.IsNullOrEmpty(Settings.Username)
                        && !string.IsNullOrEmpty(Settings.AccessToken))
            {
                MainPage = new NavigationPage(new LoginPage());

            }
            else
            {
                MainPage = new NavigationPage(new HomeScreen());

            }
        }

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
    }
}
