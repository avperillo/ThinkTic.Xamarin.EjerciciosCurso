using EjerciciosCurso.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace EjerciciosCurso.MVVM.ViewModels.Converters
{
    public class SemaphoreToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            SemaphoreState state = (SemaphoreState)value;
            switch (state)
            {
                case SemaphoreState.Green:
                    return Color.Green;
                case SemaphoreState.Yellow:
                    return Color.Yellow;
                case SemaphoreState.Red:
                    return Color.Red;
            }

            return Color.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
