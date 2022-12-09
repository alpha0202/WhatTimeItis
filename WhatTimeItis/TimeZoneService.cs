using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatTimeItis
{
    internal class TimeZoneService
    {

        public DateTime GetCurrentDateBy(string timeZoneId)
        {
            var intTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            return TimeZoneInfo.ConvertTime(DateTime.Now, intTimeZone);

        }
    }
}
