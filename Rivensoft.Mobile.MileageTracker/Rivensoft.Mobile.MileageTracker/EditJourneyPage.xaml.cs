using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Rivensoft.Mobile.MileageTracker
{
    public partial class EditJourneyPage : PhoneApplicationPage
    {
        public EditJourneyPage()
        {
            InitializeComponent();
        }

        // TODO: Looks to count an on navigated to event when returning from the date picker.  Check this
        //       and see if you can do this some other way?  Maybe bindings again.
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string idParam = string.Empty;

            if (this.NavigationContext.QueryString.TryGetValue("Id", out idParam))
            {
                JourneyRepository journeyRepository = new JourneyRepository();

                int id = int.Parse(idParam);

                EditJourneyViewModel viewModel = new EditJourneyViewModel();
                viewModel.Journey = journeyRepository.GetById(id);

                this.DataContext = viewModel;
            }
        } 

        private void ApplicationBarIconButton_Save_Click(object sender, EventArgs e)
        {
            JourneyRepository journeyRepository = new JourneyRepository();

            Journey journey = ((EditJourneyViewModel)this.DataContext).Journey;

            journeyRepository.Update(journey);

            // TODO: Make the main page load data on navigate to?
            App.ViewModel.LoadData();

            NavigationService.GoBack();
        }

        private void ApplicationBarIconButton_Cancel_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void StartMileage_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            // TODO: Define this elsewhere.
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