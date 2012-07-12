//-----------------------------------------------------------------------
// <copyright file="SettingsPage.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.Linq;
    using Microsoft.Phone.Controls;

    public partial class SettingsPage : PhoneApplicationPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            SettingsRepository settingsRepository = new SettingsRepository();

            // TODO: Add as field and bind up instead.
            Settings settings = settingsRepository.Get();

            this.ExpireAfterDays.SelectedItem =
                this.ExpireAfterDays.Items
                    .OfType<ListPickerItem>()
                    .Where(i => (string)i.Tag == settings.ExpireAfterDays.ToString())
                    .Single();

            // TODO: Can this be done any nicer?  Make sure it can't error.
            this.UnitType.SelectedItem =
                this.UnitType.Items
                    .OfType<ListPickerItem>()
                    .Where(i => (string)i.Content == settings.UnitType.ToString())
                    .Single();
        }

        private void ApplicationBarIconButton_Save_Click(object sender, EventArgs e)
        {
            // TODO: Add save operation.
            SettingsRepository settingsRepository = new SettingsRepository();

            Settings settings = settingsRepository.Get();

            // TODO: Add robustness here, probably mostly in input validation.
            ListPickerItem expireItem = this.ExpireAfterDays.SelectedItem as ListPickerItem;

            if (expireItem != null)
            {
                settings.ExpireAfterDays = int.Parse(expireItem.Tag.ToString());
            }

            ListPickerItem item = this.UnitType.SelectedItem as ListPickerItem;

            if (item != null)
            {
                settings.UnitType =
                    (UnitType)Enum.Parse(
                        typeof(UnitType),
                        item.Content.ToString(),
                        false);
            }

            settingsRepository.Save(settings);

            App.ViewModel.LoadData();

            NavigationService.GoBack();
        }

        private void ApplicationBarIconButton_Cancel_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void EditCategoriesButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ViewCategoriesPage.xaml", UriKind.Relative));
        }
    }
}