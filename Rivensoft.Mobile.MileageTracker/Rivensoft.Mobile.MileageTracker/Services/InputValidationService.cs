﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Rivensoft.Mobile.MileageTracker
{
    public class InputValidationService
    {
        public bool NumbersOnly(Key key)
        {
            if ((key < Key.D0) ||
                (key > Key.D9))
            {
                return false;
            }

            return true;
        }
    }
}
