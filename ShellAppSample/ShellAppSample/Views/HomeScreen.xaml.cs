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
	public partial class HomeScreen : ContentPage
	{
		public HomeScreen ()
		{
			InitializeComponent ();
		}

        private async void Login(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage() , true);

        }

        private async void Register(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage(), true);

        }

        private async void Test(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage() , true);

        }


    }
}