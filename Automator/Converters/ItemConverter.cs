using Avalonia.Controls;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automator.Converters
{
    public class ItemConverter : IValueConverter
    {
        object? IValueConverter.Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            ComboBoxItem item = new ComboBoxItem();
            item.Content = value;
            return item;
        }

        object? IValueConverter.ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }
            if (value.GetType() == typeof(ComboBoxItem)) 
            {
                return Convert.ChangeType(((ComboBoxItem)value).Content, targetType, null);
            }
            return null;
        }


    }
}
