using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SPRTMT2
{
    class Image : BindableObject
	{
		private string imagePath;
		public string ImagePath
		{
			get { return imagePath; }
			set { imagePath = value; base.OnPropertyChanged(); }
		}
	}
}
