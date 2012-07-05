//-----------------------------------------------------------------------
// <copyright file="MainViewModel.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Linq;

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        public ObservableCollection<ItemViewModel> Items { get; private set; }

        public bool IsDataLoaded { get; private set; }

        public void LoadData()
        {
            this.Items.Clear();

            JourneyRepository journeyRepository = new JourneyRepository();

            IEnumerable<Journey> journeys = journeyRepository.GetAll().Reverse();

            foreach (Journey journey in journeys)
            {
                ItemViewModel item =
                    new ItemViewModel()
                    {
                        Id = journey.Id,
                        LineOne = string.Format("{0:#,0} miles", journey.Miles),
                        LineTwo = journey.Date.ToString("dd/MM/yyyy")
                    };

                this.Items.Add(item);
            }

            this.IsDataLoaded = true;
        }
    }
}