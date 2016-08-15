using InterstitialAd.iOS;
using Xamarin.Forms;
using Google.MobileAds;
using System.Threading.Tasks;
using UIKit;

[assembly: Dependency(typeof(InterstitialAdIOS))]
namespace InterstitialAd.iOS
{
	public class InterstitialAdIOS : I_InterstitialAd
	{
		const string intersitialId = "ca-app-pub-6079257965675046/3676981213";

		Interstitial adInterstitial;

		public async void show()
		{
			adInterstitial = new Interstitial(intersitialId);
			adInterstitial.LoadRequest(Request.GetDefaultRequest());

			// We need to wait until the Intersitial is ready to show
			do
			{
				await Task.Delay(100);
			} while (!adInterstitial.IsReady);

			// Once is ready, show the ad on Main thread
			//InvokeOnMainThread(() => adInterstitial.PresentFromRootViewController(navController));
			Device.BeginInvokeOnMainThread(() => adInterstitial.PresentFromRootViewController(UIApplication.SharedApplication.Windows[0].RootViewController));
		}

	}

}

