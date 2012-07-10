//-----------------------------------------------------------------------
// <copyright file="SettingsRepository.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.IO.IsolatedStorage;

    public class SettingsRepository
    {
        public Settings Get()
        {
            Settings settings = new Settings();

            IsolatedStorageSettings isolatedStorageSettings = IsolatedStorageSettings.ApplicationSettings;

            if (isolatedStorageSettings.Contains("IsSundayStartOfWeek"))
            {
                settings.IsSundayStartOfWeek = (bool)isolatedStorageSettings["IsSundayStartOfWeek"];
            }

            if (isolatedStorageSettings.Contains("ExpireJourneysAfterMonths"))
            {
                settings.ExpireJourneysAfterMonths = (int)isolatedStorageSettings["ExpireJourneysAfterMonths"];
            }

            if (isolatedStorageSettings.Contains("UnitType"))
            {
                settings.UnitType = (UnitType)isolatedStorageSettings["UnitType"];
            }

            return settings;
        }

        public void Save(Settings settings)
        {
            IsolatedStorageSettings isolatedStorageSettings = IsolatedStorageSettings.ApplicationSettings;

            if (isolatedStorageSettings.Contains("IsSundayStartOfWeek"))
            {
                isolatedStorageSettings["IsSundayStartOfWeek"] = settings.IsSundayStartOfWeek;
            }
            else
            {
                isolatedStorageSettings.Add("IsSundayStartOfWeek", settings.IsSundayStartOfWeek);
            }

            if (isolatedStorageSettings.Contains("ExpireJourneysAfterMonths"))
            {
                isolatedStorageSettings["ExpireJourneysAfterMonths"] = settings.ExpireJourneysAfterMonths;
            }
            else
            {
                isolatedStorageSettings.Add("ExpireJourneysAfterMonths", settings.ExpireJourneysAfterMonths);
            }

            if (isolatedStorageSettings.Contains("UnitType"))
            {
                isolatedStorageSettings["UnitType"] = (int)settings.UnitType;
            }
            else
            {
                isolatedStorageSettings.Add("UnitType", (int)settings.UnitType);
            }

            isolatedStorageSettings.Save();
        }
    }
}
