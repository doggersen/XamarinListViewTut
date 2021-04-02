using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinListViewTut.View
{ 
    class NumberToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double.Parse((string)value);
            return value; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            value.ToString();
            return value;
        }
    }
}
