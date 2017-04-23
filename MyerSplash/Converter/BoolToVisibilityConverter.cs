﻿using JP.Utils.Helper;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MyerSplash.Converter
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (DeviceHelper.IsDesktop)
            {
                return Visibility.Collapsed;
            }
            return (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
