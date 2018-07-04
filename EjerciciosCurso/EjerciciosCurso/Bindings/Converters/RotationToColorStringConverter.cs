using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace EjerciciosCurso.Bindings.Converters
{
    public class RotationToColorStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double rotation = (double)value;
            if (rotation >= 270)
                return "Green";
            else if (rotation >= 180)
                return "Red";
            else if (rotation >= 90)
                return "Blue";
            else
                return "Orange";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
