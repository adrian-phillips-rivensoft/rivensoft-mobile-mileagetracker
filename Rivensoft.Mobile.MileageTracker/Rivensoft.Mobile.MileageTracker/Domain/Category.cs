//-----------------------------------------------------------------------
// <copyright file="Category.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;

    public class Category : EntityBase
    {
        private int id;

        private string name;

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
                    this.name = value;

                    this.NotifyPropertyChanged("Name");
                }
            }
        }
    }
}
