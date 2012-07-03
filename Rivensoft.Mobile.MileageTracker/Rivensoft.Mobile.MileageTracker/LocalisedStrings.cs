//-----------------------------------------------------------------------
// <copyright file="LocalisedStrings.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;

    public class LocalisedStrings
    {
        private static ApplicationResources localisedResources = new ApplicationResources();

        public ApplicationResources LocalisedResources
        {
            get
            {
                return localisedResources;
            }
        }
    }
}
