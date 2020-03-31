using ShellAppSample.Helpers;
using ShellAppSample.ViewModels;

using ShellAppSample.Services;
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
	public partial class AddNetwork : ContentPage
	{
		public AddNetwork ()
		{
			InitializeComponent ();
		}
        ApiService apiService = new ApiService();
        private AddNetworkModel addNetworkModel;
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var accessToken = Settings.AccessToken;
            var EmailEntry = EmailAdd.Text;
            addNetworkModel = new AddNetworkModel
            {
                accessT = accessToken,
                Email = EmailEntry
            };
            await apiService.PostNotworkAsync(addNetworkModel, ShellAppSample.Helpers.Settings.AccessToken);
        }
    }
}