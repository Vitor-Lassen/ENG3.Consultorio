using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ENG3.Consultorio.ApplicationService.Extensions
{
    public static class StringExtension
    {
        public static int NumbersOnly(this String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return  0;
            }
            return Convert.ToInt32(Regex.Replace(str, @"[^0-9]+", ""));
        }
        
        public static string NumbersOnlyString(this String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return "";
            }
            return Regex.Replace(str, @"[^0-9]+", "");
        }
    }
}
