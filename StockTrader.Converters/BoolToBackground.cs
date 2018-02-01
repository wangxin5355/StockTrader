using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Data;
using System.Windows.Media;

namespace StockTrader.Converters
{
    public class BoolToBackground : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var result = (bool)value;
            if (result)
            {
                return Brushes.Green;
            }
            else
            {
                return Brushes.Red;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
