using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using Usg.Xf.MultiSelectListView.Models;

namespace Usg.Xf.MultiSelectListViewSample.Core
{
	public class MainPageViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public ObservableCollection<SelectableListItem<Person>> Items { get; set; }

		SeparatorVisibility separatorVisibility;
		public SeparatorVisibility SeparatorVisibility
		{
			get { return separatorVisibility; }
			set 
			{
				if (value != separatorVisibility) 
				{
					separatorVisibility = value;
					OnPropertyChanged ();
				}
			}
		}

		// TODO: Convert this to static factory method in MultiSelectListView project which creates a SelectedItem<T> method?
		SelectableListItem<Person> selectedItem;
		public SelectableListItem<Person> SelectedItem
		{
			get { return selectedItem; }
			set 
			{ 
				if (value == null)
					return;
				value.ToggleSelect ();
				selectedItem = null;
				OnPropertyChanged ();
			}
		}

		public MainPageViewModel ()
		{
			LoadItems ();
			SeparatorVisibility = SeparatorVisibility.Default;
		}

		void LoadItems()
		{
			Items = new ObservableCollection<SelectableListItem<Person>> ();
			for (int i = 0; i < 10; i++) 
			{
				foreach (var person in PersonRepository.Persons) 
				{
					Items.Add (new SelectableListItem<Person> { Data = person });
				}
			}
			// Pre-select some items
			Items [1].IsSelected = Items [2].IsSelected = true;
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

