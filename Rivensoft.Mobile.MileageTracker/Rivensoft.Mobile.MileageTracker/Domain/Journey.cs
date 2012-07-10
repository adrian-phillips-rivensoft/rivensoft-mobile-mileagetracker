//-----------------------------------------------------------------------
// <copyright file="Journey.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;

    public class Journey : EntityBase
    {
        private int id;

        private DateTime date;

        private int startMileage;

        private int endMileage;

        private Category category;

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value != this.id)
                {
                    this.id = value;

                    this.NotifyPropertyChanged("Id");
                }
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                if (value != this.date)
                {
                    this.date = value;

                    this.NotifyPropertyChanged("Date");
                }
            }
        }

        public int StartMileage
        {
            get
            {
                return this.startMileage;
            }

            set
            {
                if (value != this.startMileage)
                {
                    this.startMileage = value;

                    this.NotifyPropertyChanged("StartMileage");
                }
            }
        }

        public int EndMileage
        {
            get
            {
                return endMileage;
            }

            set
            {
                if (value != this.endMileage)
                {
                    this.endMileage = value;

                    this.NotifyPropertyChanged("EndMileage");
                }
            }
        }

        public Category Category
        {
            get
            {
                return this.category;
            }

            set
            {
                if (value != this.category)
                {
                    this.category = value;

                    this.NotifyPropertyChanged("Category");
                }
            }
        }

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