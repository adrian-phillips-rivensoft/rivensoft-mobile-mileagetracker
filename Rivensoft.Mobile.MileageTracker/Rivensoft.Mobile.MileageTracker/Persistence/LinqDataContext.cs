//-----------------------------------------------------------------------
// <copyright file="LinqDataContext.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.Data.Linq;

    public class LinqDataContext : DataContext
    {
        public LinqDataContext(string fileOrConnection)
            : base(fileOrConnection)
        {
        }

        public Table<JourneyLinqEntity> Journeys;
    }
}
