//-----------------------------------------------------------------------
// <copyright file="NewCategoryViewModel.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;

    public class NewCategoryViewModel : ViewModelBase
    {
        private Category category;

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
    }
}
