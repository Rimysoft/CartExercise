using System;
using System.Collections.Generic;
using System.Text;

namespace CartExercise.Model
{
    public class Product
    {
        public string Name { get; set; }
        public PriceInfo Price { get; set; }
        public ProductType Type { get; set; }
        public bool Imported { get; set; }
    }
}
