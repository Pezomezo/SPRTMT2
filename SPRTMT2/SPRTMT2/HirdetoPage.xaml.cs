using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SPRTMT2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HirdetoPage : ContentPage
	{
		private SportEvent sport = null;
		public HirdetoPage(SportEvent sport)
		{
			InitializeComponent();
			this.sport = sport;
			SportName.Text = this.sport.Sport;
			ProfilPic.Source = ImageSource.FromFile("profilpic.png");
			PlaceLabel.Text = this.sport.Place;
			AvailablePlacesLabel.Text = this.sport.PlacesAvailable;
			//CostsLabel.Text = this.sport.Costs;
			DateLabel.Text = this.sport.Date;
			ChatPic.Source = ImageSource.FromFile("chat.png");
			MapsIcon.Source = ImageSource.FromFile("mapsicon.png");
		}
		private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			//Budapest
			//Pécs
			//   Szeged
			//Pomáz 
			//Szentendre 
			//Óbuda 

			var placemark = SelectPlacemark(PlaceLabel.Text);
			var options = new MapLaunchOptions { Name = "Budakalász Sports Complex" };

			await Map.OpenAsync(placemark, options);
		}

		private Placemark SelectPlacemark(string city)
		{
			Placemark placemark = null;

			if (city == "Óbuda")
			{
				placemark = new Placemark
				{
					//Budapest, Laktanya u. 7, 1033 Hungary
					CountryName = "Hungary",
					AdminArea = "Óbuda",
					Thoroughfare = "Szabadtéri edzőpark",
					Locality = "Laktanya u. 7, 1033"
				};
			}
			else if (city == "Pécs")
			{
				placemark = new Placemark
				{
					//Pécs, Verseny u. 11 Hungary
					CountryName = "Hungary",
					AdminArea = "Pécs",
					Thoroughfare = "Atlétikai stadion",
					Locality = "Verseny u. 11, 7622"
				};
			}
			else if (city == "Szentendre")
			{
				placemark = new Placemark
				{
					//V8 Fitness Szentendre, Szentendre, Kálvária út 16, 2000 Hungary
					CountryName = "Hungary",
					AdminArea = "Szentendre",
					Thoroughfare = "V8 Fitness Szentendre",
					Locality = "Kálvária út 16, 2000"
				};
			}
			else if (city == "Pomáz")
			{
				placemark = new Placemark
				{
					//Pomáz, Pomázi focipálya, Sport utca, 2013 Hungary
					CountryName = "Hungary",
					AdminArea = "Pomáz",
					Thoroughfare = "Pomázi focipálya",
					Locality = "Sport utca, 2013"
				};
			}
			else if (city == "Szeged")
			{
				placemark = new Placemark
				{
					//Szeged, Pulz u. 33, 6724 Hungary
					CountryName = "Hungary",
					AdminArea = "Szeged",
					Thoroughfare = "Feeling Center:Fitness és Wellness központ",
					Locality = "Pulz u. 33, 6724"
				};
			}

			return placemark;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			button.Text = "Csatlakozva";
			button.BackgroundColor = Color.LawnGreen;
		}
	}
}