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
    public partial class NewCategoryPage : PhoneApplicationPage
    {
        public NewCategoryPage()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_Cancel_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ApplicationBarIconButton_Save_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}