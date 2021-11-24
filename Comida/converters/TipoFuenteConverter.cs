using System;
using System.Globalization;
using System.Windows.Data;

namespace ComidaMVVM
{
    class TipoFuenteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string tipo = (string)value, fontFamily;

            switch (tipo)
            {
                case "Americana":
                    fontFamily = "Slim Summer";
                    return fontFamily;
                case "China":
                    fontFamily = "Chinese Wok Food St";
                    return fontFamily;
                case "Mexicana":
                    fontFamily = "Taco Salad";
                    return fontFamily;
                default:
                    fontFamily = "";
                    return fontFamily;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
