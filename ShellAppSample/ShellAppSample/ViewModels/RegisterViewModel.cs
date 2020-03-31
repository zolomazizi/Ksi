using ShellAppSample.Helpers;
using ShellAppSample.Services;
using ShellAppSample.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShellAppSample.ViewModels
{

        class RegisterViewModel
        {
            ApiService apiService = new ApiService();
            public string Username { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
            public string Message { get; set; }
            public ICommand RegisterCommand
            {
                get
                {
                    return new Command(async () =>
                    {
                        var isSuccess = await apiService.RegisterAsync(Username, Password, ConfirmPassword);
                        if( Password == ConfirmPassword)
                        {
                            Settings.Username = Username;
                            Settings.Password = Password;
                            if (isSuccess)
                            {
                                Application.Current.MainPage = new NavigationPage(new LoginPage());
                            }
                            else if(!isSuccess)
                            {
                                await App.Current.MainPage.DisplayAlert("Message", "Password Length 8 and Lower Case, Upper Case ,number and symbole ", "ok ");
                                Application.Current.MainPage = new NavigationPage(new RegisterPage());
                            }
                        }
                        else if (Password != ConfirmPassword)
                        {
                            await App.Current.MainPage.DisplayAlert("Message", "Your Password not much the ConfirmePassword", "ok ");
                            Application.Current.MainPage = new NavigationPage(new RegisterPage());
                        }
                       
                    });
                }
            }
        }
}
