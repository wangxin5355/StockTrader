using System;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace StockTrader.Converters
{
    public class ImageSourceToBitmapImageConverter : IValueConverter
    {
        private static readonly string componentPart = ";component";
        private static readonly string repository = "pack://application:,,,/CRM.Modules.Repository";//需要修改图片路径
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var imageSource = value as string;
            if (string.IsNullOrEmpty(imageSource))
            {
                return null;
            }

            string imagePath = string.Concat(repository, componentPart, imageSource);
            Uri uri = new Uri(Uri.EscapeUriString(imagePath), UriKind.RelativeOrAbsolute);

            return new BitmapImage(uri);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}