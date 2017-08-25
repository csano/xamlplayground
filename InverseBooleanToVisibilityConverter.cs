using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace XamlPlayground
{
    public class InverseBooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
            {
                throw new Exception();
            }
            var converter = new BooleanToVisibilityConverter();
            return converter.Convert(!(bool)value, targetType, parameter, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
