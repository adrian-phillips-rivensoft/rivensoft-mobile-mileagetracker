//-----------------------------------------------------------------------
// <copyright file="JourneyLog.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.Collections.Generic;

    public class JourneyLog
    {
        private readonly IList<Journey> journeys;

        public JourneyLog()
        {
            this.journeys = new List<Journey>();
        }

        public IEnumerable<Journey> Journeys
        {
            get
            {
                return this.journeys;
            }
        }

        public void LogJourney(Journey journey)
        {
            this.journeys.Add(journey);
        }
    }
}
