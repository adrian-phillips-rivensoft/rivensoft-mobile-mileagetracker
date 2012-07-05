//-----------------------------------------------------------------------
// <copyright file="ItemViewModel.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.ComponentModel;

    public class ItemViewModel : ViewModelBase
    {
        private int id;

        private string lineOne;

        private string lineTwo;

        private string lineThree;

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

                    base.NotifyPropertyChanged("Id");
                }
            }
        }

        public string LineOne
        {
            get
            {
                return this.lineOne;
            }

            set
            {
                if (value != this.lineOne)
                {
                    this.lineOne = value;

                    base.NotifyPropertyChanged("LineOne");
                }
            }
        }

        public string LineTwo
        {
            get
            {
                return this.lineTwo;
            }

            set
            {
                if (value != this.lineTwo)
                {
                    this.lineTwo = value;

                    base.NotifyPropertyChanged("LineTwo");
                }
            }
        }

        public string LineThree
        {
            get
            {
                return this.lineThree;
            }

            set
            {
                if (value != this.lineThree)
                {
                    this.lineThree = value;

                    base.NotifyPropertyChanged("LineThree");
                }
            }
        }
    }
}