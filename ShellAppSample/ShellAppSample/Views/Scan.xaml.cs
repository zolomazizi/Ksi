
using ShellAppSample.Models;
using ShellAppSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellAppSample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Scan : ContentPage
	{
		public Scan ()
		{
			InitializeComponent ();
		}
        ApiService apiService = new ApiService();
        private Lacalisation lacalisation;

        private async void Button_Clicked(object sender, EventArgs e)
        {
           
               
                    //var locator = CrossGeolocator.Current;
                    //locator.DesiredAccuracy = 50;
                    //var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));
                    //Device.BeginInvokeOnMainThread(() =>
                    //{
                    //    var att = position.Latitude;
                    //    var entt = position.Longitude;
                    //    lacalisation = new Lacalisation
                    //    {
                    //        Att = (float)att,
                    //        Entt = (float)entt
                    //    };
                    //});


            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.High);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                     Device.BeginInvokeOnMainThread(() =>
                    {
                        var att = location.Latitude;
                        var entt = location.Longitude;
                        lacalisation = new Lacalisation
                        {
                            Att = (float)att,
                            Entt = (float)entt
                        };
                    });
                    await apiService.PostLocalAsync(lacalisation, ShellAppSample.Helpers.Settings.AccessToken);

                    LongitudeLabel.Text = location.Longitude.ToString();
                    latiudeLabel.Text = location.Latitude.ToString();


                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                await DisplayAlert("Message", "gps not availed", "ok ");
            }
            catch (FeatureNotEnabledException fneEx)
            {
                await DisplayAlert("Message", " gps not enabled ", "ok");
            }
            catch (PermissionException pEx)
            {
                await DisplayAlert("Message", " gps not enabled ", "ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Message", "gps not availed", "ok ");
            }




        }

    }
}