//-----------------------------------------------------------------------
// <copyright file="JourneyLinqEntity.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Ink;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;
    using System.Data.Linq;
    using System.Data.Linq.Mapping;

    [Table(Name = "Journey")]
    public class JourneyLinqEntity : LinqEntityBase
    {
        private int id;

        private DateTime date;

        private int startMileage;

        private int endMileage;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL IDENTITY", CanBeNull = false, AutoSync = AutoSync.OnInsert)]
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
                    base.NotifyPropertyChanging("Id");

                    this.id = value;

                    base.NotifyPropertyChanged("Id");
                }
            }
        }

        [Column]
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
                    base.NotifyPropertyChanging("Date");

                    this.date = value;

                    base.NotifyPropertyChanged("Date");
                }
            }
        }

        [Column]
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
                    base.NotifyPropertyChanging("StartMileage");

                    this.startMileage = value;

                    base.NotifyPropertyChanged("StartMileage");
                }
            }
        }

        [Column]
        public int EndMileage
        {
            get
            {
                return this.endMileage;
            }

            set
            {
                if (value != this.endMileage)
                {
                    base.NotifyPropertyChanging("EndMileage");

                    this.endMileage = value;

                    base.NotifyPropertyChanged("EndMileage");
                }
            }
        }

        [Column(IsVersion = true)]
        public Binary Version { get; set; }
    }
}
