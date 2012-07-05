//-----------------------------------------------------------------------
// <copyright file="NewJourneyViewModel.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;

    public class NewJourneyViewModel : ViewModelBase
    {
        private Journey journey;

        public Journey Journey
        {
            get
            {
                return this.journey;
            }

            set
            {
                if (value != this.journey)
                {
                    this.journey = value;

                    this.NotifyPropertyChanged("Journey");
                }
            }
        }
    }
}
