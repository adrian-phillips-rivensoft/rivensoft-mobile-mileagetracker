//-----------------------------------------------------------------------
// <copyright file="ViewCategoriesViewModel.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using System.Collections.ObjectModel;

    public class ViewCategoriesViewModel : ViewModelBase
    {
        public ObservableCollection<Category> Categories { get; set; }

        public ViewCategoriesViewModel()
        {
            this.Categories = new ObservableCollection<Category>();
        }
    }
}
