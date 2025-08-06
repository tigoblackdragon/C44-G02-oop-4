using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
            Normalize();
        }

        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }

            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }

        public override string ToString()
        {
            string result = "";
            if (Hours > 0) result += $"Hours: {Hours}, ";
            if (Minutes > 0 || Hours > 0) result += $"Minutes: {Minutes}, ";
            result += $"Seconds: {Seconds}";
            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration d)
                return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
            return false;
        }

        public override int GetHashCode()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(
                d1.Hours + d2.Hours,
                d1.Minutes + d2.Minutes,
                d1.Seconds + d2.Seconds
            );
        }

        public static Duration operator +(Duration d1, int seconds)
        {
            return new Duration(d1.Hours, d1.Minutes, d1.Seconds + seconds);
        }

        public static Duration operator +(int seconds, Duration d1) => d1 + seconds;

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int total1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int total2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return new Duration(Math.Max(0, total1 - total2));
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }

        public static bool operator true(Duration d)
        {
            return d.TotalSeconds() != 0;
        }

        public static bool operator false(Duration d)
        {
            return d.TotalSeconds() == 0;
        }

        private int TotalSeconds() => Hours * 3600 + Minutes * 60 + Seconds;
    }

}
