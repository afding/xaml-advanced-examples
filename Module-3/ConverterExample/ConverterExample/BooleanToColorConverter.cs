using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;

namespace ConverterExample
{
    public class BooleanToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            // Normally, we would use null checking and validity here.
            return (bool)value ? Colors.Green : Colors.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            // We have no need for this yet, so we'll keep it unimplemented.
            throw new NotImplementedException();
        }
    }
}
