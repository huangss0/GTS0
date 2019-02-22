using System;

namespace HssUtility.General
{
    public class HssDateTime
    {
        /// <summary>
        /// Compare two datetime at Day level
        /// </summary>
        /// <returns>Difference in days</returns>
        public static int CompareDateTime_day(DateTime dt1, DateTime dt2)
        {
            DateTime trimed_dt1 = new DateTime(dt1.Year, dt1.Month, dt1.Day);
            DateTime trimed_dt2 = new DateTime(dt2.Year, dt2.Month, dt2.Day);

            TimeSpan ts = trimed_dt1 - trimed_dt2;
            int days = (int)ts.TotalDays;

            return days;
        }

        public static int CompareDateTime_hour(DateTime dt1, DateTime dt2)
        {
            DateTime trimed_dt1 = new DateTime(dt1.Year, dt1.Month, dt1.Day, dt1.Hour, 0, 0);
            DateTime trimed_dt2 = new DateTime(dt2.Year, dt2.Month, dt2.Day, dt2.Hour, 0, 0);

            TimeSpan ts = trimed_dt1 - trimed_dt2;
            int hours = (int)ts.TotalHours;

            return hours;
        }

        public static int CompareDateTime_minute(DateTime dt1, DateTime dt2)
        {
            DateTime trimed_dt1 = new DateTime(dt1.Year, dt1.Month, dt1.Day, dt1.Hour, dt1.Minute, 0);
            DateTime trimed_dt2 = new DateTime(dt2.Year, dt2.Month, dt2.Day, dt2.Hour, dt2.Minute, 0);

            TimeSpan ts = trimed_dt1 - trimed_dt2;
            int minutes = (int)ts.TotalMinutes;

            return minutes;
        }
    }
}
