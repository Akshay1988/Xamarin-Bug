// ListViewTestPage.xaml.cs
//
//  Author:
//       Akshay <adhavale@slb.com>
//
//  Copyright (c) 2016 Akshay
//
using System.Diagnostics;
using Xamarin.Forms;

namespace ListViewTest
{
	public partial class ListViewTestPage : ContentPage
	{
		ListView UpcomingListView;

		public ListViewTestPage()
		{
			InitializeComponent();

			UpcomingListView = new ListView(ListViewCachingStrategy.RecycleElement);
			UpcomingListView.AutomationId = "List_UpComingTripsPage_UpcomingListView";
			UpcomingListView.SeparatorVisibility = SeparatorVisibility.Default;
			UpcomingListView.BackgroundColor = Color.White;
			UpcomingListView.ItemsSource = new string[]{"notification"};
			ListContainer.Children.Add(UpcomingListView);

			UpcomingListView.ItemSelected += OnSelected;
			UpcomingListView.ItemTapped += OnTapped;
			UpcomingListView.RowHeight = 100;
		}

		void OnSelected(object sender, SelectedItemChangedEventArgs e)
		{
			Debug.WriteLine(":::: OnSelected ::::");
			UpcomingListView.SelectedItem = null;
		}

		void OnTapped(object sender, ItemTappedEventArgs e)
		{
			Debug.WriteLine(":::: OnTapped ::::");
		}
	}
}
