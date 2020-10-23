using System;
using System.Collections.Generic;
using System.Text;

namespace CartExercise.Utilities
{
    public class Helpers
    {
        public static double Round(double value)
        {
            return Math.Ceiling(value * 20) / 20;
        }
    }
}
