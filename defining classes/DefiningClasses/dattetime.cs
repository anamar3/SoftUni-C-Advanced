using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class DateModifier
    {
       public static int CalculateDifference(string firstDate,string SecondDate)
        {
            DateTime first = DateTime.Parse(firstDate);
            DateTime second = DateTime.Parse(SecondDate);
            int result = (int)(second - first).TotalDays;

            return result;
        }



    }
}
