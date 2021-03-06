﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFConverterLibrary.Converters
{
    //Based on sample:
    //https://github.com/JekPoint/Xceed.Wpf.Toolkit/blob/master/Src/Xceed.Wpf.Toolkit.LiveExplorer/Samples/DateTime/Converters/DateTimeToTimeSpanConverter.cs
    public class DateTimeToTimeSpanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is System.DateTime)
            {
                System.DateTime time = (System.DateTime)value;
                return new System.TimeSpan(time.Hour, time.Minute, 0);
            }
            return value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
