//-----------------------------------------------------------------------
// <copyright file="LinqEntityBase.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.ComponentModel;

    public class LinqEntityBase : INotifyPropertyChanged, INotifyPropertyChanging
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangingEventHandler PropertyChanging;

        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);

                this.PropertyChanged(this, e);
            }
        }

        protected virtual void NotifyPropertyChanging(string propertyName)
        {
            if (this.PropertyChanging != null)
            {
                var e = new PropertyChangingEventArgs(propertyName);

                this.PropertyChanging(this, e);
            }
        }
    }
}
