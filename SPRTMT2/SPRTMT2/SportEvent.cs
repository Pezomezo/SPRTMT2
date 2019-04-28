using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SPRTMT2
{
    public class SportEvent : BindableObject
	{
		private string sport;
		private string picture;
		private string placesAvailable;
		private string date;
		private string place;
		private string costs;
		private string targetGroup;
		private string time;

		public string Sport 
		{
			get { return sport; }
			set { sport = value; base.OnPropertyChanged(); }
		}
		public string PlacesAvailable
		{
			get { return placesAvailable; }
			set { placesAvailable = value; base.OnPropertyChanged(); }
		}
		public string Date
		{
			get { return date; }
			set { date = value; base.OnPropertyChanged(); }
		}

		public string Place
		{
			get { return place; }
			set { place = value; base.OnPropertyChanged(); }
		}

		public string Time
		{
			get { return time; }
			set { time = value; base.OnPropertyChanged(); }
		}
		public string Picture
		{
			get { return picture; }
			set { picture = value; base.OnPropertyChanged(); }
		}
	}
}
