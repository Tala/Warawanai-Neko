using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace MeediKids
{
    public class HalveTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var fullTime = (TimeSpan)value;
            var halfTime =  TimeSpan.FromTicks(fullTime.Ticks / 2).ToString("g");
            return halfTime;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
