using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReizApp
{
    public class ClockTask
    {
        // Calculates the lesser angle between the hour and minute arrow of the clock
        // and produces the output in degrees.
        public static double LesserAngle(int hours, int minutes)
        {
            double addedAngle = (double)minutes * 6 / 360 * 30;
            double angleFromHoursToMinutes = Math.Abs(hours * 30 + addedAngle - minutes * 6);

            if (angleFromHoursToMinutes > 180)
            {
                return 360 - angleFromHoursToMinutes;
            }

            return angleFromHoursToMinutes;
        }
    }
}