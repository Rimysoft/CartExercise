using System.Globalization;

namespace CartExercise.Model
{
    public class PriceInfo
    {
        private CultureInfo culture;

        public PriceInfo(double value)
        {
            culture = CultureInfo.CreateSpecificCulture("en-US");
            Value = value;
        }

        public double Value { get; set; }
        public string GetFormattedStringValue
        {
            get
            {
                //return Value.ToString("F", culture);
                return Value.ToString("#0.00", CultureInfo.InvariantCulture);
            }
        }
    }
}
