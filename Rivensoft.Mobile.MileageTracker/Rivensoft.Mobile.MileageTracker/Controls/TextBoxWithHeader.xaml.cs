

namespace Rivensoft.Mobile.MileageTracker.Controls
{
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
    using System.ComponentModel;

    public partial class TextBoxWithHeader : UserControl
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public TextBoxWithHeader()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(this.Name))
            {
                this.Header = "textBoxWithHeader";
            }
            else
            {
                this.Header = this.Name;
            }
            
            this.textBlockHeader.Foreground = (Brush)Application.Current.Resources["PhoneSubtleBrush"];
        }

        public string Header
        {
            get
            {
                return this.textBlockHeader.Text;
            }

            set
            {
                if (value != this.textBlockHeader.Text)
                {
                    this.textBlockHeader.Text = value;

                    this.NotifyPropertyChanged("Header");
                }
            }
        }

        public string Text
        {
            get
            {
                return this.textBoxValue.Text;
            }

            set
            {
                if (value != this.textBoxValue.Text)
                {
                    this.textBoxValue.Text = value;

                    this.NotifyPropertyChanged("Text");
                }
            }
        }

        public InputScope InputScope
        {
            get
            {
                return this.textBoxValue.InputScope;
            }

            set
            {
                this.textBoxValue.InputScope = value;
            }
        }

        public int MaxLength
        {
            get
            {
                return this.textBoxValue.MaxLength;
            }

            set
            {
                this.textBoxValue.MaxLength = value;
            }
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.LayoutRoot.Width = this.Width;
            this.textBoxValue.Width = this.Width;
        }

        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);

                this.PropertyChanged(this, e);
            }
        }
    }
}
