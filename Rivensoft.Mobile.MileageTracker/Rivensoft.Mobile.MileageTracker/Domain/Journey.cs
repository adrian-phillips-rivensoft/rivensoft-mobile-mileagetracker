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
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int StartMileage { get; set; }

        public int EndMileage { get; set; }

        public int Miles
        {
            get
            {
                // TODO: Check and throw exceptions?  Or ensure miles are fully validated on entry?
                return this.EndMileage - this.StartMileage;
            }
        }
    }
}