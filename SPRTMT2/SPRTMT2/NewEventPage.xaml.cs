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
	public partial class NewEventPage : ContentPage
	{
		string dateSelected = null;
		public NewEventPage()
		{
			InitializeComponent();
			Date.Date = DateTime.Now;
		}
		private async void Button_Clicked(object sender, EventArgs e)
		{
			
			await Navigation.PushAsync(new MainPage(new SportEvent()
			{
				Sport = SportPicker.SelectedItem.ToString(),
				Date  = myDateFormatter( Date.Date.ToString()) + " " + myTimeFormatter( TimePicketr.Time.ToString()),
				Place = PlacePicker.SelectedItem.ToString(),
				PlacesAvailable = PeoplePicker.SelectedItem.ToString(),
				Picture = "profilpiclist.png"
			}
									   ));
			DisplayAlert("Figyelem", "Új hirdetés lett feladva" + Date.Date + " " + TimePicketr.Time, "Köszi" );
		}

		private string myDateFormatter(string input)
		{
			string returnVal = "";

			
				int found = input.IndexOf(":");
				returnVal = input.Substring(0,found-2);

			return returnVal;
		}

		private string myTimeFormatter(string input)
		{
			string returnVal = "";


			int found = input.IndexOf(":");
			returnVal = input.Substring(found-2,5);

			return returnVal;
		}
	}
}