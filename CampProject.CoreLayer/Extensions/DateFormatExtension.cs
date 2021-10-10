using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProject.CoreLayer.Extensions
{
    public static class DateFormatExtension
    {

        public static string ToTurkishDateString(this DateTime dateTime,string format= "dd-MMMM-yyyy")
        {
            return dateTime.ToString(format, new CultureInfo("tr-TR"));
        }
    }
}
