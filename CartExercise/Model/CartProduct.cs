using System;
using System.Collections.Generic;
using System.Text;

namespace CartExercise.Model
{
    public class CartProduct
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public string GetStringProductInfo
        {
            get
            {
                return Quantity.ToString() + " " + Product.Name + " at " + Product.Price.GetFormattedStringValue;
            }
        }
    }
}
