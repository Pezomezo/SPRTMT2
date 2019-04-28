using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SPRTMT2
{
	public partial class MainPage : ContentPage
	{
		ObservableCollection<SportEvent> Events = null;

		public MainPage(SportEvent sport)
		{

			InitializeComponent();
			ProfilPic.Source = ImageSource.FromFile("profilpic.png");
			//Itt az ember lista ha akarsz itt tudsz hozzaasni meg egy embert (az utolso utan nem kell legyen vesszo)
			Events = new ObservableCollection<SportEvent>()
			{
			//Budapest
			//Pécs
			//Szeged
			//Pomáz 
			//Szentendre 
			//Óbuda 
				new SportEvent { Sport = "Kosárlabda", Picture = "profilpiclist.png", PlacesAvailable = "4/2", Date="16/6/2019 17:00", Place = "Óbuda" },
				new SportEvent { Sport = "Foci", Picture = "profilpiclist.png", PlacesAvailable = "10/6", Date="1/9/2019 13:30", Place = "Pomáz" },
				new SportEvent { Sport = "Fitness", Picture = "profilpiclist.png", PlacesAvailable = "2/2", Date="23/6/2019 09:00" ,Place = "Szeged"  },
				new SportEvent { Sport = "Futás", Picture = "profilpiclist.png", PlacesAvailable = "4/1", Date="17/7/2019 16:00", Place = "Pécs"  },
				new SportEvent { Sport = "Úszás", Picture = "profilpiclist.png", PlacesAvailable = "2/2", Date="3/10/2019 07:00", Place = "Szentendre"  }
			};
			if (sport != null)
			{
				Events.Add(sport);
			}

			EventList.ItemsSource = Events;
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NewEventPage());
		}

		private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Profil());
		}

		private async void EventList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
			{
				return;
			}
			await Navigation.PushAsync(new HirdetoPage((SportEvent)e.SelectedItem));
			((ListView)sender).SelectedItem = null;
		}
	}
}
