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
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent ();
		}
        private async void Scan(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Scan() , true);

        }
        private async void Test(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickerQuesPage() , true);

        }
        private async void AddFriend(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddNetwork() , true);

        }
        private async void Network(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddNetwork() , true);

        }
        private async void Logout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage(), true);

        }
    }
}