using System;
using System.Collections.Generic;
using System.Text;

namespace CartExercise.Model
{
    public class Tax
    {
        public string Description { get; set; }
        public double PercentageValue { get; set; }
        public Decimal Value { get; set; }
        public TaxType Type { get; set; }

        public double GetPercentageValue
        {
            get
            {
                return PercentageValue / 100;
            }
        }
    }
}
