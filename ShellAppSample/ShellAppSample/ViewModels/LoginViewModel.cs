using ShellAppSample.Helpers;
using ShellAppSample.Services;
using ShellAppSample.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
//using static Android.Content.PM.PackageInstaller;

namespace ShellAppSample.ViewModels
{

    class LoginViewModel
    {
        private ApiService apiService = new ApiService();
        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var accesstoken = await apiService.LoginAsync(Username, Password);
                    Settings.AccessToken = accesstoken;
                    if (string.IsNullOrEmpty(Settings.AccessToken))
                    {
                        await App.Current.MainPage.DisplayAlert("Message", "Try again", "ok ");
                        Application.Current.MainPage = new NavigationPage(new LoginPage());
                    }
                    else if (!string.IsNullOrEmpty(Settings.AccessToken))
                    {
                        Application.Current.MainPage = new NavigationPage(new HomePage());
                        
                    }
                   
                    
                });
            }
        }



        public LoginViewModel()
        {
            Username = Settings.Username;
            Password = Settings.Password;
        }
        public ICommand LogoutCommand => new Command(() =>
                                                       {
                                                           Settings.AccessToken = "";
                                                           Settings.Username = "";
                                                           Settings.Password = "";
                                                       });
    }
}
