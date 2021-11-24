using System;
using System.Globalization;
using System.Windows.Data;

namespace ComidaMVVM
{
    class ProcedenciaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string tipo = (string)value, source;

            switch (tipo)
            {
                case "Americana":
                    source = "assets/united_states.png";
                    return source;
                case "China":
                    source = "assets/china.png";
                    return source;
                case "Mexicana":
                    source = "assets/mexico.png";
                    return source;
                default:
                    source = "";
                    return source;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
