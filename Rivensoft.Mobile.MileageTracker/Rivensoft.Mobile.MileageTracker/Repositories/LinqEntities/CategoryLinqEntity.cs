//-----------------------------------------------------------------------
// <copyright file="CategoryLinqEntity.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.Data.Linq;
    using System.Data.Linq.Mapping;

    [Table(Name = "Category")]
    public class CategoryLinqEntity : LinqEntityBase
    {
        private int id;

        private string name;

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
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value != this.name)
                {
                    base.NotifyPropertyChanging("Name");

                    this.name = value;

                    base.NotifyPropertyChanged("Name");
                }
            }
        }

        [Column(IsVersion = true)]
        public Binary Version { get; set; }
    }
}
