//-----------------------------------------------------------------------
// <copyright file="Journey.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;

    public class Journey
    {
        private readonly Guid id;

        public Journey()
        {
            this.id = Guid.NewGuid();
        }

        public Guid Id
        {
            get
            {
                return id;
            }
        }

        public DateTime Date { get; set; }

        public int StartMileage { get; set; }

        public int EndMileage { get; set; }
    }
}