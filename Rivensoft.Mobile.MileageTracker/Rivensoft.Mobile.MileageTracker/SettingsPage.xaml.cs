//-----------------------------------------------------------------------
// <copyright file="SettingsPage.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using Microsoft.Phone.Controls;

    public partial class SettingsPage : PhoneApplicationPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_Save_Click(object sender, EventArgs e)
        {
            // TODO: Add save operation.
        }

        private void ApplicationBarIconButton_Cancel_Click(object sender, EventArgs e)
        {
            Uri navigateTo = new Uri("/MainPage.xaml", UriKind.Relative);

            NavigationService.Navigate(navigateTo);
        }
    }
}