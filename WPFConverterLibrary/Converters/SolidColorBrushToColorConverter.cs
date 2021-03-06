﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WPFConverterLibrary.Converters
{
    //Based on sample:
    //https://github.com/JekPoint/Xceed.Wpf.Toolkit/blob/master/Src/Xceed.Wpf.Toolkit/Core/Converters/SolidColorBrushToColorConverter.cs
    public class SolidColorBrushToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            SolidColorBrush brush = value as SolidColorBrush;
            if (brush != null)
                return brush.Color;
            return default(Color?);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                Color color = (Color)value;
                return new SolidColorBrush(color);
            }
            return default(SolidColorBrush);
        }
    }
}
