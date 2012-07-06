//-----------------------------------------------------------------------
// <copyright file="NewJourneyPage.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Mobile.MileageTracker
{
    using System;
    using Microsoft.Phone.Controls;

    public partial class NewJourneyPage : PhoneApplicationPage
    {
        public NewJourneyPage()
        {
            InitializeComponent();

            this.Date.Value = DateTime.Now.Date;
        }

        private void ApplicationBarIconButton_Save_Click(object sender, EventArgs e)
        {
            // TODO: Verify input, to ensure we have start mileage, end mileage and a date.
            Journey journey = new Journey()
            {
                Date = this.Date.Value.Value,
                StartMileage = int.Parse(this.StartMileage.Text),
                EndMileage = int.Parse(this.EndMileage.Text)
            };

            JourneyRepository journeyRepository = new JourneyRepository();

            journeyRepository.Insert(journey);

            App.ViewModel.LoadData();

            NavigationService.GoBack();
        }

        private void ApplicationBarIconButton_Cancel_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void StartMileage_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            InputValidationService inputValidation = new InputValidationService();

            if (!inputValidation.NumbersOnly(e.Key))
            {
                e.Handled = true;
            }
        }

        private void EndMileage_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            InputValidationService inputValidation = new InputValidationService();

            if (!inputValidation.NumbersOnly(e.Key))
            {
                e.Handled = true;
            }
        }
    }
}