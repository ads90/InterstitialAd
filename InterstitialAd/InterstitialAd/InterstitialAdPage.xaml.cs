using Xamarin.Forms;

namespace InterstitialAd
{
	public partial class InterstitialAdPage : ContentPage
	{
		public InterstitialAdPage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			DependencyService.Get<I_InterstitialAd>().show();
		}
	}
}

