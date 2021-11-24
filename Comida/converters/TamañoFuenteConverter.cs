using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ComidaMVVM
{
    class TamañoFuenteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string tipo = (string)value;
            int fontSize;

            switch (tipo)
            {
                case "Americana":
                    fontSize = 38;
                    return fontSize;
                case "China":
                    fontSize = 20;
                    return fontSize;
                case "Mexicana":
                    fontSize = 38;
                    return fontSize;
                default:
                    fontSize = 20;
                    return fontSize;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}

