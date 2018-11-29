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
        public static long NumbersOnly(this String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return  0;
            }
            long result = 0;
             Int64.TryParse(Regex.Replace(str, @"[^0-9]+", ""),out result);
            return result;

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
