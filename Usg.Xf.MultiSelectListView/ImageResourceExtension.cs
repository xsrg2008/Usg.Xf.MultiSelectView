﻿using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace Usg.Xf.MultiSelectListView
{
	[ContentProperty ("Source")]
	public class ImageResourceExtension : IMarkupExtension
	{
		public string Source { get; set; }

		public object ProvideValue (IServiceProvider serviceProvider)
		{
			if (Source == null)
				return null;

			// Do your translation lookup here, using whatever method you require
			var imageSource = ImageSource.FromResource(Source);

			return imageSource;
		}
	}
}

