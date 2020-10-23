using System.Globalization;

namespace CartExercise.Model
{
    public class PriceInfo
    {

        public PriceInfo(double value)
        {
            Value = value;
        }

        public double Value { get; set; }
        public string GetFormattedStringValue
        {
            get
            {
                return Value.ToString("#0.00", CultureInfo.InvariantCulture);
            }
        }
    }
}
