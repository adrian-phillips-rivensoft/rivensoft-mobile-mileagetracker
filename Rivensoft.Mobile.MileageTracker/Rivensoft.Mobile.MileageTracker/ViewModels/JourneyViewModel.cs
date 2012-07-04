﻿//-----------------------------------------------------------------------
// <copyright file="JourneyViewModel.cs" company="Rivensoft Limited">
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
    using System.ComponentModel;

    public class JourneyViewModel : ViewModelBase
    {
        private string date;

        private string startMileage;

        private string endMileage;

        public string Date
        {
            get
            {
                return this.date ?? string.Empty;
            }

            set
            {
                if (value != this.date)
                {
                    this.date = value;

                    base.NotifyPropertyChanged("Date");
                }
            }
        }

        public string StartMileage
        {
            get
            {
                return this.startMileage ?? string.Empty;
            }

            set
            {
                if (value != this.startMileage)
                {
                    this.startMileage = value;

                    base.NotifyPropertyChanged("StartMileage");
                }
            }
        }

        public string EndMileage
        {
            get
            {
                return this.endMileage ?? string.Empty;
            }

            set
            {
                if (value != this.endMileage)
                {
                    this.endMileage = value;

                    base.NotifyPropertyChanged("EndMileage");
                }
            }
        }
    }
}
