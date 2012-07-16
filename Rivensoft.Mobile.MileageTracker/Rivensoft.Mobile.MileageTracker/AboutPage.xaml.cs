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
using System.Reflection;

namespace Rivensoft.Mobile.MileageTracker
{
    public partial class AboutPage : PhoneApplicationPage
    {
        public AboutPage()
        {
            InitializeComponent();

            this.LoadVersionNumber();
        }

        private void LoadVersionNumber()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            string[] parts = assembly.FullName.Split(',');

            this.VersionNumber.Text =
                string.Format(
                    "Version: {0}",
                    parts[1].Split('=')[1]);
        }
    }
}