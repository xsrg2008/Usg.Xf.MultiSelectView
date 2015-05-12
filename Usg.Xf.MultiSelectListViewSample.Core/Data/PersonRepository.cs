using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Usg.Xf.MultiSelectListViewSample.Core
{
	public static class PersonRepository
	{
		public static IEnumerable<Person> Persons = new [] 
		{ 
			new Person 
			{
				Name = "Troy", 
			 	Address = "3 Main St.", 
			    Age = 28, 
				UriProfileImage = new UriImageSource { Uri = new Uri("https://lh4.googleusercontent.com/-LOOxOwg1EjA/AAAAAAAAAAI/AAAAAAAAAKI/kglBi6wV0KQ/photo.jpg?sz=100") } 
			},
			new Person 
			{
				Name = "Derek", 
				Address = "37 Broadway Ave.", 
				Age = 27, 
				UriProfileImage = new UriImageSource { Uri = new Uri("https://graph.facebook.com/1555193771368874/picture?type=normal") }
			},
			new Person 
			{
				Name = "Drea", 
				Address = "3108 12th Ave.", 
				Age = 32, 
				UriProfileImage = new UriImageSource { Uri = new Uri("https://graph.facebook.com/1555193771368874/picture?type=normal") }
			},
			new Person 
			{
				Name = "Brenda", 
				Address = "99 Rainbow Rd.", 
				Age = 48, 
				UriProfileImage = new UriImageSource { Uri = new Uri("https://lh4.googleusercontent.com/-LOOxOwg1EjA/AAAAAAAAAAI/AAAAAAAAAKI/kglBi6wV0KQ/photo.jpg?sz=100") }
			}
		};
	}
}

