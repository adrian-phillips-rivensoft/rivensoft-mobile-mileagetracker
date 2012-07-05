//-----------------------------------------------------------------------
// <copyright file="Settings.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;

    public class Settings
    {
        public Settings()
        {
            this.IsSundayStartOfWeek = false;
            this.ExpireJourneysAfterMonths = 6;
            this.UnitType = UnitType.Miles;
        }

        public bool IsSundayStartOfWeek { get; set; }

        public int ExpireJourneysAfterMonths { get; set; }

        public UnitType UnitType { get; set; }
    }
}
