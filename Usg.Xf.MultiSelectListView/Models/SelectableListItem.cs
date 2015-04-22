using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace Usg.Xf.MultiSelectListView.Models
{
	public class SelectableListItem<T> : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public T Data { get; set; }

		bool _isSelected;
		public bool IsSelected
		{
			get { return _isSelected; }
			set
			{
				if (value == _isSelected)
				{
					return;
				}
				_isSelected = value;
				OnPropertyChanged();
			}
		}

		public void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public void ToggleSelect()
		{
			IsSelected = !IsSelected;
		}
	}
}

