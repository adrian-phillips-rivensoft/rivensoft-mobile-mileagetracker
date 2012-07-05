//-----------------------------------------------------------------------
// <copyright file="MainPage.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.Windows;
    using System.Windows.Navigation;
    using Microsoft.Phone.Controls;

    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void ApplicationBarMenuItem_New_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToPage(this, "/NewJourneyPage.xaml");
        }

        private void ApplicationBarMenuItem_Settings_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToPage(this, "/SettingsPage.xaml");
        }

        private void StackPanel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;

            if (element != null)
            {
                NavigationHelper.NavigateToPage(this, "/EditJourneyPage.xaml?Id=" + element.Tag);
            }
        }
    }
}