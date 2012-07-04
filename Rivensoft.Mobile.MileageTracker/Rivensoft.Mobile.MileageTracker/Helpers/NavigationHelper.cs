//-----------------------------------------------------------------------
// <copyright file="NavigationHelper.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Ink;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;
    using Microsoft.Phone.Controls;

    public static class NavigationHelper
    {
        public static void NavigateToPage(PhoneApplicationPage currentPage, string uri)
        {
            Uri navigateTo = new Uri(uri, UriKind.Relative);

            currentPage.NavigationService.Navigate(navigateTo);
        }
    }
}
