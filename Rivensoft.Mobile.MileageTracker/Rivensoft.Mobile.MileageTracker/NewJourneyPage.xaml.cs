﻿//-----------------------------------------------------------------------
// <copyright file="NewJourneyPage.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;
    using Microsoft.Phone.Controls;

    public partial class NewJourneyPage : PhoneApplicationPage
    {
        public NewJourneyPage()
        {
            InitializeComponent();

            this.JourneyDate.Value = DateTime.Now.Date;
        }

        private void ApplicationBarIconButton_Save_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToPage(this, "/MainPage.xaml");
        }

        private void ApplicationBarIconButton_Cancel_Click(object sender, EventArgs e)
        {
            NavigationHelper.NavigateToPage(this, "/MainPage.xaml");
        }
    }
}