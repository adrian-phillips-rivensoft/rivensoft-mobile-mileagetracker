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
        private Journey journey;

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

                this.journey = journeyRepository.GetById(id);

                // TODO: Do this instead using bindings.
                this.Date.Value = journey.Date;
                this.StartMileage.Text = journey.StartMileage.ToString();
                this.EndMileage.Text = journey.EndMileage.ToString();
            }
        } 

        private void ApplicationBarIconButton_Save_Click(object sender, EventArgs e)
        {
            // TODO: Again bindings.
            this.journey.Date = this.Date.Value.Value;
            this.journey.StartMileage = int.Parse(this.StartMileage.Text);
            this.journey.EndMileage = int.Parse(this.EndMileage.Text);

            JourneyRepository journeyRepository = new JourneyRepository();

            journeyRepository.Update(this.journey);

            // TODO: Make the main page load data on navigate to?
            App.ViewModel.LoadData();

            NavigationService.GoBack();
        }

        private void ApplicationBarIconButton_Cancel_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}