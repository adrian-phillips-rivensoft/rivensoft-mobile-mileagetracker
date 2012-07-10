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
    public partial class ViewCategoriesPage : PhoneApplicationPage
    {
        public ViewCategoriesPage()
        {
            InitializeComponent();

            ViewCategoriesViewModel viewModel = new ViewCategoriesViewModel();

            viewModel.Categories.Add(
                new Category()
                {
                    Name = "Testing"
                });

            this.DataContext = viewModel;
        }

        private void ApplicationBarMenuItem_New_Click(object sender, EventArgs e)
        {

        }
    }
}