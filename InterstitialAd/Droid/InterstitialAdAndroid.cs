using InterstitialAd.Droid;
using Xamarin.Forms;
using Android.Gms.Ads;
using System;

[assembly: Dependency(typeof(InterstitialAdAndroid))]
namespace InterstitialAd.Droid
{
	public class InterstitialAdAndroid : AdListener ,I_InterstitialAd
	{
		 Android.Gms.Ads.InterstitialAd _ad;

		public void show()
		{
			var context =Android.App.Application.Context;

			Android.Gms.Ads.InterstitialAd  ad = new Android.Gms.Ads.InterstitialAd(context);
			ad.AdUnitId = "ca-app-pub-6079257965675046/3676981213";

			_ad = ad;
			OnAdLoaded();
			ad.AdListener = this;

			var requestbuilder = new AdRequest.Builder();
			ad.LoadAd(requestbuilder.Build());

		}

		public override void OnAdLoaded()
		{
			base.OnAdLoaded();

			if (_ad.IsLoaded)
				_ad.Show();
		}

	}

}

