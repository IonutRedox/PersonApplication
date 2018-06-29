using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;

namespace UserLayer.Helper
{
    public class TypeConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] is int && (int)values[0] != 0)
            {
                return values[0].ToString();
            }
            else
            {
                if (values[0] is string && string.IsNullOrEmpty(values[0] as string) == false)
                {
                    return values[0].ToString();
                }
            }
            return values[1].ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
