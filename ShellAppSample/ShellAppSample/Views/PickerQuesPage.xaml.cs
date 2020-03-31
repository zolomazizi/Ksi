using ShellAppSample.Helpers;
using ShellAppSample.Services;
using ShellAppSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellAppSample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerQuesPage : ContentPage
	{
		public PickerQuesPage ()
		{
			InitializeComponent ();
            BindingContext = new PickerRepViewModel();

        }
        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new SeeResultat());

        //}

        ApiService apiService = new ApiService();
        private async void Button_Clicked(object sender, EventArgs e)
        {
            try {
                var accesstoken = Settings.AccessToken;
                var status = await apiService.GetStatusAsync(accesstoken);
                StatusR.Text = status;
            }
            catch (Exception b)
            {
                await Navigation.PushAsync(new LoginPage());
            }
           
           
        }
    }
}