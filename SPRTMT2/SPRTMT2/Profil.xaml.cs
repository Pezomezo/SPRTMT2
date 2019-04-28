using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SPRTMT2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Profil : ContentPage
	{
		public Profil()
		{
			InitializeComponent();
			MyImage.Source = ImageSource.FromFile("profilpic.png");
			BasketballImg.Source = ImageSource.FromFile("basketball.png");
			AmcsiFociImg.Source = ImageSource.FromFile("amcsifoci.png");
			BaseballImg.Source = ImageSource.FromFile("baseball.png");
			FociImg.Source = ImageSource.FromFile("foci.png");

		}
		private void ImgUploaded_Tapped(object sender, EventArgs e)
		{

		}
	}
}