﻿//-----------------------------------------------------------------------
// <copyright file="JourneyRepository.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Ink;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;
    using System.Collections.Generic;

    public class JourneyRepository
    {
        public IEnumerable<Journey> GetAll()
        {
            List<Journey> journeys = new List<Journey>();

            string connectionString = "Data Source=isostore:/MileageTracker.sdf";

            using (LinqDataContext dataContext = new LinqDataContext(connectionString))
            {
                var dbJourneys = dataContext.Journeys;

                foreach (var dbJourney in dbJourneys)
                {
                    Journey journey =
                        new Journey()
                        {
                            Id = dbJourney.Id,
                            Date = dbJourney.Date,
                            StartMileage = dbJourney.StartMileage,
                            EndMileage = dbJourney.EndMileage
                        };

                    journeys.Add(journey);
                }
            }

            return journeys;
        }

        public Journey GetById(int id)
        {
            Journey journey;

            string connectionString = "Data Source=isostore:/MileageTracker.sdf";

            using (LinqDataContext dataContext = new LinqDataContext(connectionString))
            {
                JourneyLinqEntity dbJourney =
                    dataContext.Journeys
                        .Where(j => j.Id == id)
                        .Single();

                // TODO: Make data adapter or use automapper?
                journey = new Journey()
                {
                    Id = dbJourney.Id,
                    Date = dbJourney.Date,
                    StartMileage = dbJourney.StartMileage,
                    EndMileage = dbJourney.EndMileage
                };
            }

            return journey;
        }

        public void Insert(Journey journey)
        {
            JourneyLinqEntity journeyLinq = new JourneyLinqEntity()
            {
                Date = journey.Date,
                StartMileage = journey.StartMileage,
                EndMileage = journey.EndMileage
            };

            string connectionString = "Data Source=isostore:/MileageTracker.sdf";

            using (LinqDataContext dataContext = new LinqDataContext(connectionString))
            {
                dataContext.Journeys.InsertOnSubmit(journeyLinq);

                dataContext.SubmitChanges();
            }
        }

        public void Update(Journey journey)
        {
            string connectionString = "Data Source=isostore:/MileageTracker.sdf";

            using (LinqDataContext dataContext = new LinqDataContext(connectionString))
            {
                JourneyLinqEntity dbJourney =
                    dataContext.Journeys
                        .Where(j => j.Id == journey.Id)
                        .Single();

                dbJourney.Date = journey.Date;
                dbJourney.StartMileage = journey.StartMileage;
                dbJourney.EndMileage = journey.EndMileage;

                dataContext.SubmitChanges();
            }
        }
    }
}
