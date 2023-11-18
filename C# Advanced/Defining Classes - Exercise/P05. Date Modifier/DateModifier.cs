﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        public static int GetDifferenceInDays(string start, string end)
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);
            TimeSpan difference = endDate - startDate;
            int differenceInDays = Math.Abs(difference.Days);
            return differenceInDays;
        }
    }
}
