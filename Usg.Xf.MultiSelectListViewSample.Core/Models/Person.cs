using System;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Usg.Xf.MultiSelectListViewSample.Core
{
	public class Person : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		string name;
		public string Name 
		{ 
			get { return name; }
			set 
			{
				if (value != name) 
				{
					name = value;
					OnPropertyChanged ();
				}
			}
		}

		string address;
		public string Address
		{
			get { return address; }
			set 
			{
				if (value != address) 
				{
					address = value;
					OnPropertyChanged ();
				}
			}
		}

		int age;
		public int Age 
		{ 
			get { return age; }
			set 
			{ 
				if (age != value) 
				{
					age = value;
					OnPropertyChanged ();
				}
			}
		}

		UriImageSource uriProfileImage;
		public UriImageSource UriProfileImage 
		{
			get { return uriProfileImage; }
			set 
			{
				if (uriProfileImage != value) 
				{
					uriProfileImage = value;
					OnPropertyChanged ();
				}
			}
		}

		#region INotifyPropertyChanged Implementation

		public void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion
	}
}

